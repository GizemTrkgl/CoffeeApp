using CoffeeApp.Abstract;
using CoffeeApp.Adapters;
using CoffeeApp.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
			customerManager.Save(new Entities.Customer { DateOfBirth = new System.DateTime(1995, 2, 2), FirstName = "Gizem", LastName = "Türkoğlu", NationalityId = "1234512345" });
			Console.ReadLine();
		}
	}
}
