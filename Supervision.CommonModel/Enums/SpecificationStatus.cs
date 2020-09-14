using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum SpecificationStatus : byte
    {
        /// <summary>
        /// Проект
        /// </summary>
        [Description("Проект")]
        Project = 1,

        /// <summary>
        /// Подписана
        /// </summary>
        [Description("Подписана")]
        Signed = 2,

        /// <summary>
        /// Подписана с заявкой на ТН
        /// </summary>
        [Description("Подписана с заявкой на ТН")]
        SignedWithRequest = 3
    }
}
