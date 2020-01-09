using System.Windows.Forms;
using ToDoListMVP.Presenters;

namespace ToDoListMVP.Views
{
    public abstract class ViewBase<T> : Form, IView<T>
    {
        //protected IToDoPresenter presenter;
        protected ICommandProcessor commandProcessor;
        protected ICommandFactory commandFactory;

        protected ViewBase(ICommandProcessor commandProcessor, ICommandFactory commandFactory)
        {
            InitializeComponent();
            this.commandProcessor = commandProcessor;
            this.commandFactory = commandFactory;
        }

        public abstract void UpdateView(T viewData);

        protected abstract void InitializeComponent();
        
    }
}
