using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class FoodResponse
    {
        
        public List<Food> Data { get; set; } 
        public Pagination Pagination { get; set;  }
    }
    public class Pagination { 
        public int Current { get; set; } 
        public int PageSize { get; set; } 
        public int Total { get; set; } 
    }
}
