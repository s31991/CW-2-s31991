class Ship
{
    public string Name { get; }
    public double MaxWeight { get; }
    public int MaxContainers { get; }
    public double MaxSpeed { get; }
    private List<Container> Containers = new List<Container>();

    public Ship(string name, double maxWeight, int maxContainers, double maxSpeed)
    {
        Name = name;
        MaxWeight = maxWeight;
        MaxContainers = maxContainers;
        MaxSpeed = maxSpeed;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers || GetTotalWeight() + container.MaxLoad > MaxWeight * 1000)
            throw new Exception("Ship capacity exceeded!");
        Containers.Add(container);
    }

    public void UnloadContainer(string serialNumber) => Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    public double GetTotalWeight() => Containers.Sum(c => c.MaxLoad);
    public void PrintShipInfo()
    {
        Console.WriteLine($"Ship: {Name}, Speed: {MaxSpeed} knots, Capacity: {Containers.Count}/{MaxContainers}");
        foreach (var container in Containers)
            Console.WriteLine(container);
    }
}