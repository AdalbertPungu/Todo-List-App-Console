// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace ConsoleApp1 {
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> taches = new List<string>();
            
            while (true)
            {
                Console.WriteLine("\n=====================\n\tMenu :\n=====================\n");
                Console.WriteLine("1. Ajouter une tâche");
                Console.WriteLine("2. Afficher les tâches");
                Console.WriteLine("3. Quitter");

                Console.Write("\nQuel est votre choix : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.Write("Entrez une nouvelle tâche : ");
                        string nouvelleTache = Console.ReadLine();
                        taches.Add(nouvelleTache);
                        break;
                    case "2":
                        Console.WriteLine("\n\nListe des tâches :\n----------------\n");
                        for (int i = 0; i < taches.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {taches[i]}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\noups Au revoir !\nVous venez de quitter le programme\n");
                        return;
                    default:
                        Console.WriteLine("\nChoix invalide. Veuillez choisir une option valide sur le menu.\n");
                        break;
                }
            }

        }
    }
}

// using System;
// using System.Collections.Generic;

// namespace ConsoleApp1 {
//     class Program {
//         public static void Main(string[] args) {
//             List<string> taches = new List<string>();

//             while (true) {
//                 Console.WriteLine("\n=====================\n\tMenu :\n=====================\n");
//                 Console.WriteLine("1. Ajouter une tâche");
//                 Console.WriteLine("2. Afficher les tâches");
//                 Console.WriteLine("3. Modifier une tâche");
//                 Console.WriteLine("4. Supprimer une tâche");
//                 Console.WriteLine("5. Quitter");

//                 Console.Write("\nQuel est votre choix : ");
//                 string choix = Console.ReadLine();

//                 switch (choix) {
//                     case "1":
//                         // Option 1 : Ajouter une tâche
//                         Console.Write("Entrez une nouvelle tâche : ");
//                         string nouvelleTache = Console.ReadLine();
//                         taches.Add(nouvelleTache);
//                         break;
//                     case "2":
//                         // Option 2 : Afficher les tâches
//                         Console.WriteLine("\n\nListe des tâches :\n----------------\n");
//                         for (int i = 0; i < taches.Count; i++) {
//                             Console.WriteLine($"{i + 1}. {taches[i]}");
//                         }
//                         break;
//                     case "3":
//                         // Option 3 : Modifier une tâche
//                         Console.Write("Entrez le numéro de la tâche à modifier : ");
//                         int indiceModification;
//                         if (int.TryParse(Console.ReadLine(), out indiceModification) && indiceModification > 0 && indiceModification <= taches.Count) {
//                             // Vérifie si l'indice est valide
//                             Console.Write($"Entrez la nouvelle valeur pour la tâche {indiceModification} : ");
//                             taches[indiceModification - 1] = Console.ReadLine();
//                         } else {
//                             Console.WriteLine("Indice invalide. Veuillez entrer un indice valide.");
//                         }
//                         break;
//                     case "4":
//                         // Option 4 : Supprimer une tâche
//                         Console.Write("Entrez le numéro de la tâche à supprimer : ");
//                         int indiceSuppression;
//                         if (int.TryParse(Console.ReadLine(), out indiceSuppression) && indiceSuppression > 0 && indiceSuppression <= taches.Count) {
//                             // Vérifie si l'indice est valide
//                             taches.RemoveAt(indiceSuppression - 1);
//                         } else {
//                             Console.WriteLine("Indice invalide. Veuillez entrer un indice valide.");
//                         }
//                         break;
//                     case "5":
//                         // Option 5 : Quitter le programme
//                         Console.WriteLine("\nAu revoir ! Vous avez quitté le programme.\n");
//                         return;
//                     default:
//                         // Choix invalide
//                         Console.WriteLine("\nChoix invalide. Veuillez choisir une option valide dans le menu.\n");
//                         break;
//                 }
//             }
//         }
//     }
// }
