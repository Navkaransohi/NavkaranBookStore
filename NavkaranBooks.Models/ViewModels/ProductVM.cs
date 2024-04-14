using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NavkaranBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavkaranBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } // displays all the product details

        public IEnumerable<SelectListItem> CategoryList { get; set; } // install the new feature package
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}