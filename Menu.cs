using System;

namespace BusStation
{
    class Menu
    {
        
        /*
        ¡Bienvenido a la nevería!
        1) Tipo de cono
        2) Sabor de nieve
        3) Sencillo o doble
        4) Con o sin chocolate
        5) Toppings
        6) Pagar
        9) Salir
        Selecciona una opción:
        > 1
        [enter]
        */

        private const int MAIN_MENU_EXIT_OPTION = 7;
        private const int GO_BACK_OPTION = 7;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 6, 9});
        List<int> selectConeOptions = new List<int>(new int[] {1, 2, 9});

        private string tipoCono = "Regular";


        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("Iniciando sistema.....Bienvenido a BGTech interactive sistems MK IV");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() {
            System.Console.WriteLine("1) Ingreso De Camion");
            System.Console.WriteLine("2) Salida De Camion");
            System.Console.WriteLine("3) Exportar/Imprimir camiones");
            System.Console.WriteLine("4) Estadisticas");
            System.Console.WriteLine("5) Borrar Informacion");
            System.Console.WriteLine();
            System.Console.WriteLine("0) Pagar");
            
        }

        private void DisplayByeMessage() {
            System.Console.WriteLine("Shuting Down...Thank You For Using BGTech Prototype Software!");
        }

        private int RequestOption(List<int> validOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } catch (System.Exception) {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida, porfavor intenta de nuevo.");
                }
            }

            return userInputAsInt;
        }


        Queue queue = new Queue();

            System.Console.WriteLine(queue);

            // int? currentFront = queue.Front();
            // if (currentFront is int currentFrontInt)
            // {
            //     System.Console.WriteLine("It has a value!");
            // } else {
            //     System.Console.WriteLine("No value!");
            // }

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");

            queue.Enqueue(33);

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");

            queue.Enqueue(12);
            queue.Enqueue(45);
            queue.Enqueue(10);
            queue.Enqueue(7);
            queue.Enqueue(89);

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");


            System.Console.WriteLine($"queue.Dequeue() => {queue.Dequeue()}");
            System.Console.WriteLine($"queue.Dequeue() => {queue.Dequeue()}");

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");

        private void Pay() {
            //\n es salto de línea
            System.Console.WriteLine("Tu pedido es el siguiente:\n");
            System.Console.WriteLine($"tipoCono => {tipoCono}");

            System.Console.WriteLine("\n!Gracias por tu compra!");
        }
       
    }           //TODO: casi todo....
}