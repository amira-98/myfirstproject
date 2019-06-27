using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject
{
    class Chef:Employe
    {

        private string service; 
        public string Service
        {
            get { return service; }
            set { service = value; }
        }

        public Chef(double salaire,string nom,string prenom,DateTime d ,string service,int num) : base(nom,prenom,d,salaire,num)
        {
            this.service = service;
        }
        public override string afficher()
        {
            return " le nom de ce chef est " + this.Nom;
        }
    }
}
