using GUI_WinForms.Presenter;
using System;
using System.Windows.Forms;

namespace GUI_WinForms.Views
{
    public partial class MainWindow : Form, IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("add");
            var itemForm = new ItemForm();       
            itemForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("edit");
            var itemForm = new ItemForm(/*tu prijde text z itemu*/);
            itemForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("delete");
        }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }
    }
}
