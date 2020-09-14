using Supervision.CommonModel.Models.Documentation;
using SupervisionApp.ModelAPI;

namespace Supervision.CommonModel.Models.Orders
{
    public class PIDCoatingDocument : BaseEntity
    {
        public PID PID { get; set; }
        public CoatingTypeDocument Document { get; set; }
    }
}
