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
    
    public partial class Training
    {
        public Training()
        {
            this.Activities = new HashSet<Activity>();
            this.EventTrainings = new HashSet<EventTraining>();
        }
    
        public int ID { get; set; }
        public int PlanID { get; set; }
        public System.DateTime Day { get; set; }
        public byte Category { get; set; }
        public byte Status { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<EventTraining> EventTrainings { get; set; }
        public virtual Plan Plan { get; set; }
    }
}
