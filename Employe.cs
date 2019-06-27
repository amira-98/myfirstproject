using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject
{
   public class Employe:Personne
    {
        private double salaire;
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public Employe(string nom, string prenom, DateTime d,double salaire):base(nom,prenom,d)
        {

            this.salaire = salaire;

        }
        public override string afficher()
        {
            return " le nom de cet employé est {0} " + this.Nom;
        }
    }
}
