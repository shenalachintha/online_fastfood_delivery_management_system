using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodModels
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = "";
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required,MinLength(1)]
        public int Count { get; set; }
    }
}
