namespace APBD_03;

public class ContainerShip
{
    public List<BaseContainer> Containers { get; set; } = new List<BaseContainer>();
    public double maxSpeed { get; set; }
    public int maxContainers { get; set; }
    public double maxMass { get; set; }

    public ContainerShip(double maxSpeed, int maxContainers, double maxMass)
    {
        this.maxSpeed = maxSpeed;
        this.maxContainers = maxContainers;
        this.maxMass = maxMass;
    }

    public void loadContainer(BaseContainer container)
    {
        if (Containers.Count >= maxContainers)
        {
            throw new ContainerShipException("Cannot load more containers,Capacity reached");
        }
        double totalMass = Containers.Sum(c => c.containerMass+c.mass) + (container.containerMass+container.mass);

        if (totalMass >= maxMass)
        {
            throw new ContainerShipException("Cannot load more containers,weight capacity reached");
        }
        Containers.Add(container);
    }

    public void loadContainers(List<BaseContainer> containers)
    {
        foreach (BaseContainer container in containers)
        {
            loadContainer(container);
        }
    }
    
    public void unloadContainer(BaseContainer container)
    {
        BaseContainer containerToUnload = Containers.FirstOrDefault(c => c.serialNumber == container.serialNumber);
        if (containerToUnload != null)
        {
            container.unloadContainer();
            Containers.Remove(containerToUnload);
        }
    }
    
    public void replaceContainer(string serialNumber, BaseContainer containerToLoad)
    {
        int index = Containers.FindIndex(c => c.serialNumber == serialNumber);
        if (index==-1)
        {
            throw new ContainerShipException("Container not found");
        }
        Containers[index] = containerToLoad;
    }

    public void transferContainer(ContainerShip destinationShip, string serialNumber)
    {
        BaseContainer containerToTransfer = Containers.FirstOrDefault(c => c.serialNumber == serialNumber);
        if (containerToTransfer == null)
        {
            Containers.Remove(containerToTransfer);
            destinationShip.loadContainer(containerToTransfer);
        }
    }
}