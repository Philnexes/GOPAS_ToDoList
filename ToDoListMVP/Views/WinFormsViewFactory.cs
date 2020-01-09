using ToDoListMVP.Presenters;

namespace ToDoListMVP.Views
{
    public class WinFormsViewFactory : IViewFactory
    {
        //public IToDoPresenter ToDoPresenter { get; set; }
        public ICommandProcessor CommandProcessor { get; set; }
        public ICommandFactory CommandFactory { get; set; }

        public IView<DetailViewData> CreateDetailView()
            => new DetailForm(CommandProcessor, CommandFactory);
    }
}
