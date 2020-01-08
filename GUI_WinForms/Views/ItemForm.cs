using GUI_WinForms.Presenter;
using System;
using System.Windows.Forms;

namespace GUI_WinForms.Views
{
    public partial class ItemForm : Form, IView
    {
        public ItemForm() : this(string.Empty) { }

        public ItemForm(string text)
        {         
            InitializeComponent();
            if (text != string.Empty)
                itemTextBox.Text = text;
        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doneCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }
    }
}
