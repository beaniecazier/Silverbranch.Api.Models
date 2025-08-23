using System.Text.RegularExpressions;
using Gay.Silverbranch.Api.Models.Entities.V1;

namespace Gay.Silverbranch.Api.Models.Extensions.V1;

public static class IEnumerableExtensionMethods
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="entries"></param>
    /// <param name="allowHidden"></param>
    /// <param name="allowDeleted"></param>
    /// <param name="pageIndex"></param>
    /// <param name="pageSize"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IEnumerable<T> GroupByAndFindLatest<T>(this IEnumerable<T> entries,
        bool allowHidden = false, bool allowDeleted = false,
        int pageIndex = 0, int pageSize = int.MaxValue) where T : BaseModel
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(pageSize,0,nameof(pageSize));
        List<T> page = new List<T>();
        int index = 0;
        var groups = entries.GroupBy(x => x.ReferenceIdentity);

        //  .   .   .
        //  0   .   .
        //  .   3   6
        //  1   .   7
        //  .   .   .
        //  .   .   .
        //  .   4   .
        //  2   5   8

        foreach (var group in groups)
        {
            if (page.Count >= pageSize) return page;
            if (index >= (pageIndex + 1) * pageSize) return page;

            var lastModified = group.Max(x => x.ModifiedOn);
            var model = group.SingleOrDefault(x => x.ModifiedOn == lastModified);

            if(index >= pageSize * pageIndex) page.Add(model!);
            index++;
        }
        return page;
    }

    public static IEnumerable<T> Replace<T>(this IEnumerable<T> entries, int id, T value) where T : BaseModel
    {
        int current = 0;
        foreach (var entry in entries)
        {
            yield return current == id ? value : entry;
            current++;
        }
    }

    public static IEnumerable<T> Replace<T>(this IEnumerable<T> entries, IEnumerable<T> values) where T : BaseModel
    {
        int current = 0;
        var ids = entries.Select(x=>x.EntryIdentity);
        foreach (var entry in entries)
        {
            yield return ids.Contains(current) ? values.Where(x=>x.EntryIdentity == current).First() : entry;
        }
    }

    public static IEnumerable<T> FilterByModifiedDate<T>(this IEnumerable<T> models, DateTime? before, DateTime? after) where T : BaseModel
    {
        if (after.HasValue && before.HasValue)
        {
            if (after.Value > before.Value) models = models.Where(x => x.ModifiedOn >= after.Value || x.ModifiedOn <= before.Value);
            else models = models.Where(x => x.ModifiedOn >= after.Value && x.ModifiedOn <= before.Value);
        }
        else if (after.HasValue) models = models.Where(x => x.ModifiedOn >= after.Value);
        else if (before.HasValue) models = models.Where(x => x.ModifiedOn <= before.Value);

        return models;
    }

    // public static IEnumerable<T> FilterByIdRange<T>(this IEnumerable<T> models, int? IDLowerBound, int? IDUpperBound) where T : BaseModel
    // {
    //     if (IDLowerBound.HasValue && IDUpperBound.HasValue)
    //     {
    //         if (IDLowerBound.Value > IDUpperBound.Value) models = models.Where(x => x.EntryIdentity >= IDLowerBound.Value || x.EntryIdentity <= IDUpperBound.Value);
    //         else models = models.Where(x => x.EntryIdentity >= IDLowerBound.Value && x.EntryIdentity <= IDUpperBound.Value);
    //     }
    //     else if (IDLowerBound.HasValue) models = models.Where(x => x.EntryIdentity >= IDLowerBound.Value);
    //     else if (IDUpperBound.HasValue) models = models.Where(x => x.EntryIdentity <= IDUpperBound.Value);
    //
    //     return models;
    // }

    public static IEnumerable<T> FilterName<T>(this IEnumerable<T> models, string searchTerm) where T : BaseModel
    {
        if (string.IsNullOrWhiteSpace(searchTerm)) return models;

        Regex regex = new Regex(searchTerm);
        models = models.Where(x => regex.IsMatch(x.Name));

        return models;
    }

    public static IEnumerable<T> FilterNotes<T>(this IEnumerable<T> models, string searchTerm) where T : BaseModel
    {
        if (string.IsNullOrWhiteSpace(searchTerm)) return models;

        Regex regex = new Regex(searchTerm);
        models = models.Where(x => regex.IsMatch(x.Notes));

        return models;
    }

    public static IEnumerable<T> Paginate<T>(this IEnumerable<T> models, int pageIndex = 0, int pageSize = int.MaxValue)
    {
        if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size cannot be less than 1");
        List<T> page = new List<T>();
        int index = 0;

        //  .   .   .
        //  0   .   .
        //  .   3   6
        //  1   .   7
        //  .   .   .
        //  .   .   .
        //  .   4   .
        //  2   5   8

        foreach (var model in models)
        {
            if (page.Count >= pageSize) return page;
            if (index >= (pageIndex + 1) * pageSize) return page;

            if (index >= pageSize * pageIndex) page.Add(model);
            index++;
        }
        return page;
    }
}
