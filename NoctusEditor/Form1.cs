using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoctusEditor
{
    public partial class Form1 : Form
    {
        private string RootDir { get; set; }
        private TreeNode CurrentNode { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RootDir = GetDirectory();
            PopulateTreeViewFromPath(RootDir, treeView1);
            treeView1.SelectedNode = treeView1.Nodes.Find("start", true)[0];
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
                target.Nodes.Add(new TreeViewPassageNode() { NodePath = filePath.Substring(0, filePath.Length - 7), Text = Path.GetFileNameWithoutExtension(filePath), Name = Path.GetFileNameWithoutExtension(filePath) });
            }
            target.Refresh();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            headerTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.header");
            passageTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.txt");
            luaTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.lua");
            linksTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.links");
            nameTextBox.Text = Path.GetFileName((e.Node as TreeViewPassageNode).NodePath);
            CurrentNode = e.Node;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"{(CurrentNode as TreeViewPassageNode).NodePath}.header", headerTextBox.Text);
            File.WriteAllText($"{(CurrentNode as TreeViewPassageNode).NodePath}.txt", passageTextBox.Text);
            File.WriteAllText($"{(CurrentNode as TreeViewPassageNode).NodePath}.lua", luaTextBox.Text);
            File.WriteAllText($"{(CurrentNode as TreeViewPassageNode).NodePath}.links", linksTextBox.Text);

            if ((CurrentNode as TreeViewPassageNode).Name != nameTextBox.Text) 
            {
                File.Move($"{(CurrentNode as TreeViewPassageNode).NodePath}.header", $"{Path.GetDirectoryName((CurrentNode as TreeViewPassageNode).NodePath)}/{nameTextBox.Text}.header");
                File.Move($"{(CurrentNode as TreeViewPassageNode).NodePath}.txt", $"{Path.GetDirectoryName((CurrentNode as TreeViewPassageNode).NodePath)}/{nameTextBox.Text}.txt");
                File.Move($"{(CurrentNode as TreeViewPassageNode).NodePath}.lua", $"{Path.GetDirectoryName((CurrentNode as TreeViewPassageNode).NodePath)}/{nameTextBox.Text}.lua");
                File.Move($"{(CurrentNode as TreeViewPassageNode).NodePath}.links", $"{Path.GetDirectoryName((CurrentNode as TreeViewPassageNode).NodePath)}/{nameTextBox.Text}.links");
                CurrentNode.Text = nameTextBox.Text;
                CurrentNode.Name = nameTextBox.Text;
                (CurrentNode as TreeViewPassageNode).NodePath = $"{Path.GetDirectoryName((CurrentNode as TreeViewPassageNode).NodePath)}/{nameTextBox.Text}";
                treeView1.Refresh();
            }      
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int suffixNumber = 1;
            string rootDir = Path.GetDirectoryName((CurrentNode as TreeViewPassageNode).NodePath);
            while (File.Exists($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.header")) 
            {
                suffixNumber++;
            }
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.header").Close();
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.txt").Close();
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.lua").Close();
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.links").Close();

            TreeNode newNode = new TreeViewPassageNode() { NodePath = $"{Path.Combine(rootDir, "newNode")}{suffixNumber}", Text = $"newNode{suffixNumber}", Name = $"newNode{suffixNumber}" };
            treeView1.Nodes.Add(newNode);
            treeView1.SelectedNode = newNode;
            treeView1.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name != "start") 
            {
                File.Delete((CurrentNode as TreeViewPassageNode).NodePath + ".header");
                File.Delete((CurrentNode as TreeViewPassageNode).NodePath + ".txt");
                File.Delete((CurrentNode as TreeViewPassageNode).NodePath + ".lua");
                File.Delete((CurrentNode as TreeViewPassageNode).NodePath + ".links");
                treeView1.Nodes.Remove(CurrentNode);
                treeView1.SelectedNode = treeView1.Nodes["start"];
                treeView1.Refresh();
            }
        }
    }
}
