using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Тип привода
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DriveTypes : byte
    {
        /// <summary>
        /// Электропривод
        /// </summary>
        [Description("ЭП")]
        Electric = 1,

        /// <summary>
        /// Ручной привод
        /// </summary>
        [Description("РУ")]
        Manual = 2
    }
}
