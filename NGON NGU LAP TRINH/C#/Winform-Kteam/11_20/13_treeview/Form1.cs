using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _13_treeview
{
    public partial class Form1 : Form
    {
        string path = @"E:\";
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                treeView1.Nodes.Add(root);
                loadExlorer(root);
            }
            
        }

        void loadExlorer(TreeNode root)
        {
            if (root == null) return;
            try
            {
                var foder = new DirectoryInfo(root.Text).GetDirectories();
                if (foder.Count() == 0) return;
                foreach (DirectoryInfo item in foder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        loadExlorer(node);
                    }
                }

            }
            catch
            {
                return;
            }

        }
    }
}
