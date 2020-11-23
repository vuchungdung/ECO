using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECO.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string MoreImage { get; set; }

        public bool? Status { get; set; }

        public decimal Price { get; set; }

        public int Quatity { get; set; }

        public int CategoryID { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Warranty { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public int ViewCount { get; set; }
    }
}