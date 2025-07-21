using Gay.Silverbranch.Api.Models.Interfaces;

namespace Gay.Silverbranch.Api.Models;

public class AbstractFactory<T> : IAbstractFactory<T>
{
    private readonly Func<T> _factory;

    public AbstractFactory(Func<T> factory)
    {
        this._factory = factory;
    }

    public T Create() => _factory();
}
