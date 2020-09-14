using Supervision.CommonModel.Models.Orders;
using System.Collections.Generic;

namespace Supervision.CommonModel.Models.Documentation
{
    /// <summary>
    /// НТД на покрытие
    /// </summary>
    public class CoatingDocument : TechnicalDocument
    {
        public ICollection<CoatingTypeDocument> CoatingTypes { get; set; }
    }
}
