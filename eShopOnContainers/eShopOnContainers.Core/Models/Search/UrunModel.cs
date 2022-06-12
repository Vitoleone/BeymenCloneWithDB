using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Search
{
    public class UrunModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Discount { get; set; }
        public string Price { get; set; }
        public string DiscountedPrice { get; set; }
        public string BedenPicker { get; set; }
        public string RenkPicker { get; set; }
    }
}
