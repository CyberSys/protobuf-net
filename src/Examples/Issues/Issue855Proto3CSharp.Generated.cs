﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class BarClass : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"string")]
    [global::System.ComponentModel.DefaultValue("")]
    public string String { get; set; } = "";

    [global::ProtoBuf.ProtoMember(2, Name = @"double")]
    public double? Double { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"float")]
    public float? Float { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"bool")]
    public bool? Bool { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"int32")]
    public int? Int32 { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"sint32", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int? Sint32 { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"uint32")]
    public uint? Uint32 { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"int64")]
    public long? Int64 { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"sint64", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long? Sint64 { get; set; }

    [global::ProtoBuf.ProtoMember(10, Name = @"uint64")]
    public ulong? Uint64 { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"fooclass")]
    public FooClass Fooclass { get; set; }

    [global::ProtoBuf.ProtoContract()]
    public partial class FooClass : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
