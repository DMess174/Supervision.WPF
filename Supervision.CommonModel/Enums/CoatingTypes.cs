using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Тип покрытия
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum CoatingTypes : byte
    {
        /// <summary>
        /// C3(I)
        /// </summary>
        [Description("C3(I)")]
        C31 = 1,

        /// <summary>
        /// C3(II)
        /// </summary>
        [Description("C3(II)")]
        C32 = 2,

        /// <summary>
        /// C4(I)
        /// </summary>
        [Description("C4(I)")]
        C41 = 3,

        /// <summary>
        /// C4(II)
        /// </summary>
        [Description("C4(II)")]
        C42 = 4,

        /// <summary>
        /// C5-M
        /// </summary>
        [Description("C5-M")]
        C5M = 5,

        /// <summary>
        /// ПК-40
        /// </summary>
        [Description("ПК-40")]
        PK40 = 6,

        /// <summary>
        /// МПК-40
        /// </summary>
        [Description("МПК-40")]
        MPK40 = 7,

        /// <summary>
        /// ПК-60
        /// </summary>
        [Description("ПК-60")]
        PK60 = 8,

        /// <summary>
        /// МПК-60
        /// </summary>
        [Description("МПК-60")]
        MPK60 = 9,

        /// <summary>
        /// ПК-80
        /// </summary>
        [Description("ПК-80")]
        PK80 = 10,

        /// <summary>
        /// МПК-80
        /// </summary>
        [Description("МПК-80")]
        MPK80 = 11
    }
}
