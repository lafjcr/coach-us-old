//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoachUs.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamUser
    {
        public int TeamID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
