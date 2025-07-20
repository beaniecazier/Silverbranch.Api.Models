using Gay.Silverbranch.API.Models.Entities.V1;

namespace Gay.Silverbranch.API.Models.Interfaces.V1;

public interface IDeck<T>
    where T : BaseModel
{
    List<T> Deck { get; }
    int Count { get; }

    T DrawFaceUp();
    T DrawFaceDown();
    void ReloadDeck();
    void Shuffle();
}
