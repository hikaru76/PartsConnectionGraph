using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.PowerPacks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO.Compression;
using Aspose.Slides;
using System.Xml.Linq;

namespace cs5
{
    public partial class Form1 : Form
    {

        public ShapeContainer canvas;
        public List<Node> nodelist = new List<Node>();
        public List<Rectangle> reclist = new List<Rectangle>();
        public int min_x = 0;
        public int min_y = 0;
        public int scrolled_x = 0;
        public int scrolled_y = 0;
        public int cnt_correct = 0;
        public string openedFileName = "";
        public Form1()
        {
            InitializeComponent();
            //this.Load += Form1_Load;
            panel1.AutoScroll = true;
            panel1.VerticalScroll.Visible = true;
            canvas = new ShapeContainer();
            canvas.Parent = panel1;
        }

        private void Form1_Load()
        {
            while (nodelist.Count > 0)
            {
                nodelist[0].Dispose();
                nodelist.RemoveAt(0);
            }
            while (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
            }
            foreach (PartsPanel p in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                panel1.Controls.Remove(p);
            }
        }

        private void Add_Parts_Click(object sender, EventArgs e)
        {
            PartsPanel partsPanel = new PartsPanel(this);
            panel1.Controls.Add(partsPanel);
        }

        private PartsPanel ID2PartsPanel(Guid id)
        {
            foreach (PartsPanel p in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                if (p.guid == id)
                {
                    return p;
                }
            }
            //絶対に来ない
            return null;
        }

        private void nodelist_select_Click(object sender, EventArgs e)
        {
            foreach (Node n in nodelist)
            {
                n.BorderColor = Color.Black;
            }
            foreach (object o in listBox1.SelectedItems)
            {
                foreach (Node n in nodelist)
                {
                    if (n.lineID.ToString() == o.ToString())
                    {
                        n.BorderColor = Color.Red;
                    }
                }
            }
        }

