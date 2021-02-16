using System;

namespace Banco_practica_Progr
{
    class Program
    {
        static void Main(string[] args)
        {
          int m1,m2,m3,m4,m5;
          m1=0; m2=0;m3=0;m4=0;m5=0;
          string salir;
          int Result;
          int resolt=0;
          int formato;
          int pass; string nombre;
          int a =0;
Console.Clear();
Console.WriteLine("Hola");

Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            
        
                Console.WriteLine("Ingrese el banco:");
                  Console.WriteLine("1- Banco FDP INVERSMENT");
          Console.WriteLine("2- Banco ADEMI");
              pass= int.Parse(Console.ReadLine());

switch(pass){
case 1:
Console.Clear();
Console.WriteLine("Banco FDPinverstment");
      
            do{ 
            Console.WriteLine("Bienvenid@ {0}", nombre); Console.WriteLine("Su saldo es de un monto de:" + a);
            
               Console.WriteLine("Marque 1, para depositar");
            Console.WriteLine("Marque 2, para retirar");
            formato=int.Parse(Console.ReadLine());

            switch(formato) {  
case 1:
 Console.WriteLine("Usted ha elegido deposito, cuanto desea depositar?");
Result=int.Parse(Console.ReadLine());
a= a+Result;
break;

case 2:
       
do{ 
Console.WriteLine("Usted ha elegido retiro, cuanto desea retirar?");
Console.WriteLine("Recuerde que el maximo de retiro es de 20,000 pesos");
resolt=int.Parse(Console.ReadLine());

Console.Clear();
}while(resolt>20000);


a = a-resolt;
Console.WriteLine("Su retiro es de un monto de:" + resolt);



if(resolt % 5 == 0){
    
m1= resolt / 1000;
resolt= resolt % 1000;
m2= resolt / 500;
resolt= resolt % 500;
m3= resolt / 200;
resolt= resolt % 200;
m4= resolt / 100;
resolt= resolt % 100;
m5= resolt / 50;
resolt= resolt % 50;

}


Console.WriteLine("Billetes de 1000 pesos:" +m1 );
Console.WriteLine("Billetes de 500 pesos: " + m2);
Console.WriteLine("Billetes de 200 pesos: " + m3);
Console.WriteLine("Billetes de 100 pesos: " + m4);
Console.WriteLine("Billetes de 50 pesos: " + m5);
Console.ReadLine();

break;

            }
         
 



    
    
      Console.WriteLine("¿Desea continuar usando el programa y volver al menu? SI/NO)");
                  salir = Console.ReadLine();
                  Console.Clear();
                } while (salir == "SI"|| salir == "si");
                Console.Clear();


            

            Console.ReadKey();



break;

case 2:
Console.Clear();
Console.WriteLine("Banco ADEMI");

      
            do{ 
            Console.WriteLine("Bienvenid@ {0}", nombre); Console.WriteLine("Su saldo es de un monto de:" + a);
            
               Console.WriteLine("Marque 1, para depositar");
            Console.WriteLine("Marque 2, para retirar");
            formato=int.Parse(Console.ReadLine());

            switch(formato) {  
case 1:
 Console.WriteLine("Usted ha elegido deposito, cuanto desea depositar?");
Result=int.Parse(Console.ReadLine());
a= a+Result;
break;

case 2:
       
do{ 
Console.WriteLine("Usted ha elegido retiro, cuanto desea retirar?");
Console.WriteLine("Recuerde que el maximo de retiro es de 10,000 pesos");
resolt=int.Parse(Console.ReadLine());
Console.Clear();
}while(resolt>10000);


a = a-resolt;
Console.WriteLine("Su retiro es de un monto de:" + resolt);



if(resolt % 5 == 0){
    
m1= resolt / 1000;
resolt= resolt % 1000;
m2= resolt / 500;
resolt= resolt % 500;
m3= resolt / 200;
resolt= resolt % 200;
m4= resolt / 100;
resolt= resolt % 100;
m5= resolt / 50;
resolt= resolt % 50;

}


Console.WriteLine("Billetes de 1000 pesos:" +m1 );
Console.WriteLine("Billetes de 500 pesos: " + m2);
Console.WriteLine("Billetes de 200 pesos: " + m3);
Console.WriteLine("Billetes de 100 pesos: " + m4);
Console.WriteLine("Billetes de 50 pesos: " + m5);
Console.ReadLine();

break;

            }
         
 



    
    
      Console.WriteLine("¿Desea continuar usando el programa y volver al menu? SI/NO)");
                  salir = Console.ReadLine();
                  Console.Clear();
                } while (salir == "SI"|| salir == "si");
                Console.Clear();


            

            Console.ReadKey();


break;

}



        
        }
        }
}