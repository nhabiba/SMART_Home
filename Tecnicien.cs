using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarthome
{
    internal class Tecnicien : Utilisateur
    {
        public Tecnicien(string nom, string prenom, string username, string password) : base(nom, prenom, username, password)
        {
        }
    }
}
