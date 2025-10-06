public class Mario : Character
{
    public List<string> Alias { get; set; } = [];

    public override string Display()
    {
        return $"ID: {Id}\nName: {Name}\nDescription: {Description}\nAlias: {string.Join(", ", Alias)}\n";
    }
}