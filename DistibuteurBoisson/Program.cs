using DistibuteurBoisson;
using System.ComponentModel.Design;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        CoffeeMachine machine = new CoffeeMachine();
        bool loop = true;
        List<string> listNameRecipe = new List<string>
        {
            "Espresso",
            "Lait",
            "Capuccino",
            "Chocolat Chaud",
            "Café au lait",
            "Mokacinno",
            "Thé"
        };
        int i = 0;

        while (loop){
            try
            {
                Menu();
                string x = Console.ReadLine();

                if (int.Parse(x) < 1 || int.Parse(x) > 7) // Exception si l'utilisateur ne choisi pas un chiffre ente 1 et 7
                {
                    throw new ArgumentOutOfRangeException("Selection must be between 1 and 7.");
                }

                x = listNameRecipe[int.Parse(x) - 1];
                Console.WriteLine(x);
                Console.WriteLine("voici le prix d un " + x + " " + machine.GetPrice(x)); //On affiche le nom de la boisson choisi ainsi que son prix
                Console.WriteLine();
            }
            catch (Exception ex) // On catch l'exception
            {
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }


        }
    }

    public static void Menu() 
    {
            Console.WriteLine("Veuillez choisir votre boisson :");

            Console.WriteLine("1 - Espresso");
            Console.WriteLine("2 - Lait");
            Console.WriteLine("3 - Capuccino");
            Console.WriteLine("4 - Chocolat Chaud");
            Console.WriteLine("5 - Café au Lait");
            Console.WriteLine("6 - Makocinno");
            Console.WriteLine("7 - Thé");
    }
}