using System;
using System.Windows.Forms;
using ToDoListMVP.Models;
using ToDoListMVP.Presenters;
using ToDoListMVP.Views;

namespace ToDoListMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var model = new ToDoList();
            var viewHandler = new WinFormsViewHandler();
            var viewFactory = new WinFormsViewFactory();
            var presenter = new ToDoPresenter(model, viewFactory, viewHandler);
            var commandProcessor = new CommandProcessor();
            var commandFactory = new CommandFactory(presenter);
            viewFactory.CommandProcessor = commandProcessor;
            viewFactory.CommandFactory = commandFactory;
            Application.Run(new ListForm(commandProcessor, commandFactory));
        }
    }
}
