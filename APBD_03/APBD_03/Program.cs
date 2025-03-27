namespace APBD_03;

class Program
{
    public static void Main(string[] args)
    {
        LiquidContainer liquidContainer =  new LiquidContainer(200,1000,500,10000,true);
        liquidContainer.loadContainer(200);
        
        GasContainer gasContainer = new GasContainer(200,1000,500,2000,4000);
        gasContainer.loadContainer(4000);
        gasContainer.unloadContainer();
        Console.WriteLine($"gas container afer unloadint: {gasContainer.mass}");
        
        RefridgeratedContainer refridgeratedContainer = new RefridgeratedContainer(200,1000,500,8000,"bananas",13.3,14);
        refridgeratedContainer.loadContainer(2000);

        ContainerShip containerShip = new ContainerShip(20, 10, 200);
        containerShip.loadContainer(liquidContainer);
        containerShip.loadContainer(gasContainer);
        containerShip.loadContainer(refridgeratedContainer);
        
        Console.WriteLine(containerShip);
    }
}