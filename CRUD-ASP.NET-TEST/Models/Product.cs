using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP.NET_TEST.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string model { get; set; }

        public string image { get; set; }

        internal static Product Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
