using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MerniceServiceAdapter());
            customerManager.Save(new Customer {Id = 1 , FirstName = "Fatih", LastName = "Ataç", DateOfBirth = new DateTime(2001,10,16), NationalityId = "28816736258" });
        }
    }
}
