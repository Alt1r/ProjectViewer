namespace ProjectViewer.Models.EventArgs
{
    public class NameChangedEventArgs : System.EventArgs
    {
        public string Name;

        public NameChangedEventArgs(string name)
        {
            Name = name;
        }
    }
        
}
