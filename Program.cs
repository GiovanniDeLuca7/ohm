using System;

namespace ohm{kl
     class Inter
     {
        public static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator();
            Console.WriteLine("Insira o valor da resistência");
            calculator.SetRest = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de voltagem:");
            calculator.SetVoltage= float.Parse(Console.ReadLine());
            Console.WriteLine("O valor da corrente é:");
            Console.WriteLine(calculator.CalculateCorrent() + " ohms");
            // Retorna o valor da resistência
            Console.WriteLine(calculator.getRest);
            // Retorna o valor da voltagem
            Console.WriteLine(calculator.getVoltage);
        }
    }
}