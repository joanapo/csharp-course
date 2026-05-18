using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    internal interface IEntity
    {
        int Id { get; }
    }
    
    internal class Repository<T> where T : IEntity
    {
        private List<T> values = new List<T>();

        public void Add(T entity)
        {
            values.Add(entity);
        }
    }
}
