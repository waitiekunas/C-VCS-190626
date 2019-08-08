using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TestCompany
{
    class Company : IPrintMe
    {
        private Human _boss;
        private readonly string _name;
        private List<Client> clientList = new List<Client>();
        private List<Worker> workerList = new List<Worker>();
        private Pet pet;

        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public Company(Human human, string name)
        {
            _boss = human;
            _name = name;
        }
        public void FireWorker(Worker worker)
        {
            workerList.Remove(worker);
        }
        public void HireWorker(Worker worker)
        {
            workerList.Add(worker);
        }
        public void PrintAllClients()
        {
            foreach (Client client in clientList)
            {
                 client.PrintInfo();
                Console.WriteLine(client.ClientId());
            }
        }

        public void PrintAllWorkers()
        {
            foreach (Worker worker in workerList)
            {
                worker.PrintInfo();
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Boss:");
            _boss.PrintInfo();
            Console.WriteLine($"Company name: {_name}");
        }

        public Pet OfficePet
        {
            get { return pet; }
            set { pet = value; }

        }
    }
}
