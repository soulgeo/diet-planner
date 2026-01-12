public class SelectionItem<T>
{
    public T Value { get; }
    public string Display { get; }

    public SelectionItem(T value, string display)
    {
        Value = value;
        Display = display;
    }

    public override string ToString() => Display; // helps if you forget a template
}
