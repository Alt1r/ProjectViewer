namespace ProjectViewer.Nodes.Interfaces
{
    public interface INode<T> : INode
    {
        T Item { get; set; }
    }
}