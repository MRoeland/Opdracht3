using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class BasicClass
    {
        public String Description { get; set; }

        public BasicClass(string description)
        {
            Description = description;
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
