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

        public string Title { get; set; }   // title of the product

        public string Type { get; set; }    // type of product

        public string Color { get; set; }   // color of that product

        public int Weight { get; set; }     // weight of the product in lbs

        public int Height { get; set; }     // height of the product in inces

        public decimal Price { get; set; }  // price of the product
    }
}