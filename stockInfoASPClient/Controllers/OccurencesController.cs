using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using stockInfoASPClient.Data;
using stockInfoASPClient.Models;

namespace stockInfoASPClient.Controllers
{
    public class OccurencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OccurencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Occurences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Occurence.ToListAsync());
        }
        
    }
}
