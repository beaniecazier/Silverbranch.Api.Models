using Gay.Silverbranch.API.Models.Entities.V1;

namespace Gay.Silverbranch.API.Models.History.V1;

public class History<T> : List<T>
    where T : BaseModel
{
    public History() { }

    public T Newest()
    {
        var availables = this.Where(x => !x.IsHidden).ToList();
        availables.Sort();
        return availables.First();
    }
}