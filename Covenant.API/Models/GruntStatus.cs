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
    /// Defines values for GruntStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GruntStatus
    {
        [EnumMember(Value = "Uninitialized")]
        Uninitialized,
        [EnumMember(Value = "Stage0")]
        Stage0,
        [EnumMember(Value = "Stage1")]
        Stage1,
        [EnumMember(Value = "Stage2")]
        Stage2,
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Lost")]
        Lost,
        [EnumMember(Value = "Exited")]
        Exited,
        [EnumMember(Value = "Disconnected")]
        Disconnected,
        [EnumMember(Value = "Hidden")]
        Hidden
    }
    internal static class GruntStatusEnumExtension
    {
        internal static string ToSerializedValue(this GruntStatus? value)
        {
            return value == null ? null : ((GruntStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GruntStatus value)
        {
            switch( value )
            {
                case GruntStatus.Uninitialized:
                    return "Uninitialized";
                case GruntStatus.Stage0:
                    return "Stage0";
                case GruntStatus.Stage1:
                    return "Stage1";
                case GruntStatus.Stage2:
                    return "Stage2";
                case GruntStatus.Active:
                    return "Active";
                case GruntStatus.Lost:
                    return "Lost";
                case GruntStatus.Exited:
                    return "Exited";
                case GruntStatus.Disconnected:
                    return "Disconnected";
                case GruntStatus.Hidden:
                    return "Hidden";
            }
            return null;
        }

        internal static GruntStatus? ParseGruntStatus(this string value)
        {
            switch( value )
            {
                case "Uninitialized":
                    return GruntStatus.Uninitialized;
                case "Stage0":
                    return GruntStatus.Stage0;
                case "Stage1":
                    return GruntStatus.Stage1;
                case "Stage2":
                    return GruntStatus.Stage2;
                case "Active":
                    return GruntStatus.Active;
                case "Lost":
                    return GruntStatus.Lost;
                case "Exited":
                    return GruntStatus.Exited;
                case "Disconnected":
                    return GruntStatus.Disconnected;
                case "Hidden":
                    return GruntStatus.Hidden;
            }
            return null;
        }
    }
}