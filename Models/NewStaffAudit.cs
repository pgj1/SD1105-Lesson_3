using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class NewStaffAudit
    {
        public int StaffAuditId { get; set; }
        public int? NewStaffId { get; set; }
        public string Username { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Status { get; set; }
    }
}
