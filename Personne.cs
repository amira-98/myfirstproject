using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private DateTime date_de_naissance;
        private int num;
       public string Nom
        {
            get { return nom; }
            set { this.nom = value; }
        }
         public string Num
        {
            get { return num; }
            set { this.num = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { this.prenom = value; }
        }


        public DateTime DateNaiss
        {
            get { return date_de_naissance; }
            set { this.date_de_naissance = value; }
        }

        public Personne(string nom,string prenom, DateTime d,int num)
        {
            this.nom = nom;
            this.prenom = prenom;
            date_de_naissance = d;
            this.num=num;
        }
        public virtual string  afficher()
        {
            return (" le nom de cette personne est " + this.nom);
        }



    }
}
