using eTicketMVC.Data;
using eTicketMVC.Data.Services;
using eTicketMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMVC.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var actors = await _service.GetAll();
            return View(actors);
        }

        //Get: Actors/Get
        public IActionResult Create() 
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            _service.Add(actor);
            return RedirectToAction(nameof(Index));

        }

    }
}
