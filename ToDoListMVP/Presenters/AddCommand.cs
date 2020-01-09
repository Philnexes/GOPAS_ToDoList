namespace ToDoListMVP.Presenters
{
    public class AddCommand : PresenterCommandBase
    {
        public override void Execute()
        {
            Reciever.AddAction();
        }
    }
}