        private void nodelist_delete_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                int index = -1;
                while (true)
                {
                    index++;
                    if (nodelist[index].lineID.ToString() == listBox1.Items[listBox1.SelectedIndices[0]].ToString())
                    {
                        nodelist[index].Dispose();
                        nodelist.RemoveAt(index);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
                        break;
                    }
                }
            }
        }

        private void AddPart1_Click(object sender, EventArgs e)
        {
            PartsPanel partsPanel = new PartsPanel(this);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
            partsPanel.backcolor = 1;
            partsPanel.BringToFront();
            panel1.Controls.Add(partsPanel);
        }

        private void AddPart2_Click(object sender, EventArgs e)
        {
            PartsPanel partsPanel = new PartsPanel(this);
            partsPanel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
            partsPanel.backcolor = 2;
            partsPanel.BringToFront();
            panel1.Controls.Add(partsPanel);
        }

        private void AddPart3_Click(object sender, EventArgs e)
        {
            PartsPanel partsPanel = new PartsPanel(this);
            partsPanel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
            partsPanel.backcolor = 3;
            partsPanel.BringToFront();
            panel1.Controls.Add(partsPanel);
        }

        private void AddNode1_Click(object sender, EventArgs e)
        {
            List<Guid> checkedID = new List<Guid>();
            foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                if (panel.checkBox1.Checked)
                {
                    checkedID.Add(panel.guid);
                }
            }
            //Debug.WriteLine(checkedID.Count.ToString());
            for (int i = 0; i < checkedID.Count; i++)
            {
                for (int j = i + 1; j < checkedID.Count; j++)
                {
                    bool linked = false;
                    foreach (Node n in nodelist)
                    {
                        if ((n.startID == checkedID[i] && n.endID == checkedID[j]) || (n.endID == checkedID[i] && n.startID == checkedID[j]))
                        {
                            linked = true;
                        }
                    }
                    if (!linked)
                    {
                        Node node = new Node(0);
                        node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        node.startID = checkedID[i];
                        node.endID = checkedID[j];
                        node.Parent = canvas;
                        PartsPanel startpanel = ID2PartsPanel(checkedID[i]);
                        PartsPanel endpanel = ID2PartsPanel(checkedID[j]);
                        node.StartPoint = new Point(startpanel.Location.X + startpanel.Width / 2 + scrolled_x, startpanel.Location.Y + startpanel.Height / 2 + scrolled_y);
                        node.EndPoint = new Point(endpanel.Location.X + endpanel.Width / 2 + scrolled_x, endpanel.Location.Y + endpanel.Height / 2 + scrolled_y);
                        startpanel.BringToFront();
                        endpanel.BringToFront();
                        nodelist.Add(node);
                        listBox1.Items.Add(node.lineID);
                    }
                }
            }
        }

        private void AddNode2_Click(object sender, EventArgs e)
        {
            List<Guid> checkedID = new List<Guid>();
            foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                if (panel.checkBox1.Checked)
                {
                    checkedID.Add(panel.guid);
                }
            }
            //Debug.WriteLine(checkedID.Count.ToString());
            for (int i = 0; i < checkedID.Count; i++)
            {
                for (int j = i + 1; j < checkedID.Count; j++)
                {
                    bool linked = false;
                    foreach (Node n in nodelist)
                    {
                        if ((n.startID == checkedID[i] && n.endID == checkedID[j]) || (n.endID == checkedID[i] && n.startID == checkedID[j]))
                        {
                            linked = true;
                        }
                    }
                    if (!linked)
                    {
                        Node node = new Node(1);
                        node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        node.startID = checkedID[i];
                        node.endID = checkedID[j];
                        node.Parent = canvas;
                        PartsPanel startpanel = ID2PartsPanel(checkedID[i]);
                        PartsPanel endpanel = ID2PartsPanel(checkedID[j]);
                        node.StartPoint = new Point(startpanel.Location.X + startpanel.Width / 2 + scrolled_x, startpanel.Location.Y + startpanel.Height / 2 + scrolled_y);
                        node.EndPoint = new Point(endpanel.Location.X + endpanel.Width / 2 + scrolled_x, endpanel.Location.Y + endpanel.Height / 2 + scrolled_y);
                        startpanel.BringToFront();
                        endpanel.BringToFront();
                        nodelist.Add(node);
                        listBox1.Items.Add(node.lineID);
                    }
                }
            }
        }

        private void AddNode3_Click(object sender, EventArgs e)
        {
            List<Guid> checkedID = new List<Guid>();
            foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                if (panel.checkBox1.Checked)
                {
                    checkedID.Add(panel.guid);
                }
            }
            //Debug.WriteLine(checkedID.Count.ToString());
            for (int i = 0; i < checkedID.Count; i++)
            {
                for (int j = i + 1; j < checkedID.Count; j++)
                {
                    bool linked = false;
                    foreach (Node n in nodelist)
                    {
                        if ((n.startID == checkedID[i] && n.endID == checkedID[j]) || (n.endID == checkedID[i] && n.startID == checkedID[j]))
                        {
                            linked = true;
                        }
                    }
                    if (!linked)
                    {
                        Node node = new Node(2);
                        node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                        node.startID = checkedID[i];
                        node.endID = checkedID[j];
                        node.Parent = canvas;
                        PartsPanel startpanel = ID2PartsPanel(checkedID[i]);
                        PartsPanel endpanel = ID2PartsPanel(checkedID[j]);
                        node.StartPoint = new Point(startpanel.Location.X + startpanel.Width / 2 + scrolled_x, startpanel.Location.Y + startpanel.Height / 2 + scrolled_y);
                        node.EndPoint = new Point(endpanel.Location.X + endpanel.Width / 2 + scrolled_x, endpanel.Location.Y + endpanel.Height / 2 + scrolled_y);
                        startpanel.BringToFront();
                        endpanel.BringToFront();
                        nodelist.Add(node);
                        listBox1.Items.Add(node.lineID);
                    }
                }
            }
        }

        private SaveNode GetSaveNodes(Node n)
        {
            SaveNode sn = new SaveNode();
            sn.guid1 = n.startID;
            sn.guid2 = n.endID;
            sn.guid3 = n.lineID;
            sn.attribute = n.attribute;
            return sn;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            List<Component> compo_list = new List<Component>();
            List<SaveNode> savenode_list = new List<SaveNode>();
            Elements elements = new Elements();
            foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                compo_list.Add(panel.Panel2Component());
            }
            foreach (Node n in nodelist)
            {
                savenode_list.Add(GetSaveNodes(n));
            }
            elements.Elements_Compo = compo_list;
            elements.Elements_Node = savenode_list;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XMLファイル|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                openedFileName = saveFileDialog.FileName;
                XmlSerializer xs = new XmlSerializer(typeof(Elements));
                StreamWriter sw = new StreamWriter(filename, false, new System.Text.UTF8Encoding(false));
                xs.Serialize(sw, elements);
                sw.Close();
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XMLファイル|*.xml";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                openedFileName = openFileDialog.FileName;
                XmlSerializer xs = new XmlSerializer (typeof(Elements));
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                Elements elements = new Elements();
                elements = (Elements)xs.Deserialize(fs);
                fs.Close();

                //int min_x = 0;
                //int min_y = 0;
                found_panel_Reset();
                scrolled_x = 0;
                scrolled_y = 0;
                Form1_Load();
                foreach (Component c in elements.Elements_Compo)
                {
                    PartsPanel partsPanel = new PartsPanel(this);
                    partsPanel.BringToFront();
                    partsPanel.Location = new Point(c.x, c.y);
                    min_x = System.Math.Min(min_x, c.x);
                    min_y = System.Math.Min (min_y, c.y);
                    partsPanel.textBox1.Text = c.name;
                    partsPanel.textBox2.Text = c.attribute;
                    partsPanel.textBox3.Text = c.material;
                    partsPanel.textBox4.Text = c.weight;
                    partsPanel.guid = c.guid;
                    switch (c.backcolor)
                    {
                        case 1:
                            partsPanel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
                            partsPanel.backcolor = 1;
                            break;
                        case 2:
                            partsPanel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
                            partsPanel.backcolor = 2;
                            break;
                        case 3:
                            partsPanel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
                            partsPanel.backcolor = 3;
                            break;
                    }
                    panel1.Controls.Add(partsPanel);
                }

                if (min_x < 0)
                {
                    foreach (PartsPanel p in panel1.Controls.OfType<PartsPanel>().ToList())
                    {
                        p.Location = new Point (p.Location.X-min_x, p.Location.Y);
                    }
                }

                if (min_y < 0)
                {
                    foreach (PartsPanel p in panel1.Controls.OfType<PartsPanel>().ToList())
                    {
                        p.Location = new Point(p.Location.X, p.Location.Y-min_y);
                    }
                }

                foreach (SaveNode sn in elements.Elements_Node)
                {
                    Node node = new Node(0);
                    switch (sn.attribute)
                    {
                        case 0:
                            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            break;
                        case 1:
                            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                            break;
                        case 2:
                            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                            break;
                    }
                    node.attribute = sn.attribute;
                    node.startID = sn.guid1;
                    node.endID = sn.guid2;
                    node.Parent = canvas;
                    PartsPanel startpanel = ID2PartsPanel(sn.guid1);
                    PartsPanel endpanel = ID2PartsPanel(sn.guid2);
                    node.StartPoint = new Point(startpanel.Location.X + startpanel.Width / 2, startpanel.Location.Y + startpanel.Height / 2);
                    node.EndPoint = new Point(endpanel.Location.X + endpanel.Width / 2, endpanel.Location.Y + endpanel.Height / 2);
                    startpanel.BringToFront();
                    endpanel.BringToFront();
                    nodelist.Add(node);
                    listBox1.Items.Add(node.lineID);

                    cnt_correct = 0;
                    label8.Text = cnt_correct.ToString() + "件ヒットしました";
                }
            }
        }

        private void Delete_CheckedParts_Click(object sender, EventArgs e)
        {
            List<Guid> checkedID = new List<Guid>();
            foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                if (panel.checkBox1.Checked)
                {
                    checkedID.Add(panel.guid);
                }
            }

            while (checkedID.Count > 0)
            {
                foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
                {
                    if (checkedID[0].Equals(panel.guid)) 
                    {
                        List<Node> conns = new List<Node>();
                        foreach (Node nd in nodelist)
                        {
                            if (nd.startID.Equals(panel.guid) || nd.endID.Equals(panel.guid))
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
                                if (nodelist[index].lineID.Equals(nd.lineID))
                                {
                                    nodelist[index].Dispose();
                                    nodelist.RemoveAt(index);
                                    listBox1.Items.RemoveAt(index);
                                    loop = false;
                                }
                                index++;
                            }
                        }
                        int cntRec = 0;
                        while (cntRec < reclist.Count)
                        {
                            if (reclist[cntRec].panelID.Equals(panel.guid))
                            {
                                reclist[cntRec].Dispose();
                                reclist.RemoveAt(cntRec);
                                cnt_correct--;
                                label8.Text = cnt_correct.ToString() + "件ヒットしました";
                                break;
                            }
                            cntRec++;
                        }
                        panel1.Controls.Remove(panel);
                    }
                }
                checkedID.RemoveAt(0);
            }
        }

        private void Create_New_Graph_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void OpenfileAsNewProject(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XMLファイル|*.xml";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                XmlSerializer xs = new XmlSerializer(typeof(Elements));
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                Elements elements = new Elements();
                elements = (Elements)xs.Deserialize(fs);
                fs.Close();

                //int min_x = 0;
                //int min_y = 0;
                Form1 form = new Form1();
                form.openedFileName = openFileDialog.FileName;
                form.Show();
                foreach (Component c in elements.Elements_Compo)
                {
                    PartsPanel partsPanel = new PartsPanel(form);
                    partsPanel.BringToFront();
                    partsPanel.Location = new Point(c.x, c.y);
                    min_x = System.Math.Min(min_x, c.x);
                    min_y = System.Math.Min(min_y, c.y);
                    partsPanel.textBox1.Text = c.name;
                    partsPanel.textBox2.Text = c.attribute;
                    partsPanel.textBox3.Text = c.material;
                    partsPanel.textBox4.Text = c.weight;
                    partsPanel.guid = c.guid;
                    switch (c.backcolor)
                    {
                        case 1:
                            partsPanel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
                            partsPanel.backcolor = 1;
                            break;
                        case 2:
                            partsPanel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
                            partsPanel.backcolor = 2;
                            break;
                        case 3:
                            partsPanel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
                            partsPanel.backcolor = 3;
                            break;
                    }
                    form.panel1.Controls.Add(partsPanel);
                }

                if (min_x < 0)
                {
                    foreach (PartsPanel p in form.panel1.Controls.OfType<PartsPanel>().ToList())
                    {
                        p.Location = new Point(p.Location.X - min_x, p.Location.Y);
                    }
                }

                if (min_y < 0)
                {
                    foreach (PartsPanel p in form.panel1.Controls.OfType<PartsPanel>().ToList())
                    {
                        p.Location = new Point(p.Location.X, p.Location.Y - min_y);
                    }
                }

                foreach (SaveNode sn in elements.Elements_Node)
                {
                    
                    Node node = new Node(0);
                    switch (sn.attribute)
                    {
                        case 0:
                            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            break;
                        case 1:
                            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                            break;
                        case 2:
                            node.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                            break;
                    }
                    node.attribute = sn.attribute;
                    node.startID = sn.guid1;
                    node.endID = sn.guid2;
                    node.Parent = form.canvas;
                    PartsPanel startpanel = form.ID2PartsPanel(sn.guid1);
                    PartsPanel endpanel = form.ID2PartsPanel(sn.guid2);
                    node.StartPoint = new Point(startpanel.Location.X + startpanel.Width / 2, startpanel.Location.Y + startpanel.Height / 2);
                    node.EndPoint = new Point(endpanel.Location.X + endpanel.Width / 2, endpanel.Location.Y + endpanel.Height / 2);
                    startpanel.BringToFront();
                    endpanel.BringToFront();
                    form.nodelist.Add(node);
                    form.listBox1.Items.Add(node.lineID);
                }
            }
        }

        private void RealignmentParts_Click(object sender, EventArgs e)
        {
            int cnt_part1 = 0;
            int cnt_part2 = 0;
            int cnt_part3 = 0;

            panel1.AutoScrollPosition = new Point(0, 0);
            scrolled_x = 0;
            scrolled_y = 0;

            foreach (PartsPanel p in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                switch (p.backcolor)
                {
                    case 1:
                        p.Location = new Point(10, 10 + cnt_part1 * (p.Height + 20));
                        cnt_part1++;
                        break;
                    case 2:
                        p.Location = new Point(10 + p.Width+20, 10 + cnt_part2 * (p.Height + 20));
                        cnt_part2++;
                        break;
                    case 3:
                        p.Location = new Point(10 + p.Width*2 + 40, 10 + cnt_part3 * (p.Height + 20));
                        cnt_part3++;
                        break;
                }
            }

            PartsPanel pa = new PartsPanel(this);
            foreach (Node n in nodelist)
            {
                n.StartPoint = new Point(ID2PartsPanel(n.startID).Location.X+pa.Width/2, ID2PartsPanel(n.startID).Location.Y+pa.Height/2);
                n.EndPoint = new Point(ID2PartsPanel(n.endID).Location.X+pa.Width/2, ID2PartsPanel(n.endID).Location.Y+pa.Height/2);
            }
            foreach (Rectangle rec in reclist)
            {
                rec.Location = new Point(ID2PartsPanel(rec.panelID).Location.X - 5, ID2PartsPanel(rec.panelID).Location.Y - 5);
            }
        }

        private void OverwriteSave_Click(object sender, EventArgs e)
        {
            if (openedFileName != "")
            {
                List<Component> compo_list = new List<Component>();
                List<SaveNode> savenode_list = new List<SaveNode>();
                Elements elements = new Elements();
                foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
                {
                    compo_list.Add(panel.Panel2Component());
                }
                foreach (Node n in nodelist)
                {
                    savenode_list.Add(GetSaveNodes(n));
                }
                elements.Elements_Compo = compo_list;
                elements.Elements_Node = savenode_list;
                string filename = openedFileName;
                XmlSerializer xs = new XmlSerializer(typeof(Elements));
                StreamWriter sw = new StreamWriter(filename, false, new System.Text.UTF8Encoding(false));
                xs.Serialize(sw, elements);
                sw.Close();
            }
            else
            {
                OpenFile(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            found_panel_Reset();
            label8.Text = "0件ヒットしました";
        }

        private void panel_color_Reset()
        {
            foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
            {
                panel.BorderStyle = BorderStyle.None;
                switch (panel.backcolor)
                {
                    case 1:
                        panel.BackColor = Color.FromArgb(0xA0, 0xA0, 0xC0);
                        break;
                    case 2:
                        panel.BackColor = Color.FromArgb(0xA0, 0xC0, 0xA0);
                        break;
                    case 3:
                        panel.BackColor = Color.FromArgb(0xC0, 0xA0, 0xA0);
                        break;
                }
            }
        }

        private void found_panel_Reset()
        {
            cnt_correct = 0;
            while (reclist.Count > 0)
            {
                reclist[0].Dispose();
                reclist.RemoveAt(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int cnt_correct = 0;
            found_panel_Reset();
            if (textBox1 != null)
            {
                foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
                {
                    if (panel.textBox1.Text == textBox1.Text)
                    {
                        cnt_correct++;
                        Rectangle rs = new Rectangle();
                        rs.BackStyle = BackStyle.Opaque;
                        rs.BackColor = Color.Red;
                        rs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        rs.BorderColor = Color.Red;
                        Debug.WriteLine(scrolled_y.ToString());
                        rs.Location = new Point(panel.Location.X-5+scrolled_x, panel.Location.Y-5+scrolled_y);
                        rs.Width = panel.Width+10;
                        rs.Height = panel.Height+10;
                        rs.Parent = canvas;
                        rs.panelID = panel.guid;
                        reclist.Add(rs);
                        panel.BringToFront();
                    }
                }
                label8.Text = cnt_correct.ToString() + "件ヒットしました";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int cnt_correct = 0;
            found_panel_Reset();
            if (textBox1 != null)
            {
                foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
                {
                    if (panel.textBox2.Text == textBox2.Text)
                    {
                        cnt_correct++;
                        Rectangle rs = new Rectangle();
                        rs.BackStyle = BackStyle.Opaque;
                        rs.BackColor = Color.Red;
                        rs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        rs.BorderColor = Color.Red;
                        Debug.WriteLine(min_y.ToString());
                        rs.Location = new Point(panel.Location.X - 5 + scrolled_x, panel.Location.Y - 5 + scrolled_y);
                        rs.Width = panel.Width + 10;
                        rs.Height = panel.Height + 10;
                        rs.Parent = canvas;
                        rs.panelID = panel.guid;
                        reclist.Add(rs);
                        panel.BringToFront();
                    }
                }
                label8.Text = cnt_correct.ToString() + "件ヒットしました";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int cnt_correct = 0;
            found_panel_Reset();
            if (textBox1 != null)
            {
                foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
                {
                    if (panel.textBox3.Text == textBox3.Text)
                    {
                        cnt_correct++;
                        Rectangle rs = new Rectangle();
                        rs.BackStyle = BackStyle.Opaque;
                        rs.BackColor = Color.Red;
                        rs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        rs.BorderColor = Color.Red;
                        Debug.WriteLine(min_y.ToString());
                        rs.Location = new Point(panel.Location.X - 5 + scrolled_x, panel.Location.Y - 5 + scrolled_y);
                        rs.Width = panel.Width + 10;
                        rs.Height = panel.Height + 10;
                        rs.Parent = canvas;
                        rs.panelID = panel.guid;
                        reclist.Add(rs);
                        panel.BringToFront();
                    }
                }
                label8.Text = cnt_correct.ToString() + "件ヒットしました";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int cnt_correct = 0;
            found_panel_Reset();
            if (textBox1 != null)
            {
                foreach (PartsPanel panel in panel1.Controls.OfType<PartsPanel>().ToList())
                {
                    if (panel.textBox4.Text == textBox4.Text)
                    {
                        cnt_correct++;
                        Rectangle rs = new Rectangle();
                        rs.BackStyle = BackStyle.Opaque;
                        rs.BackColor = Color.Red;
                        rs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        rs.BorderColor = Color.Red;
                        Debug.WriteLine(min_y.ToString());
                        rs.Location = new Point(panel.Location.X - 5 + scrolled_x, panel.Location.Y - 5 + scrolled_y);
                        rs.Width = panel.Width + 10;
                        rs.Height = panel.Height + 10;
                        rs.Parent = canvas;
                        rs.panelID = panel.guid;
                        reclist.Add(rs);
                        panel.BringToFront();
                    }
                }
                label8.Text = cnt_correct.ToString() + "件ヒットしました";
            }
        }

        private void ResetSelectedNodes_Click(object sender, EventArgs e)
        {
            foreach (Node node in nodelist)
            {
                node.BorderColor = Color.Black;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Shift | Keys.S)) 
            {
                SaveFile_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.S))
            {
                OverwriteSave_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.O))
            {
                OpenFile(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.Shift | Keys.O))
            {
                OpenfileAsNewProject(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.T))
            {
                Create_New_Graph_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.Q))
            {
                AddPart1_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.W))
            {
                AddPart2_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.E))
            {
                AddPart3_Click(sender, e);
            }
        }

        private void ExportAspptx_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "パワーポイントファイル|*.pptx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Presentation pres = new Presentation())
                {

                    IShapeCollection shapes = pres.Slides[0].Shapes;
                    List<IAutoShape> pptxshapelist = new List<IAutoShape>();
                    List<Guid> guidlist = new List<Guid>();

                    foreach (PartsPanel p in panel1.Controls.OfType<PartsPanel>().ToList())
                    {
                        IAutoShape rec = shapes.AddAutoShape(ShapeType.Rectangle, p.Location.X+scrolled_x, p.Location.Y+scrolled_y, 150, 120);
                        rec.AddTextFrame("部品名：" + p.textBox1.Text + "\n属性：" + p.textBox2.Text + "\n素材：" + p.textBox3.Text + "\n重量：" + p.textBox4.Text);
                        rec.LineFormat.FillFormat.FillType = FillType.NoFill;
                        switch (p.backcolor)
                        {
                            case 1:
                                rec.FillFormat.FillType = FillType.Solid;
                                rec.FillFormat.SolidFillColor.Color = Color.FromArgb(0xA0, 0xA0, 0xC0);
                                break;
                            case 2:
                                rec.FillFormat.FillType = FillType.Solid;
                                rec.FillFormat.SolidFillColor.Color = Color.FromArgb(0xA0, 0xC0, 0xA0);
                                break;
                            case 3:
                                rec.FillFormat.FillType = FillType.Solid;
                                rec.FillFormat.SolidFillColor.Color = Color.FromArgb(0xC0, 0xA0, 0xA0);
                                break;
                        }
                        guidlist.Add(p.guid);
                        pptxshapelist.Add(rec);
                    }

                    foreach (Node n in nodelist)
                    {
                        IConnector connector = shapes.AddConnector(ShapeType.BentConnector2, 0, 0, 10, 10);
                        connector.LineFormat.Width = 3;
                        connector.LineFormat.FillFormat.FillType = FillType.Solid;
                        connector.LineFormat.FillFormat.SolidFillColor.Color = Color.Black;
                        switch (n.attribute)
                        {
                            case 0:
                                connector.LineFormat.DashStyle = LineDashStyle.Solid;
                                break;
                            case 1:
                                connector.LineFormat.DashStyle = LineDashStyle.Dash;
                                break;
                            case 2:
                                connector.LineFormat.DashStyle = LineDashStyle.Dot;
                                break;
                        }
                        int index = 0;
                        foreach (Guid id in guidlist)
                        {
                            if (id == n.startID)
                            {
                                connector.StartShapeConnectedTo = pptxshapelist[index];
                            }
                            else if (id == n.endID)
                            {
                                connector.EndShapeConnectedTo = pptxshapelist[index];
                            }
                            index++;
                        }
                        connector.Reroute();
                    }

                    pres.Save(saveFileDialog.FileName, Aspose.Slides.Export.SaveFormat.Pptx);
                }
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                scrolled_x = scrolled_x + e.NewValue - e.OldValue;
            }
            else if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                scrolled_y = scrolled_y + e.NewValue - e.OldValue;
            }
        }
    }
}
