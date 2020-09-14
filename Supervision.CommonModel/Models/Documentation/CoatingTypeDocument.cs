using Supervision.CommonModel.Enums;
using Supervision.CommonModel.Models.Orders;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;

namespace Supervision.CommonModel.Models.Documentation
{
    /// <summary>
    /// Сопосавление типа покрытия с НТД
    /// </summary>
    public class CoatingTypeDocument : BaseEntity
    {
        public CoatingDocument Document { get; set; }
        public CoatingTypes CoatingType { get; set; }
        public ICollection<PID> PIDs { get; set; }
    }
}
