﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class Carrinho
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int valor { get; set; }
    }
}