using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO7
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Bank_Account   // Création de la class Bank_Account
    {
        //déclaration des attributs
        public string owner;    // Titulaire
        public string currency; // Devise
        public double final_settlement;                 // Solde tout compte
        // Méthode pour le crédit. Une méthode qui a comme paramètre amount qui retourne du vide
        public void Tocredit(double amount)  
        {
            final_settlement = final_settlement + amount;  // Crédit de amount
        }
        // Méthode pour le débit. Une méthode qui a comme paramètre amount qui retourne du vide
        public void Todebit(double amount)
        {
            final_settlement = final_settlement - amount; // Débit de amount
        }
    }
 }

