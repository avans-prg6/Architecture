using Architecture.BusinessLayer.Interfaces;
using System;

namespace Architecture.BusinessLayer
{
    public class VakantiedagenService : IVakantieService
    {
        public void PlanVakantie(DateTime start, DateTime einde, string omschrijving)
        {
            Console.WriteLine("Planing holiday on " + start.ToString());
        }
    }
}
