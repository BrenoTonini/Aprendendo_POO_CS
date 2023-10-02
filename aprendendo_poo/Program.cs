using System;
class Program{
   static void Main(string[] args){
        Caneta DoManoelGomes = new Caneta("Azul", 0.7f, 20);

        DoManoelGomes.infoCaneta();
        DoManoelGomes.escrever(18);
        DoManoelGomes.infoCaneta();
        DoManoelGomes.recarregar(50);
        DoManoelGomes.infoCaneta();

    }
}