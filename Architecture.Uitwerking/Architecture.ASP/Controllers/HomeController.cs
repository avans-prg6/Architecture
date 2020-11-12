using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Architecture.ASP.Models;
using Architecture.BusinessLayer;
using Architecture.BusinessLayer.Interfaces;

namespace Architecture.ASP.Controllers
{
    public class HomeController : Controller
    {
        private IBeschikbaarheidService _beschikbaarheid;
        private IVakantieService _vakantie;


        public HomeController(IBeschikbaarheidService beschikbaarheid, IVakantieService vakantie)
        {
            _beschikbaarheid = beschikbaarheid;
            _vakantie = vakantie;
        }

        public IActionResult Index()
        {
            return View(new FormViewModel());
        }

        [HttpPost]
        public IActionResult PostForm(FormViewModel form)
        {
            //Validatie, kan natuurlijk slimmer dan dit!
            if (form.IsHoliday)
            {
                if (form.Omschrijving == null)
                {
                    ModelState.AddModelError("Omschrijving", "Omschrijving is verplicht als het om een vakantie gaat");
                }

                if (form.IsRepeat)
                {
                    ModelState.AddModelError("IsRepeat", "Vakanties kunnen niet herhaald worden");
                }
            }
            else
            {
                if(form.IsRepeat && !form.AantalKeer.HasValue)
                {
                    ModelState.AddModelError("AantalKeer", "AantalKeer moet ingevuld worden als IsRepeat aangevinkt is");
                }
            }

            //dit doen we natuurlijk pas na het toevoegen van deze custom errors
            if (!ModelState.IsValid)
            {
                // The user didn't select any value => redisplay the form
                return View("Index", form);
            }

            if (form.IsHoliday)
            {
                _vakantie.PlanVakantie(form.Start.Value, form.Einde.Value, form.Omschrijving);
            }
            else
            {
                //Dit hadden we ook in de service kunnen doen
                for (int i = 0; i < form.AantalKeer; i++)
                {
                    _beschikbaarheid.ZetBeschikbaarheid(form.Start.Value.AddDays(i * 7), form.Einde.Value.AddDays(i * 7));
                }
            }



            return View("Response", form);
        }
    }
}
