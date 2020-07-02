using System;

namespace BusStation
{
    class Menu
    {
        

        private const int MAIN_MENU_EXIT_OPTION = 7;
        private const int GO_BACK_OPTION = 7;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 6, 9});
        List<int> selectConeOptions = new List<int>(new int[] {1, 2, 9});

        private string tipoCono = "Regular";


        private void DisplayWelcomeMessage() 
        {
            System.Console.WriteLine("Iniciando sistema.....Bienvenido a BGTech interactive sistems MK IV");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() 
        {
            System.Console.WriteLine("1) Ingreso De Camion");
            System.Console.WriteLine("2) Salida De Camion");
            System.Console.WriteLine("3) Exportar/Imprimir camiones");
            System.Console.WriteLine("4) Estadisticas");
            System.Console.WriteLine("5) Borrar Informacion");
            
            
        }

        private void DisplayByeMessage() {
            System.Console.WriteLine("Shuting Down...Thank You For Using BGTech Prototype Software!");
        }

        private int RequestOption(List<int> validOptions) 
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try 
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida, porfavor intenta de nuevo.");
                }
            }

            return userInputAsInt;
        }

       
    }
}