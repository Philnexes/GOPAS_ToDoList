using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListMVP.Presenters.Processor
{
    public abstract class PresenterCommand : ICommand<ToDoPresenter>
    {
        [NonSerialized]
        private ToDoPresenter receiver;

        public ToDoPresenter Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }

        public abstract void Execute();
    }
}
