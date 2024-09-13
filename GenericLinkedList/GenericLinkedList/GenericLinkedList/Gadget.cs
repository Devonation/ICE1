using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    internal class Gadget
    {
        public Gadget(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
