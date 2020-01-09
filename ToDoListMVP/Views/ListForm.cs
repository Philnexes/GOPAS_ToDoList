﻿using System.Windows.Forms;
using ToDoListMVP.Models;
using ToDoListMVP.Presenters;

namespace ToDoListMVP.Views
{
    public class ListForm : ViewBase<ListViewData>
    {
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button undoButton;
        private ListBox listBox;

        protected override void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            undoButton = new Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(94, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 33);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(175, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 33);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(256, 13);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 33);
            this.undoButton.TabIndex = 3;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += UndoButton_Click; ;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(13, 52);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(320, 224);
            this.listBox.TabIndex = 3;
            // 
            // ListForm
            // 
            this.ClientSize = new System.Drawing.Size(340, 344);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.undoButton);
            this.Name = "ListForm";
            this.ResumeLayout(false);

        }

        private void UndoButton_Click(object sender, System.EventArgs e)
        {
            commandProcessor.CompensateLast();
        }

        public ListForm(ICommandProcessor commandProcessor, ICommandFactory commandFactory) : base(commandProcessor, commandFactory)
        {
            //presenter.ListView = this;
            commandProcessor.ExecuteCommand(commandFactory.CreateSetListViewCommand(this));
        }

        

        

        public override void UpdateView(ListViewData viewData)
        {
            listBox.DataSource = null;
            listBox.DataSource = viewData.ToDos;
        }

        private void addButton_Click(object sender, System.EventArgs e)
            => commandProcessor.ExecuteCommand(commandFactory.CreateAddCommand()); //presenter.AddAction();

        private void editButton_Click(object sender, System.EventArgs e)
            => commandProcessor.ExecuteCommand(commandFactory.CreateEditCommand((ToDo)listBox.SelectedItem)); //presenter.EditAction((ToDo)listBox.SelectedItem);

        private void deleteButton_Click(object sender, System.EventArgs e)
            => commandProcessor.ExecuteCommand(commandFactory.CreateDeleteCommand((ToDo)listBox.SelectedItem)); //presenter.DeleteAction((ToDo)listBox.SelectedItem);

    }
}
