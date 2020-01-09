namespace ToDoListMVP.Presenters
{
    public interface ICommandProcessor
    {
        void CompensateLast();
        void ExecuteCommand(ICommand cmd);
    }
}