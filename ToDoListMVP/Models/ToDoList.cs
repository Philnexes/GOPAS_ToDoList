using System.Collections.Generic;
using System.Linq;

namespace ToDoListMVP.Models
{
    public class ToDoList : IToDoList
    {
        List<ToDo> items = new List<ToDo>();
        public IEnumerable<ToDo> Items => items;

        public void Delete(ToDo item)
        {
            var existing = items.First(i => i.Id == item.Id);
            items.Remove(existing);
        }

        public void Save(ToDo item)
        {
            var existing = items.FirstOrDefault(i => i.Id == item.Id);
            if (existing == null) insert(item);
            else update(existing, item);
        }
        private void insert(ToDo item)
        {
            item.Id = items.Count == 0 ? 1 : items.Max(i => i.Id) + 1;
            items.Add(item);
        }
        private void update(ToDo existing, ToDo item)
        {
            existing.Text = item.Text;
            existing.Done = item.Done;
        }
    }
}
