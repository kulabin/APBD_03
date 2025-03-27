namespace APBD_03;

public abstract class BaseContainer
{
    public double mass {get; set;}
    public double height {get; set;}
    public double containerMass {get; set;}
    public double depth {get; set;}
    public string serialNumber {get; set;}
    public double maxContainerMass {get; set;}

    public BaseContainer(ContainerTypes containerType, double height, double containerMass, double depth,
        double maxContainerMass)
    {
        serialNumber = new SerialNumberGen(containerType).serialNumber;
        this.height = height;
        this.containerMass = containerMass;
        this.depth = depth;
        this.maxContainerMass = maxContainerMass;
    }

    public virtual void loadContainer(double massToLoad)
    {
        if (containerMass+mass > maxContainerMass)
        {
            throw new OverflowException("Container is overweight");
        }
        mass += massToLoad;
    }

    public virtual void unloadContainer()
    {
        mass = 0;
    }
}