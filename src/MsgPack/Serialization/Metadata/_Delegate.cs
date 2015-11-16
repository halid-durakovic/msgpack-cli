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

// ReSharper disable InconsistentNaming
using System;
using System.Reflection;

namespace MsgPack.Serialization.Metadata
{
	internal static class _Delegate
	{
#if !NETFX_CORE
		public static readonly MethodInfo CreateDelegate3 =
			FromExpression.ToMethod( ( Type type, object firstArgument, MethodInfo method ) => Delegate.CreateDelegate( type, firstArgument, method ) );
#endif // !NETFX_CORE
	}
}