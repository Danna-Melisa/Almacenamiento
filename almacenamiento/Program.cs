using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region utilizando el constructor por defecto 
            //instanciar , crear un objeto a partir de la class
            Person person1 = new Person();
            person1.IdPerson = 123456789;
            person1.Firstname = "Paco";

            Console.WriteLine("Cedula -->" + person1.IdPerson);
            Console.WriteLine("Nombre -->" + person1.Firstname);
            Console.ReadKey();
            #endregion
        }
        static void Main(string[] args)
        {
            #region utilizando el constructor por defecto 
            //instanciar , crear un objeto a partir de la class
            Person person1 = new Person(1235, "Sara", "Gomez", 18, 1.60, "Femenino", "300300300300", "saragomez@.com");
            Person person2 = new Person(1235, "Felipe", "Serbia", 20, 1.80, "Masculino", "300300300300", "felipe.serbia@.com");
            Person person3 = new Person(1235, "Melisa", "Acevedo", 17, 1.55, "Femenino", "300300300300", "melisaacevedo@.com");

            person1.ViewData();
            person2.ViewData();
            person3.ViewData();

            person1.UpdateGender("No binario");


            Console.ReadKey();

            #endregion

            Console.WriteLine("Desea actualizar datos? presione 1.Si  2.No ");
            string input = Console.ReadLine();

            int opcion;

            while (!int.TryParse(input, out opcion) || (opcion != 1 && opcion != 2))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese 1 para Si o 2 para No.");
                input = Console.ReadLine();
            }

            if break == 2;


        }
    }

    public void ModificarDato()
    {

        if ()


    }

}
