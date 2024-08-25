using System;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region utilizando el constructor por defecto 
            //instanciar , crear un objeto a partir de la class

            string[] emailsPerson1 = {"SaraGomez@gmail.com" , "fresita453@gmail.com", "sara.gomez@gmail.com", "sarita564@gmail.com"};

            Person person1 = new Person(1235, "Sara", "Gomez", 18, 1.60, "Femenino", "300300300300", emailsPerson1);

            person1.ViewData();

            Console.Write("Desea cambiar algun dato? ");
            string validarCambioDato = Console.ReadLine();

            while (validarCambioDato.ToLower().Trim() == "si")
            {

                Console.WriteLine("Que atributo desea cambiar? " +
                    "\n1.firtsname" +
                    "\n2.lastname" +
                    "\n3.age" +
                    "\n4.height" +
                    "\n5.gender" +
                    "\n6.phone" +
                    "\n7.email");
                int cambiarDato = Convert.ToInt32(Console.ReadLine());
                ModificarDato(person1, cambiarDato);

                Console.WriteLine("DATO CAMBIADO CON EXITO");
                person1.ViewData();

                Console.Write("Desea modificar otro atributo? ");
                validarCambioDato = Console.ReadLine();

            }

            Console.WriteLine("Fin programa");

            Console.ReadKey();

            #endregion


        }

        public static void ModificarDato(Person person, int cambiarDato)
        {
            string updateAtributteString;
            int updateAtributteInt;
            double updateAtributteDouble;

            switch (cambiarDato)
            {
                case 1:
                    Console.WriteLine("modifica el atributo \"firtsname\" ");
                    updateAtributteString = Console.ReadLine();

                    person.Firstname = updateAtributteString;
                    break;

                case 2:
                    Console.WriteLine("modifica el atributo \"lastname\" ");
                    updateAtributteString = Console.ReadLine();

                    person.Lastname = updateAtributteString;
                    break;

                case 3:
                    Console.WriteLine("modifica el atributo \"age\" ");
                    updateAtributteInt = Convert.ToInt32(Console.ReadLine());

                    person.Age = updateAtributteInt;
                    break;

                case 4:
                    Console.WriteLine("modifica el atributo \"heigth\" ");
                    updateAtributteDouble = Convert.ToDouble(Console.ReadLine());

                    person.Heigth = updateAtributteDouble;
                    break;

                case 5:
                    Console.WriteLine("modifica el atributo \"gender\" ");
                    updateAtributteString = Console.ReadLine();

                    person.Gender = updateAtributteString;
                    break;

                case 6:
                    Console.WriteLine("modifica el atributo \"phone\" ");
                    updateAtributteString = Console.ReadLine();

                    person.Phone = updateAtributteString;
                    break;

                case 7:
                    Console.WriteLine("cual correo quieres cambiar");

                    person.ViewEmails();

                    int emailsPosition = Convert.ToInt32(Console.ReadLine());

                    while (emailsPosition > person.Email.Length - 1 && emailsPosition < 0)
                    {

                        Console.WriteLine("Ese no existe, escoge los que estan en esta lista para cambiar");

                        person.ViewEmails();

                        emailsPosition = Convert.ToInt32(Console.ReadLine());

                    }

                    Console.WriteLine("Ingresa el nuevo correo");
                    updateAtributteString = Console.ReadLine();

                    person.Email[emailsPosition] = updateAtributteString.ToLower().Trim();
                    
                    break;

                default:
                    Console.WriteLine("Ese atributo no existe");
                    break;


            }


        }
    }

}
