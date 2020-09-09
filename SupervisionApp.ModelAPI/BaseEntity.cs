using System;

namespace SupervisionApp.ModelAPI
{
    /// <summary>
    /// Базовый класс сущности базы даных
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public string RecordCreator { get; set; }
    }
}
