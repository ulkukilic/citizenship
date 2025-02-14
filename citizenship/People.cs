using System;

namespace Citizenship
{
  
    class People
    {
        
        public string NameSurname { get; set; }
        public bool Alive { get; set; }

        // Parametresiz constructor (yapıcı metod) - varsayılan olarak kişi hayatta
        public People()
        {
            Alive = true; 
        }

        // Parametreli constructor - ad, soyad ve hayatta olup olmadığını belirler
        public People(string nameSurname, bool alive)
        {
            NameSurname = nameSurname; // Kişinin adı ve soyadını alır
            this.Alive = alive; // Kişinin hayatta olup olmadığını alır
        }

        // Statik bir metod - program başladığında 'Hello' mesajını döner
        public static string Hi()
        {
            return "Hello"; // Bu metod her çağrıldığında "Hello" döndürecektir
        }
    }
}
