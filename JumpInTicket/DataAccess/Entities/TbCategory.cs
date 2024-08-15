using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class TbCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsActive { get; set; }
    }
}
