namespace APBD_03;

public class RefridgeratedContainer : BaseContainer
{
    public string productType { get; set; }
    public double temperatureRequired { get; set; }
    public double currentTemp { get; set; }

    public RefridgeratedContainer(ContainerTypes containerType, double height, double containerMass, double depth, double maxContainerMass, string productType, double temperatureRequired, double currentTemp) : base(containerType, height, containerMass, depth, maxContainerMass)
    {
        this.productType = productType;
        this.temperatureRequired = temperatureRequired;
        this.currentTemp = currentTemp;
        if (currentTemp<temperatureRequired)
        {
            throw  new RequiredTempException("Temperature is too low");
        }
    }

    public override void loadContainer(double massToLoad)
    {
        if (currentTemp<temperatureRequired)
        {
            throw new RequiredTempException("Temperature is too low for the product type");
        }
        base.loadContainer(massToLoad);
    }
    
}