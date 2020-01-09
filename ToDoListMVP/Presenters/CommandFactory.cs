using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListMVP.Models;

namespace ToDoListMVP.Presenters
{
    public class CommandFactory : ICommandFactory
    {
        IToDoPresenter reciever;

        public CommandFactory(IToDoPresenter reciever)
        {
            this.reciever = reciever;
        }

        public ICommand CreateAddCommand()  
            => new AddCommand() { Reciever = reciever };

        public ICommand CreateDeleteCommand(ToDo item)
            => new DeleteCommand()
            {
                Reciever = reciever,
                Item = item
            };
        
        public ICommand CreateEditCommand(ToDo item)
            => new EditCommand()
            {
                Reciever = reciever,
                Item = item
            };

        public ICommand CreateSaveCommand(ToDo item)
            => new SaveCommand()
            {
                Reciever = reciever,
                Item = item
            };

        public ICommand CreateSetListViewCommand(IView<ListViewData> listView)
            => new SetListViewCommand()
            {
                Reciever = reciever,
                listView = listView
            };
    }
}
