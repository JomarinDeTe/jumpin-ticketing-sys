using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class TbTicket
    {
        public long Id { get; set; }
        public int? DepartmentId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? PriorityId { get; set; }
        public int? StatusId { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDescription { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
