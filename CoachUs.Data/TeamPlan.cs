//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoachUs.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamPlan
    {
        public int PlanID { get; set; }
        public int TeamID { get; set; }
        public int CoachID { get; set; }
        public int SharedByUser { get; set; }
    
        public virtual Plan Plan { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Team Team { get; set; }
    }
}
