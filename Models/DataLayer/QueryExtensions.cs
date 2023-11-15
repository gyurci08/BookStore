using System.Linq.Expressions;



namespace BookStore.Models
{
    public static class QueryExtensions
    {


        //----- Attributes -----


        //----- Methods -----
            
        public static IQueryable<T> PageBy<T>(this IQueryable<T> items, int pageNumber, int pageSize)           // A T az interfész típus!
        {
            return items
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize);
        }
    }
}
