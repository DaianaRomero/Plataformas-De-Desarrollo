﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public class Recurso
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoIdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}