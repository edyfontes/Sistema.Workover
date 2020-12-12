using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Workover.Models
{
    public class Produto
    {
        // key referente a chave primária
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public  DateTime UltimaCompra { get; set; }
        public float Estoque { get; set; }

    }
}