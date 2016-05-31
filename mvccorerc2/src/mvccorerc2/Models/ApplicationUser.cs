using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mvccorerc2.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool IsActive { get; set; }
        public RowStatus IsApproved { get; set; }
        public int ModuleID { get; set; }
        //public bool IsDeleted { get; set; }
        public string IPAddress { get; set; }
        public long TranNo { get; set; }
    }
    public enum RowStatus
    {
        New=0,
        IsApproved=1
    }
}
