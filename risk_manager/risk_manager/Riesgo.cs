using System;
using LiteDB;

namespace risk_manager
{
    public class Riesgo
    {
        public int Id { get; set; }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string Responsable { get; set; }
        public string Problema { get; set; }

        public int C { get; set; }
        public int E { get; set; }
        public int P { get; set; }
        public int A { get; set; }
        public int V { get; set; }
        public int F { get; set; }

        public double R { get; set; }
        public string Nivel { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}

