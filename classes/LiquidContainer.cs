class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; }
    public LiquidContainer(double maxLoad, bool isHazardous) : base("L", maxLoad)
    {
        IsHazardous = isHazardous;
    }

    public override void Load(double weight)
    {
        double limit = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (CurrentLoad + weight > limit)
        {
            NotifyHazard("Attempted dangerous load operation!");
            throw new Exception("Hazardous operation detected!");
        }
        base.Load(weight);
    }

    public void NotifyHazard(string message) => Console.WriteLine($"Hazard: {message} ({SerialNumber})");
}