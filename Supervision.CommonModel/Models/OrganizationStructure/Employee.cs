using SupervisionApp.ModelAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    /// <summary>
    /// Класс сотрудника организации
    /// </summary>
    public class Employee : BaseEntity
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string Patronymic { get; set; }

        [MaxLength(1000)]
        public string PhotoPath { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        public SubdivisionDepartment Department { get; set; }

        public Post Post { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<EmployeeFactories> EmployeeFactories { get; set; }

        public override string ToString() => $"{LastName ?? string.Empty} {FirstName?.Trim()[0]}.{Patronymic?.Trim()[0]}.\n{Post?.Name}";
    }
}
