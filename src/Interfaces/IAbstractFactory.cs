namespace Gay.Silverbranch.Api.Models.Interfaces;

public interface IAbstractFactory<T>
{
    T Create();
}