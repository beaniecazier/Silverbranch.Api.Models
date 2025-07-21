using Gay.Silverbranch.Api.Models.Entities.V1;

namespace Gay.Silverbranch.Api.Models.Extensions.V1;

public static class IQueryableExtensionMethods
{
    public static IQueryable<T> GroupAndFindLatest<T>(this IQueryable<T> query)
        where T : BaseModel
    {
        // var group = query.GroupBy(m => m.CommonIdentity);
        // return group.Select(
        //     g=> g
        //         .OrderByDescending(m => m.ModifiedOn)
        //         .First());
        var grouped = query
            .GroupBy(x => x.CommonIdentity)
            .Select(g => new
            {
                CommonIdentity = g.Key,
                LatestModified = g.Max(x => x.ModifiedOn)
            });

        var result = query
            .Join(
                grouped,
                item => new { item.CommonIdentity, item.ModifiedOn },
                latest => new { latest.CommonIdentity, ModifiedOn = latest.LatestModified },
                (item, _) => item);

        return result;
    }
    
    public static IQueryable<T> SetSorting<T>(
        this IQueryable<T> query,
        string sortBy,
        bool ascending = true)
        where T : BaseModel
    {
        // query = options.SortDirection == SortOrder.Ascending
        //     ? query.OrderBy(e => EF.Property<object>(e, options.SortBy))
        //     : query.OrderByDescending(e => EF.Property<object>(e, options.SortBy));
        query = ascending
            ? query.OrderBy(_ => sortBy)
            : query.OrderByDescending(_ => sortBy);
        
        return query;
    }

    public static IQueryable<T> FilterByName<T>(
        this IQueryable<T> query,
        string nameSearchTerm)
        where T : BaseModel
    {
        if (string.IsNullOrWhiteSpace(nameSearchTerm))
            return query;
        return query.Where(m => m.Name.Contains(nameSearchTerm));
    }

    public static IQueryable<T> FilterByNotes<T>(
        this IQueryable<T> query,
        string notesSearchTerm)
        where T : BaseModel
    {
        if (string.IsNullOrWhiteSpace(notesSearchTerm))
            return query;
        return query.Where(m => m.Name.Contains(notesSearchTerm));
    }

    public static IQueryable<T> DisallowDeleted<T>(
        this IQueryable<T> query)
        where T : BaseModel
    {
        return query.Where(m => !m.IsDeleted);
    }

    public static IQueryable<T> DisallowHidden<T>(
        this IQueryable<T> query)
        where T : BaseModel
    {
        return query.Where(m => !m.IsHidden);
    }

    public static IQueryable<T> PullSpecificIds<T>(
        this IQueryable<T> query,
        IEnumerable<string> ids)
        where T : BaseModel
    {
        return query.Where(m => ids.Contains(m.CommonIdentity));
    }

    public static IQueryable<T> FilterByModifiedDates<T>(this IQueryable<T> query,
        DateTime modifiedBefore,
        DateTime modifiedAfter)
        where T : BaseModel
    {
        if (modifiedAfter >= modifiedBefore)
        {
            return query
                .Where(m => m.ModifiedOn <= modifiedBefore ||
                            m.ModifiedOn >= modifiedAfter);
        }
        return query
            .Where(m => m.ModifiedOn >= modifiedAfter &&
                        m.ModifiedOn <= modifiedBefore);
    }

    public static IQueryable<T> FilterModifiedBeforeDate<T>(
        this IQueryable<T> query,
        DateTime limit)
        where T : BaseModel
    {
        return query.Where(m => m.ModifiedOn <= limit);
    }

    public static IQueryable<T> FilterModifiedAfterDate<T>(
        this IQueryable<T> query,
        DateTime limit)
        where T : BaseModel
    {
        return query.Where(m => m.ModifiedOn >= limit);
    }
}