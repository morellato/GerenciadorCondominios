﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Evento
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public int EventoId { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data { get; set; }

        public string UsuarioId { get; set; }

        public Usuario Usuario  { get; set; }
    }
}
