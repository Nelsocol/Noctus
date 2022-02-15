using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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
        private string SourceFile { get; set; }
        private TreeNode CurrentNode { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SourceFile = "./nTemplates/default.ntemplate";
            if (Directory.Exists("./temp")) 
            {
                Directory.Delete("./temp", true);
            }
            ZipFile.ExtractToDirectory(SourceFile, "./temp");
            RootDir = "./temp";
            PopulateTreeViewFromPath(RootDir, treeView1);
            treeView1.SelectedNode = treeView1.Nodes.Find("start", true)[0];
        }

        private string GetDirectory() 
        {
            using (var directoryDialog = new OpenFileDialog() {InitialDirectory = AppDomain.CurrentDomain.BaseDirectory, Filter = "noctus files (*.noctus)|*.noctus"})
            {
                DialogResult result = directoryDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(directoryDialog.FileName))
                {
                    return directoryDialog.FileName;
                }
            }

            return "";
        }

        private void PopulateTreeViewFromPath(string path, TreeView target) 
        {
            TreeNode nodesDirectory = new TreeNode("Nodes") {Name = "Nodes"};
            foreach (string filePath in Directory.GetFiles(RootDir, "*.header", SearchOption.AllDirectories)) 
            {
                nodesDirectory.Nodes.Add(new TreeViewPassageNode() { NodePath = filePath.Substring(0, filePath.Length - 7), Text = Path.GetFileNameWithoutExtension(filePath), Name = Path.GetFileNameWithoutExtension(filePath) });
            }
            target.Nodes.Add(nodesDirectory);

            TreeNode libDirectory = new TreeNode("Libraries") {Name = "Libraries"};
            foreach (string filePath in Directory.GetFiles(RootDir, "*.nlib", SearchOption.AllDirectories))
            {
                libDirectory.Nodes.Add(new TreeViewLibNode() { NodePath = filePath.Substring(0, filePath.Length - 5), Text = Path.GetFileNameWithoutExtension(filePath), Name = Path.GetFileNameWithoutExtension(filePath) });
            }
            target.Nodes.Add(libDirectory);

            target.Refresh();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!SourceFile.EndsWith(".ntemplate"))
            {
                saveToolStripMenuItem_Click(this, null);
            }
            else 
            {
                SaveToTemp();
            }

            ClearTextFields();
            if (e.Node is TreeViewPassageNode)
            {
                headerTextBox.Enabled = passageTextBox.Enabled = luaTextBox.Enabled = linksTextBox.Enabled = nameTextBox.Enabled = true;
                headerTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.header");
                passageTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.txt");
                passageTextBox.WordWrap = true;
                luaTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.lua");
                linksTextBox.Text = File.ReadAllText($"{(e.Node as TreeViewPassageNode).NodePath}.links");
                nameTextBox.Text = Path.GetFileName((e.Node as TreeViewPassageNode).NodePath);
                CurrentNode = e.Node;
            }
            else if (e.Node is TreeViewLibNode libNode)
            {
                nameTextBox.Enabled = passageTextBox.Enabled = true;
                headerTextBox.Enabled = luaTextBox.Enabled = linksTextBox.Enabled = false;
                nameTextBox.Text = Path.GetFileName($"{libNode.NodePath}");
                passageTextBox.Text = File.ReadAllText($"{libNode.NodePath}.nlib");
                passageTextBox.WordWrap = false;
                CurrentNode = e.Node;
            }     
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SourceFile != "")
            {
                if (!SourceFile.EndsWith(".ntemplate"))
                {
                    SaveToTemp();
                    if (File.Exists(SourceFile))
                    {
                        File.Delete(SourceFile);
                    }
                    ZipFile.CreateFromDirectory("./temp", SourceFile);
                }
                else
                {
                    saveAsToolStripMenuItem_Click(this, null);
                }
            }
        }

        private void SaveToTemp() 
        {
            if (CurrentNode != null) 
            {
                if (CurrentNode is TreeViewPassageNode)
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
                else
                {
                    File.WriteAllText($"{(CurrentNode as TreeViewLibNode).NodePath}.nlib", passageTextBox.Text);
                    if ((CurrentNode as TreeViewLibNode).Name != nameTextBox.Text)
                    {
                        File.Move($"{(CurrentNode as TreeViewLibNode).NodePath}.nlib", $"{Path.GetDirectoryName((CurrentNode as TreeViewLibNode).NodePath)}/{nameTextBox.Text}.nlib");
                        CurrentNode.Text = nameTextBox.Text;
                        CurrentNode.Name = nameTextBox.Text;
                        (CurrentNode as TreeViewLibNode).NodePath = $"{Path.GetDirectoryName((CurrentNode as TreeViewLibNode).NodePath)}/{nameTextBox.Text}";
                        treeView1.Refresh();
                    }
                }
            }
        }

        private void ClearTextFields()
        {
            headerTextBox.Text = passageTextBox.Text = luaTextBox.Text = linksTextBox.Text = nameTextBox.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int suffixNumber = 1;
            string rootDir = RootDir + "/game/.nodes/";
            while (File.Exists($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.header")) 
            {
                suffixNumber++;
            }
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.header").Close();
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.txt").Close();
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.lua").Close();
            File.Create($"{Path.Combine(rootDir, "newNode")}{suffixNumber}.links").Close();

            TreeNode newNode = new TreeViewPassageNode() { NodePath = $"{Path.Combine(rootDir, "newNode")}{suffixNumber}", Text = $"newNode{suffixNumber}", Name = $"newNode{suffixNumber}" };
            treeView1.Nodes["Nodes"].Nodes.Add(newNode);
            treeView1.SelectedNode = newNode;
            treeView1.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name != "start") 
            {
                if (CurrentNode is TreeViewPassageNode passageNode)
                {
                    File.Delete($"{passageNode.NodePath}.header");
                    File.Delete($"{passageNode.NodePath}.txt");
                    File.Delete($"{passageNode.NodePath}.lua");
                    File.Delete($"{passageNode.NodePath}.links");
                    TreeNode cachedNode = CurrentNode;
                    CurrentNode = null;
                    treeView1.Nodes["Nodes"].Nodes.Remove(cachedNode);
                    treeView1.SelectedNode = treeView1.Nodes["Nodes"].Nodes["start"];
                    treeView1.Refresh();
                }
                else
                {
                    File.Delete((CurrentNode as TreeViewLibNode).NodePath + ".nlib");
                    treeView1.Nodes["Libraries"].Nodes.Remove(CurrentNode);
                    treeView1.SelectedNode = treeView1.Nodes["Nodes"].Nodes["start"];
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog()) 
            {
                dialog.AddExtension = true;
                dialog.Filter = "noctus files (*.noctus)|*.noctus";
                dialog.DefaultExt = ".noctus";
                dialog.InitialDirectory = "./";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && dialog.FileName != "") 
                {
                    SourceFile = dialog.FileName;
                    saveToolStripMenuItem_Click(this, null);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentNode = null;
            SourceFile = GetDirectory();
            if (Directory.Exists("./temp"))
            {
                Directory.Delete("./temp", true);
            }     
            treeView1.Nodes.Clear();
            ZipFile.ExtractToDirectory(SourceFile, "./temp");
            RootDir = "./temp";
            PopulateTreeViewFromPath(RootDir, treeView1);
            treeView1.SelectedNode = treeView1.Nodes.Find("start", true)[0];
        }

        private void newLibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int suffixNumber = 1;
            string rootDir = RootDir + "/game/.noctus_libraries/";
            while (File.Exists($"{Path.Combine(rootDir, "newLib")}{suffixNumber}.nlib"))
            {
                suffixNumber++;
            }
            File.Create($"{Path.Combine(rootDir, "newLib")}{suffixNumber}.nlib").Close();

            TreeNode newNode = new TreeViewLibNode() { NodePath = $"{Path.Combine(rootDir, "newLib")}{suffixNumber}", Text = $"newLib{suffixNumber}", Name = $"newLib{suffixNumber}" };
            treeView1.Nodes["Libraries"].Nodes.Add(newNode);
            treeView1.SelectedNode = newNode;
            treeView1.Refresh();
        }
    }
}
