using System;

namespace ohm{
    class Calculator{
            
        private string Rest;
        private string Voltage;
        private double Corrent;

        public string SetRest
        {
            set{Rest = value;}
        }
        public string SetVoltage
        {
            set{Voltage = value;}
        }
        public double SetCorrent
        {
            set{Corrent = value;}
        }
        public string getRest
        {
            get{return Rest;}
        }
        public string getVoltage
        {
            get{return Voltage;}
        }
        public double getCorrent
        {
            get{return Corrent;}
        }

        public double VerifyIdentificator(string valor)
        {
                int lenght = valor.Length - 1;
                if (valor[lenght] == 'K')
                {
                    double number = double.Parse(valor.Substring(0,lenght));
                    double result = number * Math.Pow(10,3);
                    return result;    
                }
                else if (valor[lenght] == 'M')
                {
                    double number = double.Parse(valor.Substring(0, lenght));
                    double result = number * Math.Pow(10,6);
                    return result;
                }
                else if (valor[lenght] == 'm')
                {
                    double number = double.Parse(valor.Substring(0, lenght));
                    double result = number * Math.Pow(10, -3);
                    return result;
                }
                else if (valor[lenght] == 'u')
                {
                    double number = double.Parse(valor.Substring(0, lenght));
                    double result = number * Math.Pow(10, -6);
                    return result;
                }
                else{
                    double result = double.Parse(valor); 
                    return result;
                }
        }
        public double CalculateCorrent()
        {
            return VerifyIdentificator(Voltage) / VerifyIdentificator(Rest);
        }  
    }
}
            