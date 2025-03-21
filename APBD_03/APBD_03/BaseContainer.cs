namespace APBD_03;

public abstract class BaseContainer
{
    public double mass {get; set;}
    public double height {get; set;}
    public double containerMass {get; set;}
    public double depth {get; set;}
    public SerialNumberGen? serialNumber {get; set;}
    public double maxContainerMass {get; set;}

    public abstract void loadContainer();
    public abstract void unloadContainer();
}