using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Domain
{
    public class VakantieRepositoryDatabase : IVakantieRepository
    {

        readonly MyContext ctx;

        public VakantieRepositoryDatabase(MyContext context)
        {
            ctx = context;
        }


        public Vakantie Create(Vakantie vakantie)
        {
            ctx.VakantieDagen.Add(vakantie);
            ctx.SaveChanges();
            return vakantie;
        }

        public bool Delete(int Id)
        {
            var toRemove = ctx.VakantieDagen.Find(Id);
            if (toRemove != null)
            {
                ctx.VakantieDagen.Remove(toRemove);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Vakantie> GetAll()
                => ctx.VakantieDagen.ToList();

        public Vakantie GetOne(int Id)
                => ctx.VakantieDagen.FirstOrDefault(v => v.ID == Id);


        public Vakantie Update(Vakantie vakantie)
        {
            //var cur = ctx.VakantieDagen.FirstOrDefault(v => v.ID == vakantie.ID);
            //if (cur != null)
            //{
                ctx.Attach(vakantie);
                ctx.Update(vakantie);
                ctx.SaveChanges();
                return vakantie;
            //}
            //else
            //{
            //    return null;
            //}
        }
    }
}
