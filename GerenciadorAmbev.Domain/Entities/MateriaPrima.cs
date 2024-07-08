﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAmbev.Domain.Entities
{
    internal class MateriaPrima
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }        
        public UnidadeMedida UnidadeMedida { get; set; }
        public bool Ativo { get; set; }        

    }
}
