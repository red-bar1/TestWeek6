﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Assicurazione.Repository
{
    public interface IRepository<T>
    {
        public T Create(T item);
        public ICollection<T> GetAll();
    }
}
