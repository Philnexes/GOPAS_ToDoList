using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters.Processor
{
    public class EditCommand : PresenterCommand
    {
        public ToDo Item { get; set; }

        public override void Execute()
        {
            Receiver.EditAction(Item);
        }
    }
}
