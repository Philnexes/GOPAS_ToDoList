using System.Windows.Forms;
using ToDoListMVP.Presenters;

namespace ToDoListMVP.Views
{
    public abstract class ViewBase<T> : Form, IView<T>
    {
        protected IToDoPresenter presenter;

        protected ViewBase(IToDoPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        public abstract void UpdateView(T viewData);

        protected abstract void InitializeComponent();
        //{
        //    this.SuspendLayout();
        //    // 
        //    // ViewBase
        //    // 
        //    this.ClientSize = new System.Drawing.Size(278, 244);
        //    this.Name = "ViewBase";
        //    this.ResumeLayout(false);

        //}
    }
}
