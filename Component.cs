using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs5
{
    public class Component
    {
        public string name;
        public string attribute;
        public string material;
        public string weight;
        public Guid guid = Guid.NewGuid();
        public int backcolor;
        public int x;
        public int y;

        public Component()
        {

        }


    }
}
