using CORE.CoreEntity;
using System;

namespace MODEL.Entities
{
    public class Product:EntityRepository
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }

        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}