using ConsoleApp1.TestCompany;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human boss = new Human("Vytautas");
            Company company = new Company(boss, "My Company");

            company.OfficePet = new Dog("Doggo");

            company.HireWorker(new Worker("Zilvinas", 460));
            company.HireWorker(new Worker("Tomas", 500));

            company.AddClient(new Client("Client1"));
            company.AddClient(new Client("Client2"));

            company.PrintInfo();
            company.PrintAllClients();
        }
    }
}
