﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContatoWeb.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}