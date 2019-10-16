using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormPPE
{
    public class Eleve
    {
        private string prenom ;
        private string nom  ;
        private string login;
        private string password;
      
        public Eleve(string prenom,string nom,string login,string password)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.login = login;
            this.password = password;
   
        }
      
        private static char[] randomCharsMin = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static char[] randomCharsMaj = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private static char[] randomCharsNom = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private static char[] randomCharsCar = new char[] { '&', '~', '#', '-', '_', '^', '@', '!', '?', '/' };
        private static readonly Random rand = new Random();

       
        public string GetPrenom
        {
            get
            {
                return this.prenom;
            }
        }
        public string GetNom
        {
            get
            {
                return this.nom;
            }
               
        }

        public static string GetPasswordAleatoire()

        {
            
            char[] password = new char[9];

            for (int i = 0; i < 1; ++i)
            {
                password[i] = randomCharsMaj[rand.Next(0, randomCharsMaj.Length)];
            }
            for (int i = 1; i < 7; ++i)
            {
                password[i] = randomCharsMin[rand.Next(0, randomCharsMin.Length)];
            }
            for (int i = 7; i < 8; ++i)
            {
                password[i] = randomCharsNom[rand.Next(0, randomCharsNom.Length)];
            }
            for (int i = 8; i < 9; ++i)
            {
                password[i] = randomCharsCar[rand.Next(0, randomCharsCar.Length)];
            }

            return new string(password);

        }
        public static string GetPasswordConstruit(string prenom, string nom)
        {
            char[] prenomCoupe;
            prenomCoupe = prenom.ToCharArray(0, prenom.Length);
            char[] password = new char[] { '0' };
            password[0] = prenomCoupe[0];
            string passwordDebut = new string(password);
            string passwordFinal = passwordDebut + nom;
            return passwordFinal;
        }
        public string NewPassWord(PassWordType.PassWordT passWordType)
        {
            string password = "";
            if (passWordType == PassWordType.PassWordT.Aléatoire)
            {
                password = Eleve.GetPasswordAleatoire();
            }
            if (passWordType == PassWordType.PassWordT.Construit)
            {
                password = Eleve.GetPasswordConstruit(prenom,nom);
            }
            return password;
        }
    }
}
