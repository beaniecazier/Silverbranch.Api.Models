using Gay.Silverbranch.API.Models.Entities.V1;
using LanguageExt;

namespace Gay.Silverbranch.API.Models.Interfaces.V1;

public interface ICardManager<T, D>
    where T : BaseModel
    where D : IDeck<T>
{
    public bool Loaded { get; }

    public D GetFreshDeck();

    public Fin<string> Load(ICrudService<T> service);
}