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
    
    public partial class Subscription
    {
        public Subscription()
        {
            this.SubscriptionPayments = new HashSet<SubscriptionPayment>();
        }
    
        public int ID { get; set; }
        public int AthleteID { get; set; }
        public int TeamID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public decimal MonthlyFee { get; set; }
        public byte PaymentDay { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual User Athlete { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
