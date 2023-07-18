using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs5
{
    public partial class Rectangle : RectangleShape
    {
        public Guid panelID;
        public Rectangle()
        {
            InitializeComponent();
        }

        public Rectangle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
