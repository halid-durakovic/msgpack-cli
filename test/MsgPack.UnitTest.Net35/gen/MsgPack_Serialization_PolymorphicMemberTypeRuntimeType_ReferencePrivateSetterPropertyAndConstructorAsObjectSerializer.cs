﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject> this_PackValueOfReferencePackValueOfReferenceDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>> _packOperationTable;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject_set_Reference0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, object> this_SetUnpackedValueOfReferenceSetUnpackedValueOfReferenceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int> this_UnpackValueOfReferenceUnpackValueOfReferenceDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<object>(schema0);
            this._methodBasePolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject_set_Reference0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject).GetMethod("set_Reference", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(object)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>(this.PackValueOfReference);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>>(1);
            packOperationTable["Reference"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>(this.PackValueOfReference);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>(this.UnpackValueOfReference);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>>(1);
            unpackOperationTable["Reference"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>(this.UnpackValueOfReference);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Reference"};
            this.this_PackValueOfReferencePackValueOfReferenceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>(this.PackValueOfReference);
            this.this_SetUnpackedValueOfReferenceSetUnpackedValueOfReferenceDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, object>(this.SetUnpackedValueOfReference);
            this.this_UnpackValueOfReferenceUnpackValueOfReferenceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject, int, int>(this.UnpackValueOfReference);
        }
        
        private void PackValueOfReference(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject objectTree) {
            this._serializer0.PackTo(packer, objectTree.Reference);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfReference(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject unpackingContext, object unpackedValue) {
            this._methodBasePolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject_set_Reference0.Invoke(unpackingContext, new object[] {
                        unpackedValue});
        }
        
        private void UnpackValueOfReference(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(object), "Reference", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfReferenceSetUnpackedValueOfReferenceDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ReferencePrivateSetterPropertyAndConstructorAsObject>(), this._unpackOperationTable);
            }
        }
    }
}