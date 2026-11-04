namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        int arrowNumber = 5;
        int deerLife = 3;
        int successfulShot = 0;
        string bilan = "Chasse réussie !";

        do
        {
            Console.WriteLine("Nombre de flèches restantes : " + arrowNumber);
            Console.WriteLine("Résultat du tir (rate/touche) : ");  
            string result = Console.ReadLine();
            if (result == "touche")
            {
                Console.WriteLine("Bien joué ! Le cerf est touché !\n");
                deerLife--;
                successfulShot++;
                arrowNumber--;
            }
            else if (result == "rate")
            {
                Console.WriteLine("Raté ! Le cerf a esquivé !\n");
                arrowNumber--;
            }
            else
            {
                Console.WriteLine("Réponse invalide, veuillez réindiquer votre choix\n");
            }
                
        } while (deerLife >= 1 && arrowNumber >= 1);

        if (deerLife == 0)
        {
            Console.WriteLine("Le cerf est abbatu !\n");
        }
        else
        {
            Console.WriteLine("Vous êtes à court de flèches !\n");
            bilan = "Chasse ratée !";
        }

        Console.WriteLine("=== BILAN DE CHASSE ===");
        Console.WriteLine("Tirs réussis : " + successfulShot);
        Console.WriteLine("Flèches restantes : " + arrowNumber);
        Console.WriteLine("Résultat : " + bilan);
    }
}