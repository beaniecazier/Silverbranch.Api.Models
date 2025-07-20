using Gay.Silverbranch.API.Models.Interfaces;

namespace Gay.Silverbranch.API.Models;

public class AbstractFactory<T> : IAbstractFactory<T>
{
    private readonly Func<T> _factory;

    public AbstractFactory(Func<T> factory)
    {
        this._factory = factory;
    }

    public T Create() => _factory();
}
