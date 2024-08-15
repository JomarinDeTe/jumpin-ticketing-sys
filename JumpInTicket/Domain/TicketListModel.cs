using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TicketListModel
    {
        public long id { get; set; }
        public string DepartmentName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string StatusName { get; set; }
        public DateTime? DueDate { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDescription { get; set; }
        public string AssignedTo { get; set; }
        public string PriorityName { get; set; }
        public DateTime? DateCreated { get; set; }

    }
}
