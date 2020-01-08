using System.Collections.Generic;

namespace ToDoListMVP.Models
{
    public interface IToDoList
    {
        IEnumerable<ToDo> Items { get; }
        void Save(ToDo item);
        void Delete(ToDo item);
    }
}
