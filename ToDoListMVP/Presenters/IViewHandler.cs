using ToDoListMVP.Views;

namespace ToDoListMVP.Presenters
{
    public interface IViewHandler
    {
        void Focus(IView view);
        void Show(IView view);
        void Close(IView view);
    }
}