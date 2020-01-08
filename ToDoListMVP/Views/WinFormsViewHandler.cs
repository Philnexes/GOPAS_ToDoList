using System;
using System.Windows.Forms;
using ToDoListMVP.Presenters;

namespace ToDoListMVP.Views
{
    public class WinFormsViewHandler : IViewHandler
    {
        public void Close(IView view) => ((Form)view).Close();
        public void Focus(IView view) => ((Form)view).Focus();
        public void Show(IView view) => ((Form)view).Show();
    }
}
