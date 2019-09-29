using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP02.Models
{
    public class Container
    {
        public int Id { get; set; }

        public String Numero { get; set; }

        public String Tipo { get; set; }

        public int Tamanho { get; set; }

        public BL Bl { get; set; }

        public int BlId { get; set; }
    }
}