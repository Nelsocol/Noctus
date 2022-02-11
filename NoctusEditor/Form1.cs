using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoctusEditor
{
    public partial class Form1 : Form
    {
        private string RootDir { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RootDir = GetDirectory();
            PopulateTreeViewFromPath(RootDir, treeView1);
        }

        private string GetDirectory() 
        {
            using (var directoryDialog = new FolderBrowserDialog() {SelectedPath = AppDomain.CurrentDomain.BaseDirectory})
            {
                DialogResult result = directoryDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(directoryDialog.SelectedPath))
                {
                    return directoryDialog.SelectedPath;
                }
            }

            return "";
        }

        private void PopulateTreeViewFromPath(string path, TreeView target) 
        {
            foreach (string filePath in Directory.GetFiles(RootDir, "*.header", SearchOption.AllDirectories)) 
            {
                target.Nodes.Add(new TreeViewPassageNode() { NodePath = filePath.Substring(0, filePath.Length - 4), Text = Path.GetFileNameWithoutExtension(filePath) });
            }
            target.Refresh();
        }
    }
}
