using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Le programme doit permettre de saisir un âge et d'afficher "majeur" si la personne a au
            ///moins 18 ans, "mineur" si elle n'a pas encore atteint cet âge.
            ///Dans le cas où la personne est mineure, il faudra aussi afficher un message qui précise dans
            <<<<<<< Ex5_refonte
            ///combien d'années la personne sera majeure.
           =======
            ///combien d'années la personne sera majeure
            >>>>>>> master
            /// 
            /// </summary>
            
            int age;

            Console.WriteLine("Choisissez votre âge: ");
            age = int.Parse(Console.ReadLine());

            <<<<<<< Ex5_refonte
            if (age >= 18)
            =======
            if (age > 17 || age == 18)
            >>>>>>> master
            {
                Console.WriteLine("Vous êtes majeur");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas majeur. Il vous manques " + (18 - age) + " pour accéder à la majoritée.");
                Console.ReadLine();
            }
            






        }
    }
}
