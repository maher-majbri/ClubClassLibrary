using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public class Membership
    {
        public int Id { get; set; }


        public int MemberId { get; set; }
       
        public Member Member { get; set; }

        public int MembershipTypeId { get; set; } // Foreign Key
       
        public MembershipType MembershipType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; } // Store the price at the time of purchase.


        public List<Payment> Payments { get; set; }
    }
}
