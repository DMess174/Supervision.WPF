using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace SupervisionApp.CommonModel.Enums
{
    /// <summary>
    /// Уровни доступа польователей
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum UserRoles : byte
    {
        /// <summary>
        /// Администратор
        /// </summary>
        [Description("Администратор")]
        Admin = 1,

        /// <summary>
        /// Руководитель группы
        /// </summary>
        [Description("Руководитель группы")]
        SeniorEngineer = 2,

        /// <summary>
        /// Инженер ТН
        /// </summary>
        [Description("Инженер")]
        Engineer = 3,

        /// <summary>
        /// Диспетчер
        /// </summary>
        [Description("Диспетчер")]
        Dispatch = 4,

        /// <summary>
        /// Гость
        /// </summary>
        [Description("Гость")]
        Guest = 5
    }
}
