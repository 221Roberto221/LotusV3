using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotusV3.Models
{
    [Table ("Citas")]
    public class Citas
    {
        [PrimaryKey]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Caracteristicas { get; set; }
    }
}
