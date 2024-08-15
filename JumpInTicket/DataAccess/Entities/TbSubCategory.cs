using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class TbSubCategory
    {
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public bool? IsActive { get; set; }
    }
}
