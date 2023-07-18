namespace cs5
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.新規保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OverwriteSave = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenfileAsOngoing = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenfileAsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_New_Graph = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportAspptx = new System.Windows.Forms.ToolStripMenuItem();
            this.挿入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部品挿入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPart1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPart2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPart3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Node = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNode1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNode2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNode3 = new System.Windows.Forms.ToolStripMenuItem();
            this.選択削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_CheckedParts = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RealignmentParts = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nodelist_delete = new System.Windows.Forms.Button();
            this.nodelist_select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ResetSelectedNodes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 719);
            this.panel1.TabIndex = 0;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.挿入ToolStripMenuItem,
            this.選択削除ToolStripMenuItem,
            this.ツールToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFile,
            this.開くToolStripMenuItem,
            this.Create_New_Graph,
            this.ExportAspptx});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // SaveFile
            // 
            this.SaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規保存ToolStripMenuItem,
            this.OverwriteSave});
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(177, 22);
            this.SaveFile.Text = "新規保存";
            // 
            // 新規保存ToolStripMenuItem
            // 
            this.新規保存ToolStripMenuItem.Name = "新規保存ToolStripMenuItem";
            this.新規保存ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.新規保存ToolStripMenuItem.Text = "新規保存";
            this.新規保存ToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // OverwriteSave
            // 
            this.OverwriteSave.Name = "OverwriteSave";
            this.OverwriteSave.Size = new System.Drawing.Size(131, 22);
            this.OverwriteSave.Text = "上書き保存";
            this.OverwriteSave.Click += new System.EventHandler(this.OverwriteSave_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenfileAsOngoing,
            this.OpenfileAsNew});
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // OpenfileAsOngoing
            // 
            this.OpenfileAsOngoing.Name = "OpenfileAsOngoing";
            this.OpenfileAsOngoing.Size = new System.Drawing.Size(229, 22);
            this.OpenfileAsOngoing.Text = "現在のプロジェクトを破棄して開く";
            this.OpenfileAsOngoing.Click += new System.EventHandler(this.OpenFile);
            // 
            // OpenfileAsNew
            // 
            this.OpenfileAsNew.Name = "OpenfileAsNew";
            this.OpenfileAsNew.Size = new System.Drawing.Size(229, 22);
            this.OpenfileAsNew.Text = "新たなプロジェクトとして開く";
            this.OpenfileAsNew.Click += new System.EventHandler(this.OpenfileAsNewProject);
            // 
            // Create_New_Graph
            // 
            this.Create_New_Graph.Name = "Create_New_Graph";
            this.Create_New_Graph.Size = new System.Drawing.Size(177, 22);
            this.Create_New_Graph.Text = "新規グラフ作成";
            this.Create_New_Graph.Click += new System.EventHandler(this.Create_New_Graph_Click);
            // 
            // ExportAspptx
            // 
            this.ExportAspptx.Name = "ExportAspptx";
            this.ExportAspptx.Size = new System.Drawing.Size(177, 22);
            this.ExportAspptx.Text = "pptxとしてエクスポート";
            this.ExportAspptx.Click += new System.EventHandler(this.ExportAspptx_Click);
            // 
            // 挿入ToolStripMenuItem
            // 
            this.挿入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部品挿入ToolStripMenuItem,
            this.Add_Node});
            this.挿入ToolStripMenuItem.Name = "挿入ToolStripMenuItem";
            this.挿入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.挿入ToolStripMenuItem.Text = "挿入";
            // 
            // 部品挿入ToolStripMenuItem
            // 
            this.部品挿入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPart1,
            this.AddPart2,
            this.AddPart3});
            this.部品挿入ToolStripMenuItem.Name = "部品挿入ToolStripMenuItem";
            this.部品挿入ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.部品挿入ToolStripMenuItem.Text = "部品挿入";
            // 
            // AddPart1
            // 
            this.AddPart1.Name = "AddPart1";
            this.AddPart1.Size = new System.Drawing.Size(156, 22);
            this.AddPart1.Text = "部品1を挿入する";
            this.AddPart1.Click += new System.EventHandler(this.AddPart1_Click);
            // 
            // AddPart2
            // 
            this.AddPart2.Name = "AddPart2";
            this.AddPart2.Size = new System.Drawing.Size(156, 22);
            this.AddPart2.Text = "部品2を挿入する";
            this.AddPart2.Click += new System.EventHandler(this.AddPart2_Click);
            // 
            // AddPart3
            // 
            this.AddPart3.Name = "AddPart3";
            this.AddPart3.Size = new System.Drawing.Size(156, 22);
            this.AddPart3.Text = "部品3を挿入する";
            this.AddPart3.Click += new System.EventHandler(this.AddPart3_Click);
            // 
            // Add_Node
            // 
            this.Add_Node.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNode1,
            this.AddNode2,
            this.AddNode3});
            this.Add_Node.Name = "Add_Node";
            this.Add_Node.Size = new System.Drawing.Size(212, 22);
            this.Add_Node.Text = "チェックした部品間を接続する";
            // 
            // AddNode1
            // 
            this.AddNode1.Name = "AddNode1";
            this.AddNode1.Size = new System.Drawing.Size(128, 22);
            this.AddNode1.Text = "接続属性1";
            this.AddNode1.Click += new System.EventHandler(this.AddNode1_Click);
            // 
            // AddNode2
            // 
            this.AddNode2.Name = "AddNode2";
            this.AddNode2.Size = new System.Drawing.Size(128, 22);
            this.AddNode2.Text = "接続属性2";
            this.AddNode2.Click += new System.EventHandler(this.AddNode2_Click);
            // 
            // AddNode3
            // 
            this.AddNode3.Name = "AddNode3";
            this.AddNode3.Size = new System.Drawing.Size(128, 22);
            this.AddNode3.Text = "接続属性3";
            this.AddNode3.Click += new System.EventHandler(this.AddNode3_Click);
            // 
            // 選択削除ToolStripMenuItem
            // 
            this.選択削除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete_CheckedParts});
            this.選択削除ToolStripMenuItem.Name = "選択削除ToolStripMenuItem";
            this.選択削除ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.選択削除ToolStripMenuItem.Text = "選択削除";
            // 
            // Delete_CheckedParts
            // 
            this.Delete_CheckedParts.Name = "Delete_CheckedParts";
            this.Delete_CheckedParts.Size = new System.Drawing.Size(181, 22);
            this.Delete_CheckedParts.Text = "チェックした部品を削除";
            this.Delete_CheckedParts.Click += new System.EventHandler(this.Delete_CheckedParts_Click);
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RealignmentParts});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ツールToolStripMenuItem.Text = "ツール";
            // 
            // RealignmentParts
            // 
            this.RealignmentParts.Name = "RealignmentParts";
            this.RealignmentParts.Size = new System.Drawing.Size(168, 22);
            this.RealignmentParts.Text = "部品ごとに並び替え";
            this.RealignmentParts.Click += new System.EventHandler(this.RealignmentParts_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(1055, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(237, 340);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1132, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "接続の選択削除";
            // 
            // nodelist_delete
            // 
            this.nodelist_delete.Location = new System.Drawing.Point(1224, 392);
            this.nodelist_delete.Name = "nodelist_delete";
            this.nodelist_delete.Size = new System.Drawing.Size(56, 23);
            this.nodelist_delete.TabIndex = 3;
            this.nodelist_delete.Text = "削除";
            this.nodelist_delete.UseVisualStyleBackColor = true;
            this.nodelist_delete.Click += new System.EventHandler(this.nodelist_delete_Click);
            // 
            // nodelist_select
            // 
            this.nodelist_select.Location = new System.Drawing.Point(1061, 392);
            this.nodelist_select.Name = "nodelist_select";
            this.nodelist_select.Size = new System.Drawing.Size(52, 23);
            this.nodelist_select.TabIndex = 4;
            this.nodelist_select.Text = "選択";
            this.nodelist_select.UseVisualStyleBackColor = true;
            this.nodelist_select.Click += new System.EventHandler(this.nodelist_select_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1132, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "部分一致検索";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1072, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "部品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "属性";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1072, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "素材";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1072, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "重量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1119, 474);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1119, 507);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1119, 545);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 19);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1119, 578);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 19);
            this.textBox4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1227, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1227, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "検索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1227, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "検索";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1227, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "検索";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1074, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "検索結果：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1142, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "0件ヒットしました";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1134, 640);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "検索解除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ResetSelectedNodes
            // 
            this.ResetSelectedNodes.Location = new System.Drawing.Point(1134, 392);
            this.ResetSelectedNodes.Name = "ResetSelectedNodes";
            this.ResetSelectedNodes.Size = new System.Drawing.Size(75, 23);
            this.ResetSelectedNodes.TabIndex = 21;
            this.ResetSelectedNodes.Text = "選択解除";
            this.ResetSelectedNodes.UseVisualStyleBackColor = true;
            this.ResetSelectedNodes.Click += new System.EventHandler(this.ResetSelectedNodes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 759);
            this.Controls.Add(this.ResetSelectedNodes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nodelist_select);
            this.Controls.Add(this.nodelist_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Create_New_Graph;
        private System.Windows.Forms.ToolStripMenuItem 挿入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Node;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button nodelist_delete;
        private System.Windows.Forms.Button nodelist_select;
        private System.Windows.Forms.ToolStripMenuItem 部品挿入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPart1;
        private System.Windows.Forms.ToolStripMenuItem AddPart2;
        private System.Windows.Forms.ToolStripMenuItem AddPart3;
        private System.Windows.Forms.ToolStripMenuItem AddNode1;
        private System.Windows.Forms.ToolStripMenuItem AddNode2;
        private System.Windows.Forms.ToolStripMenuItem AddNode3;
        private System.Windows.Forms.ToolStripMenuItem 選択削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_CheckedParts;
        private System.Windows.Forms.ToolStripMenuItem OpenfileAsOngoing;
        private System.Windows.Forms.ToolStripMenuItem OpenfileAsNew;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RealignmentParts;
        private System.Windows.Forms.ToolStripMenuItem OverwriteSave;
        private System.Windows.Forms.ToolStripMenuItem 新規保存ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ResetSelectedNodes;
        private System.Windows.Forms.ToolStripMenuItem ExportAspptx;
    }
}

