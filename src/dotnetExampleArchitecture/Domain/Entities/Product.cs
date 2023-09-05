using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product:Entity<Guid>
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        //categoryId naming is special it is a foreign key naming
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
