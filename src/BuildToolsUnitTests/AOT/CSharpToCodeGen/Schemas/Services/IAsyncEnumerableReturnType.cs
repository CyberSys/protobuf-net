﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: Services.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace StreamableTestPackage
{
    
    [global::ProtoBuf.ProtoContract()]
    public partial class HelloRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        public string Name { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HelloReply : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"message")]
        public string Message { get; set; }
    }

    [global::System.ServiceModel.ServiceContract(Name = @"Greeter")]
    public partial interface IIGreeter
    {
        global::System.Collections.Generic.IAsyncEnumerable<global::StreamableTestPackage.HelloReply> SayHelloAsync(global::System.Collections.Generic.IAsyncEnumerable<global::StreamableTestPackage.HelloRequest> value, global::ProtoBuf.Grpc.CallContext context = default);

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
