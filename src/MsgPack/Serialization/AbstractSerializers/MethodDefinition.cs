#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MsgPack.Serialization.AbstractSerializers
{
	/// <summary>
	///		Represents method which may not have built metadata.
	/// </summary>
	internal sealed class MethodDefinition
	{
		public readonly string MethodName;
		private readonly MethodInfo _runtimeMethod;
		private MethodInfo _resoolvedMethod;

		public MethodInfo TryGetRuntimeMethod()
		{
			return this._runtimeMethod;
		}

		private readonly TypeDefinition[] _genericArguments;

		public MethodInfo ResolveRuntimeMethod()
		{
			return this.ResolveRuntimeMethodCore( true );
		}

		public MethodInfo TryResolveRuntimeMethod()
		{
			return this.ResolveRuntimeMethodCore( false );
		}

		private MethodInfo ResolveRuntimeMethodCore( bool throws )
		{
			if ( this._resoolvedMethod != null )
			{
				return this._resoolvedMethod;
			}

			if ( this._runtimeMethod != null && !this._runtimeMethod.IsGenericMethodDefinition )
			{
				this._resoolvedMethod = this._runtimeMethod;
				return this._resoolvedMethod;
			}

			if ( this.DeclaringType == null )
			{
				if ( throws )
				{
					throw new InvalidOperationException(
						String.Format(
							CultureInfo.CurrentCulture,
							"'{0}' is building private method, but its MethodBuilder is not specified for this instance.",
							this
						)
					);
				}
				else
				{
					return null;
				}
			}

			var result = this._runtimeMethod;
			if ( result == null )
			{
				var foundMethods =
					this.DeclaringType.ResolveRuntimeType().GetMethods()
						.Where( m => m.Name == this.MethodName )
						.ToArray();
				if ( foundMethods.Length != 1 )
				{
					throw new InvalidOperationException(
						String.Format(
							CultureInfo.CurrentCulture,
							"Failed to get runtime method of '{0}.{1}'.",
							this.DeclaringType.ResolveRuntimeType(),
							this.MethodName
						)
					);
				}

				result = foundMethods[ 0 ];
			}

			this._resoolvedMethod =
				result.IsGenericMethodDefinition
					? result.MakeGenericMethod( this._genericArguments.Select( t => t.ResolveRuntimeType() ).ToArray() )
					: result;
			return this._resoolvedMethod;
		}

		// null for private instance method.
		public readonly TypeDefinition DeclaringType;
		public readonly TypeDefinition ReturnType;
		public readonly TypeDefinition[] ParameterTypes;

		public MethodDefinition( string name, TypeDefinition[] genericArguments, TypeDefinition declaringType, TypeDefinition returnType, params TypeDefinition[] parameterTypes )
		{
			this.MethodName = name;
			this.DeclaringType = declaringType;
			this._runtimeMethod = null;
			this._genericArguments = genericArguments;
			this.ReturnType = returnType;
			this.ParameterTypes = parameterTypes;
		}

		public MethodDefinition( MethodInfo runtimeMethod )
			: this( runtimeMethod, runtimeMethod.GetParameters().Select( p => TypeDefinition.Object( p.ParameterType ) ) ) {}

		public MethodDefinition( MethodInfo runtimeMethod, IEnumerable<TypeDefinition> parameterTypes )
		{
#if DEBUG
			Contract.Assert( runtimeMethod.DeclaringType != null, "runtimeMethod.DeclaringType != null" );
#endif // DEBUG
			this.MethodName = runtimeMethod.Name;
			this.DeclaringType = runtimeMethod.DeclaringType;
			this._runtimeMethod = runtimeMethod;
			this.ReturnType = runtimeMethod.ReturnType;
			this.ParameterTypes = parameterTypes.ToArray();
		}

		public override string ToString()
		{
			var buffer = new StringBuilder( 128 );
			buffer
			.Append( this.ReturnType )
			.Append( ' ' )
			.Append( this.MethodName );

			if ( this._genericArguments != null && this._genericArguments.Length > 0 )
			{
				buffer
				.Append( '`' )
				.Append( this._genericArguments.Length.ToString( "D", CultureInfo.InvariantCulture ) )
				.Append( '[' );
				for ( int i = 0; i < this._genericArguments.Length; i++ )
				{
					if ( i > 0 )
					{
						buffer.Append( ", " );
					}

					buffer.Append( this._genericArguments[ i ] );
				}

				buffer.Append( ']' );
			}

			buffer.Append( '(' );

			for ( int i = 0; i < this.ParameterTypes.Length; i++ )
			{
				if ( i > 0 )
				{
					buffer.Append( ", " );
				}

				buffer.Append( this.ParameterTypes[ i ] );
			}

			buffer.Append( ')' );

			return buffer.ToString();
		}

		public static implicit operator MethodDefinition( MethodInfo method )
		{
			return new MethodDefinition( method );
		}
	}
}