using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définie le nombre de questions
            // Définie la note (un point gagnée par réponses justes)
                        
            int NB_QUESTIONS = 5;
            int Note = 0;            

            /* Avant de commencer la boucle avec Question n°"i", compare si "i" est supérieur aux nombre total de questions posées. Si "i" est supérieur, casse la boucle.
               A chaque itération de la boucle, augmente le numéro de la question de 1, et affiche "Question n°"i" */
            int i = 0;
            for (; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Questions n°" + (i+1) + "/" + NB_QUESTIONS);

                // Randomize des nombres pour "a" et "b", déclare "c", lance un "pile ou face" pour décider quelle sera l'opération

                Random rand = new Random();
                int a = rand.Next(1, 51);
                int b = rand.Next(2, 11);
                int c = 0;
                int op = rand.Next(0, 2);
                // if génère une addition entre "a" et "b" et attribue la réponse à "c", else fait la même pour une multiplication
                if (op == 0)
                {                    
                    Console.WriteLine(a.ToString() + " + " + b.ToString() + " = ");
                    c = a + b;
                }
                else
                {
                    Console.WriteLine(a.ToString() + " x " + b.ToString() + " = ");
                    c = a * b;
                }

                // Prend une réponse de l'utilisateur et vérifie s'il s'agit d'un nombre entier
                                
                    String Entrée = Console.ReadLine();
                    int Réponse = 0;
                    bool vérif = int.TryParse(Entrée, out Réponse);
                    if (vérif == false)

                    {
                        Console.WriteLine("Tu dois donner un nombre mdr");
                    }
                
                // Vérifie si la réponse est juste (= à c). Si oui, rajoute un point à la note.
                if (Réponse == c)
                {
                    Note++;                    
                }                
            }
            //  Quand la boucle for se casse ("i" atteint le nombre de questions max) donne la note finale.
                       
                Console.WriteLine("Note :" + Note + "/" + NB_QUESTIONS);
                if (Note == 0)
                {
                    Console.WriteLine("T'es claqué(e) au sol!");
                }
                else if (Note <= NB_QUESTIONS / 2)
                {
                    Console.WriteLine("C'est ok.");
                }
                else if (Note == NB_QUESTIONS)
                {
                    Console.WriteLine("POG!");
                }
                else
                {
                    Console.WriteLine("Bueno!");
                }
            
        }
    }
}
