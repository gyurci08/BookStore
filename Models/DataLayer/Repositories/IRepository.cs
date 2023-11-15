using System.Numerics;


namespace BookStore.Models
{
    public interface IRepository<T> where T : class             // Ez egy generikus ( T )
    {


        //----- Attributes ----------------------------------------
        IEnumerable<T> List(QueryOptions<T> options);           // Megszámlálható elemű lista
        int Count { get; }                                      // Read-only property








        //----- Methods ----------------------------------------

        // Overloaded get() method
        T? Get(QueryOptions<T> options);
        T? Get(int id);
        T? Get(string id);

        void Insert(T entity);
        void Update(T entity);
        void Save();
        void Delete(T entity);


    }
}
