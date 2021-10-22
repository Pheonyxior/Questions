using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définie le nombre de questions
            // Définie la note
            
            int NB_QUESTIONS = 5;
            int Note = 0;
            
                /* Avant de commencer la boucle avec Question n°"i", compare si "i" est supérieur aux nombre total de questions posées. 
                   A chaque itération de la boucle, augmente le numéro de la question de 1, et pose la prochaine question */
            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Questions n°" + (i+1) + "/" + NB_QUESTIONS);

                // Randomize une opération, attribue le résultat de a+b  à add et a*b à mul

                Random rand = new Random();
                int a = rand.Next(1, 51);
                int b = rand.Next(1, 11);                                           
                int op = rand.Next(0, 2);
                // if génère une addition et attribue la réponse d'une addition à "a", else fait la même pour une multiplication
                if (op == 0)
                {                    
                    Console.WriteLine(a.ToString() + " + " + b.ToString() + " = ");
                    a = a + b;
                }
                else
                {
                    Console.WriteLine(a.ToString() + " x " + b.ToString() + " = ");
                    a = a * b;
                }
                
                // Prend une réponse de l'utilisateur

                String Entrée = Console.ReadLine();
                int Réponse = int.Parse(Entrée);
                if (Réponse == a)
                {
                    Note++;
                    Console.WriteLine("bien ouej");
                }
                else
                {
                    Console.WriteLine("claqué au sol");
                }
                if (i == NB_QUESTIONS)
                {
                    Console.WriteLine("Note :" + Note + "/" + NB_QUESTIONS);
                }





            }
        }
    }
}
