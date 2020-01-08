namespace ToDoListMVP.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Done { get; set; }
        private string doneText => Done ? "done" : "not done";
        public override string ToString() => $"{Text} ({doneText})";
    }
}
