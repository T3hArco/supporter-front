namespace sf_cs
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.checkMyUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketList = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(519, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkMyUIDToolStripMenuItem,
            this.getListToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(149, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // checkMyUIDToolStripMenuItem
            // 
            this.checkMyUIDToolStripMenuItem.Name = "checkMyUIDToolStripMenuItem";
            this.checkMyUIDToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.checkMyUIDToolStripMenuItem.Text = "Check my UID";
            this.checkMyUIDToolStripMenuItem.Click += new System.EventHandler(this.checkMyUIDToolStripMenuItem_Click);
            // 
            // getListToolStripMenuItem
            // 
            this.getListToolStripMenuItem.Name = "getListToolStripMenuItem";
            this.getListToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.getListToolStripMenuItem.Text = "Get List";
            this.getListToolStripMenuItem.Click += new System.EventHandler(this.getListToolStripMenuItem_Click);
            // 
            // ticketList
            // 
            this.ticketList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketList.FormattingEnabled = true;
            this.ticketList.Items.AddRange(new object[] {
            "Loading entries"});
            this.ticketList.Location = new System.Drawing.Point(12, 28);
            this.ticketList.Name = "ticketList";
            this.ticketList.Size = new System.Drawing.Size(495, 277);
            this.ticketList.TabIndex = 3;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 336);
            this.Controls.Add(this.ticketList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem checkMyUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getListToolStripMenuItem;
        private System.Windows.Forms.ListBox ticketList;
    }
}