using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters
{
    public interface IToDoPresenter
    {
        IView<ListViewData> ListView { get; set; }
        void AddAction();
        void EditAction(ToDo item);
        void DeleteAction(ToDo item);
        void SaveAction(ToDo item);
    }
}
