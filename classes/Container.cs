abstract class Container
{
    private static int _counter = 1;
    public string SerialNumber { get; }
    public double MaxLoad { get; }
    public double CurrentLoad { get; private set; } = 0;

    protected Container(string type, double maxLoad)
    {
        SerialNumber = $"KON-{type}-{_counter++}";
        MaxLoad = maxLoad;
    }

    public virtual void Load(double weight)
    {
        if (CurrentLoad + weight > MaxLoad)
            throw new Exception("OverfillException: Exceeded max load capacity!");
        CurrentLoad += weight;
    }

    public virtual void Unload() => CurrentLoad = 0;
    public override string ToString() => $"{SerialNumber}: {CurrentLoad}/{MaxLoad} kg";
}