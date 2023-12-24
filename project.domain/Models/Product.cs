using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.Models
{
    public class Product
    { public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId {  get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
