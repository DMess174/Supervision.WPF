using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Значение давления
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Pressures : byte
    {
        [Description("1,6")]
        PN16 = 16,

        [Description("2,5")]
        PN25 = 25,

        [Description("4,0")]
        PN40 = 40,

        [Description("6,3")]
        PN63 = 63,

        [Description("8,0")]
        PN80 = 80,

        [Description("10,0")]
        PN100 = 100,

        [Description("12,5")]
        PN125 = 125,

        [Description("16,0")]
        PN160 = 160,
    }
}
