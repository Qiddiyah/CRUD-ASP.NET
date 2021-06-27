using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP.NET_TEST.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }

        public string Image { get; set; }

        internal static Product Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
