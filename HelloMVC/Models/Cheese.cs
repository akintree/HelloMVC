using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Models
{
    public class Cheese
    {
        public string Name;
        public string Description;

        public Cheese (string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
