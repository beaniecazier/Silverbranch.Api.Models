namespace Gay.Silverbranch.API.Models.Interfaces;

public interface IAbstractFactory<T>
{
    T Create();
}