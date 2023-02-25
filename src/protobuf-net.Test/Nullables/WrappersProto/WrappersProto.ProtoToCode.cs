﻿using System.Collections.Generic;
using ProtoBuf.Test.Nullables.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace ProtoBuf.Test.Nullables.WrappersProto
{
    public class WrappersProtoToCode : NullablesTestsBase
    {
        private const string NullWrappedValueAttributeValue = "[global::ProtoBuf.NullWrappedValue]";
        private const string CompatibilityLevel300AttributeValue = "[global::ProtoBuf.CompatibilityLevel(CompatibilityLevel.Level300)]";
        
        public WrappersProtoToCode(ITestOutputHelper log) : base(log)
        {
        }

        [Theory]
        [InlineData(".google.protobuf.DoubleValue", "double?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.FloatValue", "float?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.Int64Value", "long?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.UInt64Value", "ulong?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.Int32Value", "int?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.UInt32Value", "uint?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.BoolValue", "bool?", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.StringValue", "string", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.BytesValue", "byte[]", NullWrappedValueAttributeValue)]
        [InlineData(".google.protobuf.Timestamp", "global::System.DateTime?", CompatibilityLevel300AttributeValue)]
        [InlineData(".google.protobuf.Duration", "global::System.TimeSpan?", CompatibilityLevel300AttributeValue)]
        public void GoogleProtobufWellKnownType_ConvertsToCSharpNullable(string protoFieldType, string csharpGeneratedType, string additionalAttributeValue) 
            => AssertCSharpCodeGeneratorTextEquality(
                protobufSchemaContent: GetSimpleProtobufSchemaContent(protoFieldType),
                generatedCode: GetSimpleCSharpGeneratedCodeContent(csharpGeneratedType, additionalAttributeValue: additionalAttributeValue));
        
        [Theory]
        [InlineData(".google.protobuf.DoubleValue")]
        [InlineData(".google.protobuf.FloatValue")]
        [InlineData(".google.protobuf.Int64Value")]
        [InlineData(".google.protobuf.UInt64Value")]
        [InlineData(".google.protobuf.Int32Value")]
        [InlineData(".google.protobuf.UInt32Value")]
        [InlineData(".google.protobuf.BoolValue")]
        [InlineData(".google.protobuf.StringValue")]
        [InlineData(".google.protobuf.BytesValue")]
        public void GoogleProtobufWellKnownType_RetainsDefaultLogic_IfNullWrappersOptionIsTurnedOff(string protoFieldType) 
            => AssertCSharpCodeGeneratorTextDoesNotContain(
                protobufSchemaContent: GetSimpleProtobufSchemaContent(protoFieldType),
                expectedContent: NullWrappedValueAttributeValue,
                options: new Dictionary<string, string> { { "nullwrappers", "false" } });
        
        [Theory]
        [InlineData(".google.protobuf.Timestamp", "global::System.DateTime?")]
        [InlineData(".google.protobuf.Duration", "global::System.TimeSpan?")]
        public void GoogleProtobufWellKnownType_RetainsDefaultLogic_IfCompatibilityLevelOptionIsTurnedOff(string protoFieldType, string csharpGeneratedType) 
            => AssertCSharpCodeGeneratorTextEquality(
                protobufSchemaContent: GetSimpleProtobufSchemaContent(protoFieldType),
                generatedCode: GetSimpleCSharpGeneratedCodeContent(csharpGeneratedType, protoMemberAttributeValue: "[global::ProtoBuf.ProtoMember(42, DataFormat = global::ProtoBuf.DataFormat.WellKnown)]"),
                options: new Dictionary<string, string> { { "compatlevel", "false" } });

        string GetSimpleProtobufSchemaContent(string fieldType) => @$"
            import ""google/protobuf/wrappers.proto"";
            syntax = ""proto3"";

            message WrappedTest {{
                {fieldType} optionalValue = 42;
            }}
        ";
        
        string GetSimpleCSharpGeneratedCodeContent(
            string csharpGenerateFieldType, 
            string protoMemberAttributeValue = "[global::ProtoBuf.ProtoMember(42)]",
            string additionalAttributeValue = null) => @$"
            // <auto-generated>
            //   This file was generated by a tool; you should avoid making direct changes.
            //   Consider using 'partial classes' to extend these types
            //   Input: default.proto
            // </auto-generated>

            #region Designer generated code
            #pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
            [global::ProtoBuf.ProtoContract()]
            public partial class WrappedTest : global::ProtoBuf.IExtensible
            {{
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                {protoMemberAttributeValue}
                {(!string.IsNullOrEmpty(additionalAttributeValue) ? additionalAttributeValue : string.Empty )}
                public {csharpGenerateFieldType} optionalValue {{ get; set; }}

            }}

            #pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
            #endregion
        ";
    }
}
