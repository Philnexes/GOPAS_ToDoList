using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters.Processor
{
    public class DeleteCommand : PresenterCommand
    {
        public ToDo Item { get; set; }
        public override void Execute()
        {
            Receiver.DeleteAction(Item);
        }
    }
}
