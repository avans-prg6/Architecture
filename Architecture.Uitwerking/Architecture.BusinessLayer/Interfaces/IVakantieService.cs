using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.BusinessLayer.Interfaces
{
    public interface IVakantieService
    {
        void PlanVakantie(DateTime start, DateTime einde, String omschrijving);
    }
}
