﻿
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.passageTextBox = new System.Windows.Forms.TextBox();
            this.luaTextBox = new System.Windows.Forms.TextBox();
            this.linksTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(240, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(989, 450);
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
            this.splitContainer2.Panel1.Controls.Add(this.headerTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.passageTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(621, 450);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
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
            this.splitContainer3.Size = new System.Drawing.Size(364, 450);
            this.splitContainer3.SplitterDistance = 270;
            this.splitContainer3.TabIndex = 0;
            // 
            // headerTextBox
            // 
            this.headerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTextBox.Location = new System.Drawing.Point(0, 0);
            this.headerTextBox.Multiline = true;
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.headerTextBox.Size = new System.Drawing.Size(621, 25);
            this.headerTextBox.TabIndex = 0;
            this.headerTextBox.WordWrap = false;
            // 
            // passageTextBox
            // 
            this.passageTextBox.AcceptsReturn = true;
            this.passageTextBox.AcceptsTab = true;
            this.passageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passageTextBox.Location = new System.Drawing.Point(0, 0);
            this.passageTextBox.Multiline = true;
            this.passageTextBox.Name = "passageTextBox";
            this.passageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passageTextBox.Size = new System.Drawing.Size(621, 421);
            this.passageTextBox.TabIndex = 0;
            // 
            // luaTextBox
            // 
            this.luaTextBox.AcceptsReturn = true;
            this.luaTextBox.AcceptsTab = true;
            this.luaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luaTextBox.Location = new System.Drawing.Point(0, 0);
            this.luaTextBox.Multiline = true;
            this.luaTextBox.Name = "luaTextBox";
            this.luaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.luaTextBox.Size = new System.Drawing.Size(364, 270);
            this.luaTextBox.TabIndex = 0;
            this.luaTextBox.WordWrap = false;
            // 
            // linksTextBox
            // 
            this.linksTextBox.AcceptsReturn = true;
            this.linksTextBox.AcceptsTab = true;
            this.linksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linksTextBox.Location = new System.Drawing.Point(0, 0);
            this.linksTextBox.Multiline = true;
            this.linksTextBox.Name = "linksTextBox";
            this.linksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.linksTextBox.Size = new System.Drawing.Size(364, 176);
            this.linksTextBox.TabIndex = 0;
            this.linksTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView1);
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
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

