using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("add");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("edit");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("delete");
        }
    }
}
