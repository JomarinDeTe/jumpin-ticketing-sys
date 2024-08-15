using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class TbStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public bool? IsActive { get; set; }
    }
}
