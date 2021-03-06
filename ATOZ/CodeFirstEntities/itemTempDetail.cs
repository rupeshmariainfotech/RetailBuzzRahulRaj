﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntities
{
    [Serializable]
     public class itemTempDetail
    {
        [Key]
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemCode { get; set; }
        public string itemCategory { get; set; }
        public string itemSubCategory { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime? modifedOn { get; set; }
        public string costprice { get; set; }
        public string typeOfMaterial { get; set; }
        public string colorCode { get; set; }
        public string designCode { get; set; }
        public string sellingprice { get; set; }
        public string mrp { get; set; }
        public string brandName { get; set; }
        public string size { get; set; }
        public IEnumerable<ItemCategory> itemCategoryList { get; set; }
        public IEnumerable<ItemSubCategory> itemSubCategoryList { get; set; }
    }
}
