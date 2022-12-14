using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarthome
{
    internal class Equipement
    {
        private int id;
        private String nom;
        private Boolean etat;
        private Zone zone;
        private Utilisateur user;

        public Equipement(int id, string nom, bool etat, Zone zone, Utilisateur user)
        {
            this.id = id;
            this.nom = nom;
            this.etat = etat;
            this.zone = zone;
            this.user = user;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public bool Etat { get => etat; set => etat = value; }
        internal Zone Zone { get => zone; set => zone = value; }
        internal Utilisateur User { get => user; set => user = value; }
    }
