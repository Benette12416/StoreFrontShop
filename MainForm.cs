using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreFrontShop.Forms1;
using ComponentFactory.Krypton.Toolkit;

namespace StoreFrontShop
{
    public partial class MainForm : KryptonForm
    {
        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Dock = DockStyle.Fill;
            form1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form1);
            form1.Show();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Dock = DockStyle.Fill;
            form1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form1);
            form1.Show();
        }
    }
}
