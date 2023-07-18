using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs5
{
    public partial class PartsPanel : System.Windows.Forms.UserControl
    {
        bool _isDragging = false;
        Point? _diffPoint = null;
        Form1 parent;
        public Guid guid = Guid.NewGuid();
        public int backcolor = 0;  //1:blue 2:green 3:red

        public PartsPanel(Form1 form)
        {
            InitializeComponent();
            parent = form;
            this.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
            this.ContextMenuStrip = this.contextMenuStrip1;
            //Debug.WriteLine(guid.ToString());
        }

        private void PartsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Cursor.Current = Cursors.Hand;
            _isDragging = true;
            _diffPoint = e.Location;


        }

        private void PartsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragging)
            {
                return;
            }
            int x = this.Location.X + e.X - _diffPoint.Value.X;
            int y = this.Location.Y + e.Y - _diffPoint.Value.Y;

            if (x <= 0) x = 0;
            if (y <= 0) y = 0;
            this.Location = new Point(x, y);

            List<Node> conns = FindConnectedNode();
            foreach (Node n in conns)
            {
                if (n.startID.Equals(this.guid))
                {
                    n.StartPoint = new Point(x + this.Width / 2+parent.scrolled_x, y + this.Height / 2+parent.scrolled_y);
                }
                else
                {
                    n.EndPoint = new Point(x + this.Width / 2+parent.scrolled_x, y + this.Height / 2+parent.scrolled_y);
                }
            }

            foreach (Rectangle rec in parent.reclist)
            {
                if (rec.panelID.Equals(this.guid))
                {
                    rec.Location = new Point(x-5+parent.scrolled_x, y-5+parent.scrolled_y);
                }
            }
        }

        private void PartsPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            _isDragging = false;
            
            if (e.Button == MouseButtons.Left)
            {
                return;
            }
        }

        private void Delete_Parts_Click(object sender, EventArgs e)
        {
            List<Node> conns = new List<Node>();
            foreach (Node nd in parent.nodelist)
            {
                if (nd.startID.Equals(this.guid) || nd.endID.Equals(this.guid))
                {
                    conns.Add(nd);
                }
            }
            foreach (Node nd in conns)
            {
                bool loop = true;
                int index = 0;
                while (loop)
                {
                    if (parent.nodelist[index].lineID.Equals(nd.lineID))
                    {
                        parent.nodelist[index].Dispose();
                        parent.nodelist.RemoveAt(index);
                        parent.listBox1.Items.RemoveAt(index);
                        loop = false;
                    }
                    index++;
                }
            }

         
            int cnt = 0;
            while (cnt < parent.reclist.Count)
            {
                if (this.guid == parent.reclist[cnt].panelID)
                {
                    parent.reclist[cnt].Dispose();
                    parent.reclist.RemoveAt(cnt);
                    parent.cnt_correct--;
                    parent.label8.Text = parent.cnt_correct.ToString() + "件ヒットしました";
                }
                cnt++;
            }

            parent.panel1.Controls.Remove(this);

        }

        public Component Panel2Component()
        {
            Component c = new Component();
            c.name = textBox1.Text;
            c.attribute = textBox2.Text;
            c.material = textBox3.Text;
            c.weight = textBox4.Text;
            c.backcolor = this.backcolor;
            c.guid = guid;
            c.x = this.Location.X;
            c.y = this.Location.Y;
            return c;
        }

        private List<Node> FindConnectedNode()
        {
            List<Node> conns = new List<Node>();
            foreach (Node nd in parent.nodelist)
            {
                if (nd.startID.Equals(this.guid) || nd.endID.Equals(this.guid))
                {
                    conns.Add(nd);
                }
            }
            return conns;
        }

        private void Con1toPart1_Click(object sender, EventArgs e)
        {
            Node node = new Node(0);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
            partsPanel.backcolor = 1;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con2toPart1_Click(object sender, EventArgs e)
        {
            Node node = new Node(1);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
            partsPanel.backcolor = 1;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con3toPart1_Click(object sender, EventArgs e)
        {
            Node node = new Node(2);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
            partsPanel.backcolor = 1;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con1toPart2_Click(object sender, EventArgs e)
        {
            Node node = new Node(0);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
            partsPanel.backcolor = 2;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con2toPart2_Click(object sender, EventArgs e)
        {
            Node node = new Node(1);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
            partsPanel.backcolor = 2;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con3toPart2_Click(object sender, EventArgs e)
        {
            Node node = new Node(2);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
            partsPanel.backcolor = 2;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con1toPart3_Click(object sender, EventArgs e)
        {
            Node node = new Node(0);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
            partsPanel.backcolor = 3;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con2toPart3_Click(object sender, EventArgs e)
        {
            Node node = new Node(1);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
            partsPanel.backcolor = 3;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void Con3toPart3_Click(object sender, EventArgs e)
        {
            Node node = new Node(2);
            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            node.startID = this.guid;
            PartsPanel partsPanel = new PartsPanel(parent);
            partsPanel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
            partsPanel.backcolor = 3;
            parent.panel1.Controls.Add(partsPanel);
            node.endID = partsPanel.guid;
            node.Parent = parent.canvas;
            node.StartPoint = new Point(this.Location.X + this.Width / 2 + parent.scrolled_x, this.Location.Y + this.Height / 2 + parent.scrolled_y);
            node.EndPoint = new Point(partsPanel.Location.X + this.Width / 2 + parent.scrolled_x, partsPanel.Location.Y + this.Height / 2 + parent.scrolled_y);
            partsPanel.BringToFront();
            this.BringToFront();
            parent.nodelist.Add(node);
            parent.listBox1.Items.Add(node.lineID);
        }

        private void PartColorBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
            this.backcolor = 1;
        }

        private void PartColorGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
            this.backcolor = 2;
        }

        private void PartColorRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
            this.backcolor = 3;
        }
    }
}
