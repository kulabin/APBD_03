
namespace APBD_03;

public class GasContainer : BaseContainer, IHazardNotifier
{
    public double pressure { get; set; }
    
    public GasContainer(double height,double containerMass, double depth, double maxContainerMass, double pressure) : base(ContainerTypes.Gas, height, containerMass, depth, maxContainerMass)
    {
        this.pressure = pressure;
    }   
    public override void unloadContainer()
    {
        mass *= 0.05;
    }
    public string sendHazardNotification(string message)
    {
        return $"Hazard notification: {message}";
    }
}