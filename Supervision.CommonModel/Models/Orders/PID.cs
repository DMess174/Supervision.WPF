using Supervision.CommonModel.Enums;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.ModelAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Supervision.CommonModel.Models.Orders
{
    public class PID : ControlledEntity
    {
        [Required]
        [MaxLength(30)]
        public string Number { get; set; }
        public int Amount { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Consignee { get; set; }

        [Required]
        public Specification Specification { get; set; }

        [Required]
        public Factory Factory { get; set; }
        public ProductType ProductType { get; set; }
        public DateTime ShipmentDate { get; set; }
        public PIDStatus Status { get; set; }
        public Diameters Diameter { get; set; }
        public Pressures PressureLimit { get; set; }
        public Pressures PressureDifference { get; set; }
        public ConnectionTypes ConnectionType { get; set; }
        public DriveTypes DriveType { get; set; }
        public SeismicStabilityCategories SeismicStability { get; set; }
        public ClimaticModifications ClimaticModification { get; set; }
        public ICollection<PIDCoatingDocument> CoatingDocuments { get; set; }
    }
}
