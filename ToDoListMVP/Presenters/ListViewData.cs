using System.Collections.Generic;
using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters
{
    public class ListViewData
    {
        public IEnumerable<ToDo> ToDos { get; set; }
    }
}
