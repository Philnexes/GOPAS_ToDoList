using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters
{
    public class DeleteCommand : PresenterCommandBase
    {
        public ToDo Item { get; set; }

        public override bool IsCompensable => true;

        public override void Compensate()
        {
            Reciever.SaveAction(new ToDo() { Text = Item.Text, Done = Item.Done });
        }

        public override void Execute()
        {
            Reciever.DeleteAction(Item);
        }
    }
}