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
    public class MsgPack_Serialization_ComplexTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfSourceDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfDataDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer2;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfTimeStampDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer3;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfHistoryDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int>> _serializer4;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfPointsDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfSourceAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfDataAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfTimeStampAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfHistoryAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfPointsAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Uri> this_SetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, byte[]> this_SetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfDataDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.DateTime> this_SetUnpackedValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfHistoryDelegate;
        
        private System.Reflection.MethodBase _methodBaseComplexType_set_Points0;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>> this_SetUnpackedValueOfPointsDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfPointsDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfSourceAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<byte[]>> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfDataAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfTimeStampAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfHistoryAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfPointsAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_ComplexTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Uri>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<byte[]>(schema1);
            this._serializer2 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer3 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema2);
            MsgPack.Serialization.PolymorphismSchema schema3 = default(MsgPack.Serialization.PolymorphismSchema);
            schema3 = null;
            this._serializer4 = context.GetSerializer<System.Collections.Generic.List<int>>(schema3);
            this._methodBaseComplexType_set_Points0 = MsgPack.Serialization.ReflectionHelpers.GetMethod(typeof(MsgPack.Serialization.ComplexType), "set_Points", new System.Type[] {
                        typeof(System.Collections.Generic.List<int>)});
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[5];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            packOperationList[4] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>[5];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            packOperationListAsync[3] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            packOperationListAsync[4] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPointsAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>>(5);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            packOperationTable["Points"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(5);
            packOperationTableAsync["Source"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            packOperationTableAsync["Data"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            packOperationTableAsync["TimeStamp"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            packOperationTableAsync["History"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            packOperationTableAsync["Points"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPointsAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[5];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[4] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[5];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            unpackOperationListAsync[3] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            unpackOperationListAsync[4] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPointsAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>>(5);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Points"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(5);
            unpackOperationTableAsync["Source"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            unpackOperationTableAsync["Data"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            unpackOperationTableAsync["TimeStamp"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            unpackOperationTableAsync["History"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            unpackOperationTableAsync["Points"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPointsAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Source",
                    "Data",
                    "TimeStamp",
                    "History",
                    "Points"};
            this.this_PackValueOfSourceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            this.this_PackValueOfDataDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            this.this_PackValueOfTimeStampDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            this.this_PackValueOfHistoryDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            this.this_PackValueOfPointsDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this.this_PackValueOfSourceAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            this.this_PackValueOfDataAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            this.this_PackValueOfTimeStampAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            this.this_PackValueOfHistoryAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            this.this_PackValueOfPointsAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPointsAsync);
            this.this_SetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_UnpackValueOfSourceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            this.this_SetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexType, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_UnpackValueOfDataDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            this.this_SetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.this_UnpackValueOfTimeStampDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            this.this_SetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_UnpackValueOfHistoryDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            this.this_SetUnpackedValueOfPointsDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>>(this.SetUnpackedValueOfPoints);
            this.this_UnpackValueOfPointsDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this.this_UnpackValueOfSourceAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<byte[]>>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValueAsync);
            this.this_UnpackValueOfDataAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            this.this_UnpackValueOfTimeStampAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            this.this_UnpackValueOfHistoryAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            this.this_UnpackValueOfPointsAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPointsAsync);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer1.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer2.PackTo(packer, objectTree.TimeStamp);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer3.PackTo(packer, objectTree.History);
        }
        
        private void PackValueOfPoints(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer4.PackTo(packer, objectTree.Points);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfSourceAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Source, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfDataAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.Data, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfTimeStampAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer2.PackToAsync(packer, objectTree.TimeStamp, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfHistoryAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer3.PackToAsync(packer, objectTree.History, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfPointsAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer4.PackToAsync(packer, objectTree.Points, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexType unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceDelegate);
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexType unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate, this.this_SetUnpackedValueOfDataDelegate);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexType unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampDelegate);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexType unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string> existent = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            existent = unpackingContext.History;
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistoryDelegate);
        }
        
        private void SetUnpackedValueOfPoints(MsgPack.Serialization.ComplexType unpackingContext, System.Collections.Generic.List<int> unpackedValue) {
            System.Collections.Generic.List<int> existent = default(System.Collections.Generic.List<int>);
            existent = unpackingContext.Points;
            if ((existent == null)) {
                this._methodBaseComplexType_set_Points0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
                System.Collections.Generic.List<int>.Enumerator enumerator = unpackedValue.GetEnumerator();
                int current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        existent.Add(current);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        private void UnpackValueOfPoints(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer4, itemsCount, indexOfItem, typeof(System.Collections.Generic.List<int>), "Points", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfPointsDelegate);
        }
        
        protected internal override MsgPack.Serialization.ComplexType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexType result = default(MsgPack.Serialization.ComplexType);
            result = new MsgPack.Serialization.ComplexType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfSourceAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDataAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate, this.this_SetUnpackedValueOfDataDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTimeStampAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfHistoryAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistoryDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfPointsAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer4, itemsCount, indexOfItem, typeof(System.Collections.Generic.List<int>), "Points", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfPointsDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.ComplexType> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.ComplexType result = default(MsgPack.Serialization.ComplexType);
            result = new MsgPack.Serialization.ComplexType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
