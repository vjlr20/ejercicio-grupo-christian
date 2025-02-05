﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace swagger_jwt.Models
{
    public class Entradas
    {

        [Key]
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }

        public int BodegaId { get; set; }

        public int UsuarioId { get; set; }

        public DateTime FechaEntrada { get; set; }

        public int Cantidad { get; set; }
        /**
         para evitar que se envie al front se usa JsonIgnore
         */
        [JsonIgnore]
        public float EntradaTotal { get; set; }

        public Producto producto { get; set; }
        public Bodega bodega { get; set; }
        public Usuario usuario { get; set; }
 
    }
}
