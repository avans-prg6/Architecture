using Architecture.BusinessLayer.Interfaces;
using Architecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Architecture.BusinessLayer
{
    public class VakantiedagenService : IVakantieService
    {
        private IVakantieRepository _repo;
        //private MyContext _context;
        public VakantiedagenService(IVakantieRepository repo)
        //public VakantiedagenService(MyContext context)
        {
            _repo = repo;   
            //_context = context;
        }
        public Vakantie PlanVakantie(DateTime start, DateTime einde, string omschrijving)
        {
            //zoek naar vakantie met overlap
            var overlap = _repo.GetAll().Where(v => (start.Date <= v.Einde.Date && start.Date >= v.Start.Date)
               || (einde.Date <= v.Einde.Date && einde.Date >= v.Start.Date)).FirstOrDefault();
            //var overlap = _repo.VakantieDagen.Where(v => (start.Date <= v.Einde.Date && start.Date >= v.Start.Date)
            //    || (einde.Date <= v.Einde.Date && einde.Date >= v.Start.Date)).FirstOrDefault();

            if (overlap != null)
                return null;

            var vakantie = new Vakantie()
            {
                Start = start,
                Einde = einde,
                Omschrijving = omschrijving
            };

            _repo.Create(vakantie);
            //_context.VakantieDagen.Add(vakantie);

            //_context.SaveChanges();
            return vakantie;
        }
    }
}
