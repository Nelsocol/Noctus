
namespace NoctusEditor
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.passageTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.luaTextBox = new System.Windows.Forms.TextBox();
            this.linksTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 490);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(240, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(989, 490);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.passageTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(621, 490);
            this.splitContainer2.SplitterDistance = 52;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.nameTextBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.headerTextBox);
            this.splitContainer4.Size = new System.Drawing.Size(621, 52);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Black;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(621, 25);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.WordWrap = false;
            // 
            // headerTextBox
            // 
            this.headerTextBox.BackColor = System.Drawing.Color.Black;
            this.headerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTextBox.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerTextBox.Location = new System.Drawing.Point(0, 0);
            this.headerTextBox.Multiline = true;
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(621, 71);
            this.headerTextBox.TabIndex = 0;
            this.headerTextBox.WordWrap = false;
            // 
            // passageTextBox
            // 
            this.passageTextBox.AcceptsReturn = true;
            this.passageTextBox.AcceptsTab = true;
            this.passageTextBox.BackColor = System.Drawing.Color.Black;
            this.passageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passageTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passageTextBox.Location = new System.Drawing.Point(0, 0);
            this.passageTextBox.Multiline = true;
            this.passageTextBox.Name = "passageTextBox";
            this.passageTextBox.Size = new System.Drawing.Size(621, 434);
            this.passageTextBox.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.luaTextBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.linksTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(364, 490);
            this.splitContainer3.SplitterDistance = 293;
            this.splitContainer3.TabIndex = 0;
            // 
            // luaTextBox
            // 
            this.luaTextBox.AcceptsReturn = true;
            this.luaTextBox.AcceptsTab = true;
            this.luaTextBox.BackColor = System.Drawing.Color.Black;
            this.luaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luaTextBox.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.luaTextBox.Location = new System.Drawing.Point(0, 0);
            this.luaTextBox.Multiline = true;
            this.luaTextBox.Name = "luaTextBox";
            this.luaTextBox.Size = new System.Drawing.Size(364, 293);
            this.luaTextBox.TabIndex = 0;
            this.luaTextBox.WordWrap = false;
            // 
            // linksTextBox
            // 
            this.linksTextBox.AcceptsReturn = true;
            this.linksTextBox.AcceptsTab = true;
            this.linksTextBox.BackColor = System.Drawing.Color.Black;
            this.linksTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linksTextBox.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linksTextBox.Location = new System.Drawing.Point(0, 0);
            this.linksTextBox.Multiline = true;
            this.linksTextBox.Name = "linksTextBox";
            this.linksTextBox.Size = new System.Drawing.Size(364, 193);
            this.linksTextBox.TabIndex = 0;
            this.linksTextBox.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newLibToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New Node";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // newLibToolStripMenuItem
            // 
            this.newLibToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.newLibToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newLibToolStripMenuItem.Name = "newLibToolStripMenuItem";
            this.newLibToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.newLibToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newLibToolStripMenuItem.Text = "New Lib";
            this.newLibToolStripMenuItem.Click += new System.EventHandler(this.newLibToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1229, 518);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.TextBox passageTextBox;
        private System.Windows.Forms.TextBox luaTextBox;
        private System.Windows.Forms.TextBox linksTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLibToolStripMenuItem;
    }
}

