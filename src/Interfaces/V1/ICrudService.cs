using LanguageExt;

namespace Gay.Silverbranch.API.Models.Interfaces.V1;

public interface ICrudService<T>
//where T : BaseModel
{
    Fin<int> Create();
    Fin<int> Create(T obj);
    Fin<int> Create(SortedList<string, object> parameters);

    Fin<T> Read(int id);
    //Fin<T> ReadFirst(string name);
    //Fin<T> ReadFirst(string paramName, object value);
    //Fin<T> Read(string name, string paramName, object value);

    Fin<IEnumerable<T>> ReadAll();
    Fin<IEnumerable<T>> ReadAll(string name);
    Fin<IEnumerable<T>> ReadAll(SortedList<string, object> parameters);

    Fin<int> Update(T entity);
    IEnumerable<Fin<int>> UpdateAllOf(IEnumerable<T> entity);

    Fin<int> Delete(T entity);
    Fin<int> DeleteAll();
}
