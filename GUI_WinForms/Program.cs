using GUI_WinForms.Presenter;
using GUI_WinForms.Views;
using Ninject;
using System;
using System.Windows.Forms;

namespace GUI_WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainWindow mainWindow;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new StandardKernel();

            //Views
            container.Bind<IView>().To<MainWindow>().InSingletonScope().Named("Main");
            container.Bind<IView>().To<ItemForm>().Named("Item");

            mainWindow = (MainWindow)container.Get<IView>("Main");
            Application.Run(mainWindow);
        }
    }
}
