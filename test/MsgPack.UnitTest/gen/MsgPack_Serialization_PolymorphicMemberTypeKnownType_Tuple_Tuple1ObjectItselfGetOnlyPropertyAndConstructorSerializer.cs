﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor> this_PackValueOfTuple1ObjectItselfPackValueOfTuple1ObjectItselfDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>> _packOperationTable;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor> this_CreateInstanceFromContextCreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, object> this_SetUnpackedValueOfTuple1ObjectItselfSetUnpackedValueOfTuple1ObjectItselfDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfTuple1ObjectItselfUnpackValueOfTuple1ObjectItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            this._serializer0 = context.GetSerializer<object>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>(this.PackValueOfTuple1ObjectItself);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>>(1);
            packOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>(this.PackValueOfTuple1ObjectItself);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple1ObjectItself"};
            this.this_PackValueOfTuple1ObjectItselfPackValueOfTuple1ObjectItselfDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>(this.PackValueOfTuple1ObjectItself);
            this.this_CreateInstanceFromContextCreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfTuple1ObjectItselfSetUnpackedValueOfTuple1ObjectItselfDelegate = new System.Action<UnpackingContext, object>(this.SetUnpackedValueOfTuple1ObjectItself);
            this.this_UnpackValueOfTuple1ObjectItselfUnpackValueOfTuple1ObjectItselfDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple1ObjectItself);
        }
        
        private void PackValueOfTuple1ObjectItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple1ObjectItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor(unpackingContext.Tuple1ObjectItself);
            return result;
        }
        
        private void SetUnpackedValueOfTuple1ObjectItself(UnpackingContext unpackingContext, object unpackedValue) {
            unpackingContext.Tuple1ObjectItself = unpackedValue;
        }
        
        private void UnpackValueOfTuple1ObjectItself(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(object), "Tuple1ObjectItself", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple1ObjectItselfSetUnpackedValueOfTuple1ObjectItselfDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            object ctorArg0 = default(object);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextCreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextCreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public object Tuple1ObjectItself;
            
            public UnpackingContext(object Tuple1ObjectItself) {
                this.Tuple1ObjectItself = Tuple1ObjectItself;
            }
        }
    }
}