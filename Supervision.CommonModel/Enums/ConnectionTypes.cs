using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Тип присоединения
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ConnectionTypes : byte
    {
        /// <summary>
        /// Сварное
        /// </summary>
        [Description("Св")]
        Weld = 1,

        /// <summary>
        /// Фланцевое
        /// </summary>
        [Description("Ф")]
        Flange = 2
    }
}
