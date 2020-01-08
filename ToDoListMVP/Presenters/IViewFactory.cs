namespace ToDoListMVP.Presenters
{
    public interface IViewFactory
    {
        IToDoPresenter ToDoPresenter { get; set; }
        IView<DetailViewData> CreateDetailView();
    }
}