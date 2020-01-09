using System;

namespace ToDoListMVP.Presenters
{
    public abstract class PresenterCommandBase : ICommand
    {
        public IToDoPresenter Reciever { get; set; }

        public virtual bool IsCompensable => false;

        public virtual void Compensate() 
            => throw new Exception("This command cannot be compensated");

        public abstract void Execute();
    }
}