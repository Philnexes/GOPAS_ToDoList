using System.Windows.Forms;
using ToDoListMVP.Models;
using ToDoListMVP.Presenters;

namespace ToDoListMVP.Views
{
    public class DetailForm : ViewBase<DetailViewData>
    {
        private TextBox textTextBox;
        private CheckBox doneCheckBox;
        private Button saveButton;
        private Label textLabel;
        private int id;

        public DetailForm(IToDoPresenter presenter) : base(presenter) { }

        public override void UpdateView(DetailViewData viewData)
        {
            id = viewData.ToDo.Id;
            textTextBox.Text = viewData.ToDo.Text;
            doneCheckBox.Checked = viewData.ToDo.Done;
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
            => presenter.SaveAction(new ToDo() {
                Id = id,
                Text = textTextBox.Text,
                Done = doneCheckBox.Checked
            });

        protected override void InitializeComponent()
        {
            this.textLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.doneCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(12, 15);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(39, 20);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Text";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(68, 12);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(241, 26);
            this.textTextBox.TabIndex = 1;
            // 
            // doneCheckBox
            // 
            this.doneCheckBox.AutoSize = true;
            this.doneCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doneCheckBox.Location = new System.Drawing.Point(12, 44);
            this.doneCheckBox.Name = "doneCheckBox";
            this.doneCheckBox.Size = new System.Drawing.Size(74, 24);
            this.doneCheckBox.TabIndex = 2;
            this.doneCheckBox.Text = "Done";
            this.doneCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(234, 70);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += SaveButton_Click;
            // 
            // DetailForm
            // 
            this.ClientSize = new System.Drawing.Size(321, 116);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.doneCheckBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.textLabel);
            this.Name = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
