﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej5
{
    public interface Entregable
    {
        void Entregar();
        void Devolver();
        bool isEntregado();
        int compareTo(Object a);
    }
}
