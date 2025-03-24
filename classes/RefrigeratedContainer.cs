class RefrigeratedContainer : Container
{
    public string ProductType { get; }
    public double Temperature { get; }
    public RefrigeratedContainer(double maxLoad, string productType, double temperature) : base("C", maxLoad)
    {
        ProductType = productType;
        Temperature = temperature;
    }
}
