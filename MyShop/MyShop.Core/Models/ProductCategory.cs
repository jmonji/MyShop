using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        //public string Id { get; set; }
        public string Category { get; set; }

        // no longer needed bacause the creation of the Id is handled by the base class 
        //public ProductCategory()
        //{
        //    this.Id = Guid.NewGuid().ToString();
        //}
    }
}
