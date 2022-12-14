using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarthome
{
    internal class Membre : Utilisateur
    {
        public Membre(string nom, string prenom, string username, string password) : base(nom, prenom, username, password)
        {
        }
    }
}
