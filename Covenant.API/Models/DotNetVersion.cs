// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DotNetVersion.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DotNetVersion
    {
        [EnumMember(Value = "Net35")]
        Net35,
        [EnumMember(Value = "Net40")]
        Net40,
        [EnumMember(Value = "Net50")]
        Net50
    }
    internal static class DotNetVersionEnumExtension
    {
        internal static string ToSerializedValue(this DotNetVersion? value)
        {
            return value == null ? null : ((DotNetVersion)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DotNetVersion value)
        {
            switch( value )
            {
                case DotNetVersion.Net35:
                    return "Net35";
                case DotNetVersion.Net40:
                    return "Net40";
                case DotNetVersion.Net50:
                    return "Net50";
            }
            return null;
        }

        internal static DotNetVersion? ParseDotNetVersion(this string value)
        {
            switch( value )
            {
                case "Net35":
                    return DotNetVersion.Net35;
                case "Net40":
                    return DotNetVersion.Net40;
                case "Net50":
                    return DotNetVersion.Net50;
            }
            return null;
        }
    }
}
