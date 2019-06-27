
using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject
{
    class Directeur:Chef
    {
        private string societe; 
        public string Societe
        {
            get { return societe; }
            set { societe = value; }
        }
        public Directeur(string nom, string prenom , DateTime d, double salaire, string service , string societe,int num):base(salaire, nom,prenom,d,service,num)
        { this.societe = societe; }
        public override string afficher()
        {
            return " le nom de ce directeur est " + this.Nom;
        }




    }
}
