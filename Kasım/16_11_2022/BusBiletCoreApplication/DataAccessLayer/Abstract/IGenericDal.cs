using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    interface IGenericDal<T>
    {
        void insert(T entity);
        void delete(T entity);
        void update(T entity);
        List<T> list();

    }
}
