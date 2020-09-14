using SupervisionApp.ModelAPI;
using System.ComponentModel.DataAnnotations;

namespace Supervision.CommonModel.Models.Documentation
{
    /// <summary>
    /// Нормативно-техническая документация
    /// </summary>
    public abstract class TechnicalDocument : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Designation { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Name { get; set; }

        public bool IsInForce { get; set; }

    }
}
