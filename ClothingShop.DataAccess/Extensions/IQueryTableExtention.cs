using Microsoft.EntityFrameworkCore;

namespace ClothingShop.DataAccess.Extensions
{
    public static class IQueryableExtension
    {
        public static IQueryable<T> Tracking<T>(this IQueryable<T> query, bool trackChanges) where T : class
        {
            if (!trackChanges)
            {
                return EntityFrameworkQueryableExtensions.AsNoTracking(query);
            }

            return query;
        }
    }
}
