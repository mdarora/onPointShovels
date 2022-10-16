using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnPointShovels.Models
{
    public class ShovelTypeViewModel
    {   // view model for the type field in shovel model
        public List<Shovel> Shovels { get; set; }
        public SelectList Types { get; set; }
        public string ShovelType { get; set; }
        public string SearchString { get; set; }
    }
}
