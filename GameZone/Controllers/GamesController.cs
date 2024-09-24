using GameZone.Models;
using GameZone.Models.viewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly AppDbcontext _context;

        public GamesController(AppDbcontext context)
        {
            _context = context;
        }
   
        
    }
}

