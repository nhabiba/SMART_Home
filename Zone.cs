using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarthome
{
    internal class Zone
    {
        private int id;
        private String nom;
        private Tecnicien tecnicien;
        private int comp;

        public Zone( string nom, Tecnicien tecnicien)
        {
            this.id = ++comp;
            this.nom = nom;
            this.tecnicien = tecnicien;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        internal Tecnicien Tecnicien { get => tecnicien; set => tecnicien = value; }
    }
}
