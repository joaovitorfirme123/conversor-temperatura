using System;

class ConversaoDeUnidadesDeTemperatura{
    public double kelvin;
    public double celsius;
    public double fahrenheit;
    
    public double cParaf(double celsius, double fahrenheit){
        return fahrenheit = (celsius*1.8) + 32;
    }
     public double fParac(double celsius, double fahrenheit){
        return celsius = (fahrenheit - 32) / 1.8;
    }
    public double cParak(double celsius, double kelvin){
        this.kelvin = kelvin;
        return  celsius + 273;
    }
    
}


class Conversor {
  static void Main() {
      ConversaoDeUnidadesDeTemperatura conv = new ConversaoDeUnidadesDeTemperatura();
      int opc;
    Console.WriteLine("Qual o tipo de Conversão deseja realizar?");
    Console.WriteLine("1- celsius para fahrenheit/2- fahrenheit para celsius/3- celsius para kelvin");
    opc = Convert.ToInt32(Console.ReadLine());
    
    switch (opc){
        case 1: Console.WriteLine("Digite a temperatura em Celsius: ");
        conv.celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("a temperatura em fahrenheit é: "+ conv.cParaf(conv.celsius, conv.fahrenheit));
        break;
        
        case 2: Console.WriteLine("Digite a temperatura em Fahrenheit: ");
        conv.fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("a temperatura em celsius é: "+ conv.fParac(conv.celsius, conv.fahrenheit));
        break;
        
        case 3: Console.WriteLine("Digite a temperatura em celsius: ");
        conv.celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("a temperatura em celsius é: " + conv.cParak(conv.celsius, conv.kelvin));
        break;
        
        
    }
    
  }
}