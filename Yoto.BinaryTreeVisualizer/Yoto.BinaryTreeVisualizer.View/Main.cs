using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yoto.BinaryTreeVisualizer.TreeControls;

namespace Yoto.BinaryTreeVisualizer.View
{
    public partial class frmMain : Form
    {
        Tree tree = new Tree();
        Graphics graphics;
        static Rectangle nodeSize = new Rectangle(0, 0, 50, 50);
        static Pen pen = new Pen(Color.Black, 3);
        public frmMain()
        {
            InitializeComponent();
            graphics = pnlTree.CreateGraphics();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numAddValue.Value);
            Node node = new Node(value);
            tree.AddNode(node);
        }
    }
}
