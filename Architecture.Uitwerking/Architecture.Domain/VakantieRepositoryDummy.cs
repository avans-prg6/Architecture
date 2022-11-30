using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Domain
{
    public class VakantieRepositoryDummy : IVakantieRepository
    {
        private List<Vakantie> _vakanties;
        
        public VakantieRepositoryDummy()
        {
            _vakanties = new List<Vakantie>()
            {
            new Vakantie(){ID=1, Omschrijving = "Weekje vrij",
                                Start=new DateTime(2022, 12, 05),
                                Einde=new DateTime(2022, 12, 08) },
            new Vakantie(){ID=2, Omschrijving = "Kerstvakantie",
                                Start=new DateTime(2022, 12, 26),
                                Einde=new DateTime(2023, 01, 06) },
            new Vakantie(){ID=3, Omschrijving = "Nieuwjaarsdag",
                                Start=new DateTime(2023, 01, 01),
                                Einde=new DateTime(2023, 01, 01) }
            };

        }
        public Vakantie Create(Vakantie vakantie)
        {
            _vakanties.Add(vakantie);
            return vakantie;
        }

        public bool Delete(int Id)
        {
            var toRemove = _vakanties.Find(v => v.ID == Id);
            if (toRemove != null)
            {
                _vakanties.Remove(toRemove);
                return true;
            }
            return false;
        }

        public List<Vakantie> GetAll()
        {
            return _vakanties;
        }

        public Vakantie GetOne(int Id) => _vakanties.FirstOrDefault(v => v.ID == Id);

        public Vakantie Update(Vakantie vakantie)
        {
            var cur = _vakanties.FirstOrDefault(v => v.ID == vakantie.ID);
            if (cur != null)
            {
                _vakanties.Remove(cur);
                _vakanties.Add(vakantie);

                return vakantie;
            }
            else
            {
                return null;
            }
        }
    }
}
