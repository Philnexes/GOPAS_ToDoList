namespace ToDoListMVP.Presenters
{
    public interface IViewFactory
    {
        //IToDoPresenter ToDoPresenter { get; set; }
        ICommandProcessor CommandProcessor { get; set; }
        ICommandFactory CommandFactory { get; set; }
        IView<DetailViewData> CreateDetailView();
    }
}