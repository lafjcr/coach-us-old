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
    
    public partial class User
    {
        public User()
        {
            this.AthletePlans = new HashSet<AthletePlan>();
            this.AthletePlans1 = new HashSet<AthletePlan>();
            this.AthletePlans2 = new HashSet<AthletePlan>();
            this.Licenses = new HashSet<License>();
            this.Plans = new HashSet<Plan>();
            this.Plans1 = new HashSet<Plan>();
            this.Sales = new HashSet<Sale>();
            this.Sales1 = new HashSet<Sale>();
            this.Subscriptions = new HashSet<Subscription>();
            this.TeamPlans = new HashSet<TeamPlan>();
            this.TeamPlans1 = new HashSet<TeamPlan>();
            this.Teams = new HashSet<Team>();
            this.TeamUsers = new HashSet<TeamUser>();
        }
    
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Laterality { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public Nullable<int> PictureID { get; set; }
    
        public virtual ICollection<AthletePlan> AthletePlans { get; set; }
        public virtual ICollection<AthletePlan> AthletePlans1 { get; set; }
        public virtual ICollection<AthletePlan> AthletePlans2 { get; set; }
        public virtual File File { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual ICollection<Plan> Plans1 { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Sale> Sales1 { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<TeamPlan> TeamPlans { get; set; }
        public virtual ICollection<TeamPlan> TeamPlans1 { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<TeamUser> TeamUsers { get; set; }
    }
}
