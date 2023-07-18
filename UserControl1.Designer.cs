namespace cs5
{
    partial class PartsPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_name = new System.Windows.Forms.Label();
            this.label_attribute = new System.Windows.Forms.Label();
            this.label_material = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色の変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PartColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.PartColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.PartColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.Con1toPart1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con2toPart1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con3toPart1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新たな部品2を接続するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Con1toPart2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con2toPart2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con3toPart2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con1toPart3 = new System.Windows.Forms.ToolStripMenuItem();
            this.接続属性1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con2toPart3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Con3toPart3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(15, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "部品名";
            // 
            // label_attribute
            // 
            this.label_attribute.AutoSize = true;
            this.label_attribute.Location = new System.Drawing.Point(15, 42);
            this.label_attribute.Name = "label_attribute";
            this.label_attribute.Size = new System.Drawing.Size(29, 12);
            this.label_attribute.TabIndex = 1;
            this.label_attribute.Text = "属性";
            // 
            // label_material
            // 
            this.label_material.AutoSize = true;
            this.label_material.Location = new System.Drawing.Point(15, 68);
            this.label_material.Name = "label_material";
            this.label_material.Size = new System.Drawing.Size(29, 12);
            this.label_material.TabIndex = 2;
            this.label_material.Text = "素材";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(15, 92);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(29, 12);
            this.label_weight.TabIndex = 3;
            this.label_weight.Text = "重量";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.削除ToolStripMenuItem,
            this.色の変更ToolStripMenuItem,
            this.AddNewNodes,
            this.新たな部品2を接続するToolStripMenuItem,
            this.Con1toPart3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 120);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.Delete_Parts_Click);
            // 
            // 色の変更ToolStripMenuItem
            // 
            this.色の変更ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PartColorBlue,
            this.PartColorGreen,
            this.PartColorRed});
            this.色の変更ToolStripMenuItem.Name = "色の変更ToolStripMenuItem";
            this.色の変更ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.色の変更ToolStripMenuItem.Text = "色の変更";
            // 
            // PartColorBlue
            // 
            this.PartColorBlue.Name = "PartColorBlue";
            this.PartColorBlue.Size = new System.Drawing.Size(86, 22);
            this.PartColorBlue.Text = "青";
            this.PartColorBlue.Click += new System.EventHandler(this.PartColorBlue_Click);
            // 
            // PartColorGreen
            // 
            this.PartColorGreen.Name = "PartColorGreen";
            this.PartColorGreen.Size = new System.Drawing.Size(86, 22);
            this.PartColorGreen.Text = "緑";
            this.PartColorGreen.Click += new System.EventHandler(this.PartColorGreen_Click);
            // 
            // PartColorRed
            // 
            this.PartColorRed.Name = "PartColorRed";
            this.PartColorRed.Size = new System.Drawing.Size(86, 22);
            this.PartColorRed.Text = "赤";
            this.PartColorRed.Click += new System.EventHandler(this.PartColorRed_Click);
            // 
            // AddNewNodes
            // 
            this.AddNewNodes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Con1toPart1,
            this.Con2toPart1,
            this.Con3toPart1});
            this.AddNewNodes.Name = "AddNewNodes";
            this.AddNewNodes.Size = new System.Drawing.Size(187, 22);
            this.AddNewNodes.Text = "新たな部品1を接続する";
            // 
            // Con1toPart1
            // 
            this.Con1toPart1.Name = "Con1toPart1";
            this.Con1toPart1.Size = new System.Drawing.Size(128, 22);
            this.Con1toPart1.Text = "接続属性1";
            this.Con1toPart1.Click += new System.EventHandler(this.Con1toPart1_Click);
            // 
            // Con2toPart1
            // 
            this.Con2toPart1.Name = "Con2toPart1";
            this.Con2toPart1.Size = new System.Drawing.Size(128, 22);
            this.Con2toPart1.Text = "接続属性2";
            this.Con2toPart1.Click += new System.EventHandler(this.Con2toPart1_Click);
            // 
            // Con3toPart1
            // 
            this.Con3toPart1.Name = "Con3toPart1";
            this.Con3toPart1.Size = new System.Drawing.Size(128, 22);
            this.Con3toPart1.Text = "接続属性3";
            this.Con3toPart1.Click += new System.EventHandler(this.Con3toPart1_Click);
            // 
            // 新たな部品2を接続するToolStripMenuItem
            // 
            this.新たな部品2を接続するToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Con1toPart2,
            this.Con2toPart2,
            this.Con3toPart2});
            this.新たな部品2を接続するToolStripMenuItem.Name = "新たな部品2を接続するToolStripMenuItem";
            this.新たな部品2を接続するToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.新たな部品2を接続するToolStripMenuItem.Text = "新たな部品2を接続する";
            // 
            // Con1toPart2
            // 
            this.Con1toPart2.Name = "Con1toPart2";
            this.Con1toPart2.Size = new System.Drawing.Size(180, 22);
            this.Con1toPart2.Text = "接続属性1";
            this.Con1toPart2.Click += new System.EventHandler(this.Con1toPart2_Click);
            // 
            // Con2toPart2
            // 
            this.Con2toPart2.Name = "Con2toPart2";
            this.Con2toPart2.Size = new System.Drawing.Size(180, 22);
            this.Con2toPart2.Text = "接続属性2";
            this.Con2toPart2.Click += new System.EventHandler(this.Con2toPart2_Click);
            // 
            // Con3toPart2
            // 
            this.Con3toPart2.Name = "Con3toPart2";
            this.Con3toPart2.Size = new System.Drawing.Size(180, 22);
            this.Con3toPart2.Text = "接続属性3";
            this.Con3toPart2.Click += new System.EventHandler(this.Con3toPart2_Click);
            // 
            // Con1toPart3
            // 
            this.Con1toPart3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接続属性1ToolStripMenuItem1,
            this.Con2toPart3,
            this.Con3toPart3});
            this.Con1toPart3.Name = "Con1toPart3";
            this.Con1toPart3.Size = new System.Drawing.Size(187, 22);
            this.Con1toPart3.Text = "新たな部品3を接続する";
            // 
            // 接続属性1ToolStripMenuItem1
            // 
            this.接続属性1ToolStripMenuItem1.Name = "接続属性1ToolStripMenuItem1";
            this.接続属性1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.接続属性1ToolStripMenuItem1.Text = "接続属性1";
            this.接続属性1ToolStripMenuItem1.Click += new System.EventHandler(this.Con1toPart3_Click);
            // 
            // Con2toPart3
            // 
            this.Con2toPart3.Name = "Con2toPart3";
            this.Con2toPart3.Size = new System.Drawing.Size(180, 22);
            this.Con2toPart3.Text = "接続属性2";
            this.Con2toPart3.Click += new System.EventHandler(this.Con2toPart3_Click);
            // 
            // Con3toPart3
            // 
            this.Con3toPart3.Name = "Con3toPart3";
            this.Con3toPart3.Size = new System.Drawing.Size(180, 22);
            this.Con3toPart3.Text = "接続属性3";
            this.Con3toPart3.Click += new System.EventHandler(this.Con3toPart3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 19);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 19);
            this.textBox4.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(50, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "接続選択";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PartsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label_material);
            this.Controls.Add(this.label_attribute);
            this.Controls.Add(this.label_name);
            this.Name = "PartsPanel";
            this.Size = new System.Drawing.Size(180, 139);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsPanel_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_attribute;
        private System.Windows.Forms.Label label_material;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色の変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PartColorGreen;
        private System.Windows.Forms.ToolStripMenuItem PartColorRed;
        private System.Windows.Forms.ToolStripMenuItem PartColorBlue;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem AddNewNodes;
        private System.Windows.Forms.ToolStripMenuItem Con1toPart1;
        private System.Windows.Forms.ToolStripMenuItem Con2toPart1;
        private System.Windows.Forms.ToolStripMenuItem Con3toPart1;
        private System.Windows.Forms.ToolStripMenuItem 新たな部品2を接続するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Con1toPart2;
        private System.Windows.Forms.ToolStripMenuItem Con2toPart2;
        private System.Windows.Forms.ToolStripMenuItem Con3toPart2;
        private System.Windows.Forms.ToolStripMenuItem Con1toPart3;
        private System.Windows.Forms.ToolStripMenuItem 接続属性1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Con2toPart3;
        private System.Windows.Forms.ToolStripMenuItem Con3toPart3;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}
