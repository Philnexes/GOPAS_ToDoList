using System.Linq;
using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters
{
    public class SaveCommand : PresenterCommandBase
    {
        bool insert;
        ToDo originalState;
        public ToDo Item { get; set; }
        public override bool IsCompensable => true;
        public override void Compensate()
        {
            if (insert) Reciever.DeleteAction(Item);
            else Reciever.SaveAction(originalState);
        }
        public override void Execute()
        {
            var existing = Reciever.ToDoItems.FirstOrDefault(i => i.Id == Item.Id);
            insert = existing == null;
            originalState = new ToDo()
            {
                Id = existing == null ? 0 : existing.Id,
                Text = existing?.Text,
                Done = existing == null ? false : existing.Done
            };
            Reciever.SaveAction(Item);
            
        }
    }
}