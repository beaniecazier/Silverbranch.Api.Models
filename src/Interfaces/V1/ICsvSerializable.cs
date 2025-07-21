namespace Gay.Silverbranch.Api.Models.Interfaces.V1;

public interface ICsvSerializable : ISerializable
{
    string SerializeForCsv(string deliminator);
}
