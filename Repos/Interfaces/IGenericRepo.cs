namespace SchoolApi.Repos.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(int id);

    }
}
