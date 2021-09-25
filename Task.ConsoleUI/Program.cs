using System;
using System.Collections.Generic;
using Task.Data;
using Task.Data.FactoryServices;
using Task.Data.FactoryServices.Interfaces;
using Task.Data.InitialData;
using Task.Data.Models;

namespace Task.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbFactory = new DbFactory(new TaskDbContext());

            // POST
            //var events = EventInitialData.DataSeed;
            //PostEventsToDb(dbFactory, events);

            // GET
            //var events = GetAllEvents(dbFactory);
            //foreach (var item in events)
            //{
            //    Console.WriteLine($"{item.Id} {item.Level}");
            //}

            // GET BY ID
            //var singleEvent = GetEventById(dbFactory, 2);
            //Console.WriteLine(singleEvent.Level);
        }

        public static void PostEventsToDb(IDbFactory dbFactory, IEnumerable<Event> events)
        {
            dbFactory.Post(events);
        }

        public static IEnumerable<Event> GetAllEvents(IDbFactory dbFactory)
        {
            return dbFactory.Get();
        }

        public static Event GetEventById(IDbFactory dbFactory, int id)
        {
            return dbFactory.GetById(id);
        }
    }
}
