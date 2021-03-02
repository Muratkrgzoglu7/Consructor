using System;

namespace Consructor
{
	class Program
	{
		static void Main(string[] args)
		{
			Castomer castomer1 = new Castomer() {Id=7,FirstName="Murat",LastName="Karagöz",City="Elazığ" };
			Castomer castomer2 = new Castomer(2, "murat", "karagoz", "elaziz");

			Console.WriteLine(castomer2.FirstName);
		}
	}
	class Castomer
	{
		public Castomer()
		{

		}
		//default consructor
		public Castomer(int id,string firstName,string lastName,string city) //camelCase yazı tipi kullanılır parametrelerde.
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			City = city;
			Console.WriteLine("Yapıcı blok çalıştı");
		}
		public int Id { get; set; } //Özellik tutucularda PascalCase kullanılır
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
	}
}
