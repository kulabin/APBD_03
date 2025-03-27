namespace APBD_03;

public class LiquidContainer : BaseContainer,IHazardNotifier
{
    public bool isHazardous { get; }

    public LiquidContainer(ContainerTypes containerType, double height, double containerMass, double depth, double maxContainerMass, bool isHazardous) : base(containerType, height, containerMass, depth, maxContainerMass)
    {
        this.isHazardous = isHazardous;
    }


    public override void loadContainer(double massToLoad)
    {
        base.loadContainer(massToLoad);
        
        double allowedCapacity =  isHazardous ? maxContainerMass * 0.5 : maxContainerMass * 0.9;
        if (maxContainerMass > allowedCapacity)
        {
            sendHazardNotification($"Container {serialNumber} exceeded safe capacity for {(isHazardous ? "hazardous" : "non-hazardous")} cargo.");
        }
    }

    public string sendHazardNotification(string message)
    {
        return $"Hazard notification: {message}";
    }
}