using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int MemberId { get; set; }
      
        public Member Member { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentMethod { get; set; } // e.g., "Cash", "Card", "Check"
        public int? MembershipId { get; set; } //Link to the specific membership the payment is for (nullable in case of other payments)
   
        public Membership Membership { get; set; }



    }
}
