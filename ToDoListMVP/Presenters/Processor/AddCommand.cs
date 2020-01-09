using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListMVP.Presenters.Processor
{
    public class AddCommand : PresenterCommand
    {
        public override void Execute()
        {
            Receiver.AddAction();
        }
    }
}
