using System;

namespace ohm
{
     class Inter
     {
        public static void Main(string[] args)
        {   
            Calculator calculator = new Calculator();
            try{
                Console.WriteLine("Insira o valor da resistência");
                calculator.SetRest = Console.ReadLine();
                Console.WriteLine("Insira o valor de voltagem:");
                calculator.SetVoltage= Console.ReadLine();
                Console.WriteLine("O valor da corrente é:");
                Console.WriteLine(calculator.CalculateCorrent() + " ohms");
            }catch(Exception){
                Console.WriteLine("---------------------------");
                Console.WriteLine("Entre com um valor valido.");
                Console.ReadLine();
            }
        }
    }
}