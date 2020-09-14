using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Уровни доступа польователей
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum PIDStatus : byte
    {
        /// <summary>
        /// В работе
        /// </summary>
        [Description("В работе")]
        Work = 1,

        /// <summary>
        /// Закрыт
        /// </summary>
        [Description("Закрыт")]
        Done = 2,

        /// <summary>
        /// Отменен
        /// </summary>
        [Description("Отменен")]
        Cancel = 3
    }
}
