using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        private readonly AgricultureContext _context;

        public GenericRepository(AgricultureContext context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            var entities = _context.Set<T>().ToList();
            var properties = typeof(T).GetProperties();
            foreach (var entity in entities)
            {
                foreach (var property in properties)
                {
                    if (property.PropertyType == typeof(string))
                    {
                        var value = property.GetValue(entity);
                        if (value == null)
                        {
                            property.SetValue(entity, string.Empty);
                        }
                    }
                }
            }
            return entities;
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
