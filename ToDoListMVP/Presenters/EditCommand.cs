using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters
{
    internal class EditCommand : PresenterCommandBase
    {
        public ToDo Item { get; set; }

        public override void Execute()
        {
            Reciever.EditAction(Item);
        }
    }
}