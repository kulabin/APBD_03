namespace APBD_03;

public class LiquidContainer : BaseContainer,IHazardNotifier
{
    public override void loadContainer()
    {
        if (containerMass+mass > maxContainerMass)
        {
            throw new OverflowException("Container is overweight");
            
        }
    }

    public override void unloadContainer()
    {
        throw new NotImplementedException();
    }

    public string sendHazardNotification()
    {
        return $"Dangerous situation for: {serialNumber}";
    }
}