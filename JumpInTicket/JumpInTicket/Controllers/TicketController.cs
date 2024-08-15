using Infrastructure;
using JumpInTicket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JumpInTicket.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticket;

        public TicketController(ITicketService ticketService)
        {
            _ticket = ticketService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var model = new TicketListViewModel();
                model.List = await _ticket.List(461, "", "");

            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }


        public async Task<IActionResult> Details(string id)
        {
            return View();
        }
    }
}
