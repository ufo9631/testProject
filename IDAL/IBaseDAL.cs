﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDAL<T> where T :class
    {
        T GetModelById(int id);
        IList<T> GetList();

    }
}
