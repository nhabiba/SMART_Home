using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarthome
{
    internal class Utilisateur
    {
        protected int id;
        protected String nom;
        protected String prenom;
        protected String username;
        protected String password;
        public int comp;




        public Utilisateur(string nom, string prenom, string username, string password)
        {
            this.Id = ++comp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Username = username;
            this.Password = password;
        }

        protected int Id { get => id; set => id = value; }
        protected string Nom { get => nom; set => nom = value; }
        protected string Prenom { get => prenom; set => prenom = value; }
        protected string Username { get => username; set => username = value; }
        protected string Password { get => password; set => password = value; }

    }



}
