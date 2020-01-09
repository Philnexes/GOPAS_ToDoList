namespace ToDoListMVP.Presenters
{
    public class SetListViewCommand : PresenterCommandBase
    {
        public IView<ListViewData> listView { get; set; }

        public override void Execute()
        {
            Reciever.ListView = listView;
        }
    }
}