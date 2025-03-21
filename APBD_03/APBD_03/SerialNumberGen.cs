namespace APBD_03;

public class SerialNumberGen
{
    private string serialNumber;
    private int id;
    private const string prefix = "KON";

    public SerialNumberGen(ContainerTypes containerType)
    {
        var type = containerType switch
        {
            ContainerTypes.Liquid => "L",
            ContainerTypes.Gas => "G",
            ContainerTypes.Refrigderated => "C",
            _ => throw new UnknownContainerTypeException("Unknown container type."),
        };
        serialNumber = $"{prefix}-{type}-{id++}";
    }
}