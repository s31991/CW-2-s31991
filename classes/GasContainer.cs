class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }
    public GasContainer(double maxLoad, double pressure) : base("G", maxLoad)
    {
        Pressure = pressure;
    }

    public override void Unload() => CurrentLoad *= 0.05; // Leave 5% of load
    public void NotifyHazard(string message) => Console.WriteLine($"Hazard: {message} ({SerialNumber})");
}
