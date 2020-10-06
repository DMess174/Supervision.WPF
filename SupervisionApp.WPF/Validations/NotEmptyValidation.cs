using System.Globalization;
using System.Windows.Controls;

namespace SupervisionApp.WPF.Validations
{
    public class NotEmptyValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "Обязательное поле.")
                : ValidationResult.ValidResult;
        }
    }
}
