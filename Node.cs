using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs5
{
    public partial class Node : LineShape
    {
        public Guid startID = Guid.NewGuid();
        public Guid endID = Guid.NewGuid();
        public Guid lineID = Guid.NewGuid();
        public int attribute;

        public Node(int attribute)
        {
            InitializeComponent();
            this.attribute = attribute;
        }

        public Node(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
