namespace Progress.models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Progress { get; set; }
        public bool IsCompleted { get; set; }
    }
}
