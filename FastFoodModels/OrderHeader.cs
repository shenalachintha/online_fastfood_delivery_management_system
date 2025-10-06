using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodModels
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public DateTime TimeofPick { get; set; }
        public DateTime DateofPick { get; set; }
        public double SubTotal { get; set; }
        public double OrderTotal { get; set; }
        public String CouponCode { get; set; }
        public double CouponDis { get; set; }
        public String TransId { get; set; }
        public String OrderStatus { get; set; }
        public String PaymentStatus { get; set; }
        public String Name { get; set; }
        public string Phone { get; set; }


    }
}
