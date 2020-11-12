using Architecture.BusinessLayer.Interfaces;
using Architecture.Domain;
using System;

namespace Architecture.BusinessLayer
{
    public class BeschikbaarheidService : IBeschikbaarheidService
    {
        public void ZetBeschikbaarheid(DateTime start, DateTime eind)
        {
            Console.WriteLine("Planing beschikbaarheid on " + start.ToString());
        }
    }
}
