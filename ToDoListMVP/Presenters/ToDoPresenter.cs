using System.Collections.Generic;
using System.Linq;
// using System.Windows.Forms;
using ToDoListMVP.Models;
// using ToDoListMVP.Views;

namespace ToDoListMVP.Presenters
{
    public class ToDoPresenter : IToDoPresenter
    {
        IToDoList model;
        IViewFactory viewFactory;
        IViewHandler viewHandler;

        public ToDoPresenter(IToDoList model, IViewFactory viewFactory, IViewHandler viewHandler)
        {
            this.model = model;
            this.viewFactory = viewFactory;
            viewFactory.ToDoPresenter = this;
            this.viewHandler = viewHandler;
        }

        public IView<ListViewData> ListView { get; set; }
        private Dictionary<int, IView<DetailViewData>> detailViews
            = new Dictionary<int, IView<DetailViewData>>();

        private void showDetail(ToDo item)
        {
            if (detailViews.ContainsKey(item.Id))
                //((Form)detailViews[item.Id]).Focus();
                viewHandler.Focus(detailViews[item.Id]);
            else
            {
                var view = viewFactory.CreateDetailView(); //new DetailForm(this);
                detailViews.Add(item.Id, view);
                view.UpdateView(new DetailViewData() { ToDo = item });
                //((Form)view).Show();
                viewHandler.Show(view);
            }
        }

        private void updateListView()
            => ListView.UpdateView(new ListViewData()
            {
                ToDos = model.Items.ToList()
            });

        public void AddAction() => showDetail(new ToDo());
        public void EditAction(ToDo item) => showDetail(item);
        public void SaveAction(ToDo item)
        {
            //((Form)detailViews[item.Id]).Close();
            viewHandler.Close(detailViews[item.Id]);
            detailViews.Remove(item.Id);
            model.Save(item);
            updateListView();
        }

        public void DeleteAction(ToDo item)
        {
            model.Delete(item);
            updateListView();
        }

        
    }
}
