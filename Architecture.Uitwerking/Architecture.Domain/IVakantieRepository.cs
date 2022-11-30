using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Domain
{
    public interface IVakantieRepository
    {
        List<Vakantie> GetAll();
        Vakantie GetOne(int Id);
        bool Delete(int Id);
        Vakantie Update(Vakantie vakantie);
        Vakantie Create(Vakantie vakantie);
    }
}
