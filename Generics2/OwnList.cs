﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class OwnList<T> : List<T>
    {
        List<T> list = null;

        public OwnList()
        {
            list = new List<T>();
        }

    }
}
