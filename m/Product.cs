using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
    public class Product
    {
        public string Name { get; set; }
        public int? Id { get; set; }
        public int count { get; set; }
        public string Deparment { get; set; }
        public int price { get; set; }
        public int IdDeparment { get; set; }
        public bool Edit { get; set; }
    }
}
