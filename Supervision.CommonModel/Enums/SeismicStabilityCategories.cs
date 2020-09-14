using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Категории сейсмостойкости
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum SeismicStabilityCategories : byte
    {
        /// <summary>
        /// С0
        /// </summary>
        [Description("C0")]
        C0 = 1,

        /// <summary>
        /// С
        /// </summary>
        [Description("C")]
        C = 2,

        /// <summary>
        /// С1
        /// </summary>
        [Description("C1")]
        C1 = 3
    }
}
