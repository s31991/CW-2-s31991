class Program
{
    static void Main()
    {
        Ship ship = new Ship("Ocean Carrier", 50000, 100, 25);
        var liquidContainer = new LiquidContainer(10000, true);
        var gasContainer = new GasContainer(8000, 10);
        var fridgeContainer = new RefrigeratedContainer(12000, "Bananas", 5);

        ship.LoadContainer(liquidContainer);
        ship.LoadContainer(gasContainer);
        ship.LoadContainer(fridgeContainer);

        try { liquidContainer.Load(6000); } catch (Exception e) { Console.WriteLine(e.Message); }
        ship.PrintShipInfo();
    }
}
