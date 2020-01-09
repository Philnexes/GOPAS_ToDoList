using ToDoListMVP.Models;
using ToDoListMVP.Views;

namespace ToDoListMVP.Presenters
{
    public interface ICommandFactory
    {
        ICommand CreateSetListViewCommand(IView<ListViewData> listView);
        ICommand CreateAddCommand();
        ICommand CreateEditCommand(ToDo item);
        ICommand CreateDeleteCommand(ToDo item);
        ICommand CreateSaveCommand(ToDo item);
    }
}
