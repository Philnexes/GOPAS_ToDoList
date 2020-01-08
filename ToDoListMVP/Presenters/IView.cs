namespace ToDoListMVP.Presenters
{
    public interface IView { }
    public interface IView<T> : IView
    {
        void UpdateView(T viewData);
    }
}
