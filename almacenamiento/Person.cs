using System;

namespace Clases
{
    internal class Person
    {
        private int idPerson;
        private string firstname;
        private string lastname;
        private int age;
        private double heigth;
        private string gender;
        private string phone;
        private string email;

        #region constructores 
        // Constructor por defecto
        public Person() { }

        public Person(int idPerson, string firstname, string lastname, int age, double heigth, string gender, string phone, string email)
        {
            this.IdPerson = idPerson;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Heigth = heigth;
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;
        }
        // Crear encapsulamiento 
        public int IdPerson { get => idPerson; set => idPerson = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
        public double Heigth { get => heigth; set => heigth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        public void ViewData()
        {
            Console.WriteLine("                             ");
            Console.WriteLine("  *** DATOS DE LA PERSONA ***");
            Console.WriteLine("                             ");
            Console.WriteLine($"\tIdentificacion-> {idPerson}");
            Console.WriteLine($"\tNombre --------> {firstname}");
            Console.WriteLine($"\tApellido-------> {lastname}");
            Console.WriteLine($"\tEdad-----------> {age}");
            Console.WriteLine($"\tEstatura-------> {heigth:F2}");
            Console.WriteLine($"\tGenero---------> {gender}");
            Console.WriteLine($"\tCelular--------> {phone}");
            Console.WriteLine($"\tCorreo---------> {email}");

        }

    }
}