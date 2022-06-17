using eTicketMVC.Data;
using eTicketMVC.Data.Services;
using eTicketMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMVC.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var producers = await _service.GetAllAsync();
            return View(producers);
        }

        //GET: producers/details/id

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //Get: producers/create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Bio")]Producer producer)
        {
            if (ModelState.IsValid)
            {
               await _service.AddAsync(producer);
               return RedirectToAction("Index");
            }
            return View(producer);
        }

        //Get: producers/edit
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL, FullName, Bio")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                if(id == producer.Id)
                {
                    await _service.UpdateAsync(id, producer);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(producer);
                }
                
            }
            return View(producer);
        }
        //Get: producers/delete
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _service.GetByIdAsync(id);
            if (producer == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
