using System.Collections.Generic;

namespace CSharpAssignment
{
    public interface IRepository<T> where T : class
    {
        //1.void Add(T item)
        public void Add(T item);

        //2.void Remove(T item)
        public void Remove(T item);

        //3.Void Save()
        public void Save();

        //4.IEnumerable<T> GetAll()
        public IEnumerable<T> GetAll();

        //5.T GetById(int id)
        public Entity GetById(int id);
    }
}