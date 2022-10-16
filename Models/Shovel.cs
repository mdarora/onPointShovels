using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnPointShovels.Models
{
    public class Shovel
    {
        public int Id { get; set; }

        [StringLength(80, MinimumLength = 5)]
        [Required]
        public string Title { get; set; }   // title of the product

        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string Type { get; set; }    // type of product

        [StringLength(40, MinimumLength = 2)]
        [Required]
        public string Color { get; set; }   // color of that product

        [DisplayName("Weight (lbs)")]
        public int Weight { get; set; }     // weight of the product in lbs

        [DisplayName("Height (inch)")]
        public int Height { get; set; }     // height of the product in inces

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }  // price of the product

        //adding new field
        [Range(1, 5)]
        public int Rating { get; set; }  // Rating for the product
    }
}