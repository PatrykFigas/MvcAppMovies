using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAppMovies.Data;
using MvcAppMovies.Models;

namespace MvcAppMovies.Controllers
{
    // Kontroler odpowiedzialny za operacje CRUD na filmach
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        // Wstrzyknięcie kontekstu bazy danych
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        // Wyświetlenie listy filmów
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        // Formularz dodawania nowego filmu
        public IActionResult Add() => View();

        // Obsługa dodawania filmu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Movie movie)
        {
            if (!ModelState.IsValid) 
                return View(movie);

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            // Komunikat po poprawnym zapisaniu filmu
            TempData["Success"] = "Film zostal dodany.";

            return RedirectToAction(nameof(Index));
        }

        // Formularz edycji filmu
        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        // Obsługa edycji filmu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Movie movie)
        {
            if (!ModelState.IsValid) return View(movie);

            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();

            // Komunikat po poprawnej edycji filmu
            TempData["Success"] = "Zmiany zostaly zapisane.";

            return RedirectToAction(nameof(Index));
        }

        // Usunięcie filmu
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NotFound();

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            // Komunikat po usunięciu filmu
            TempData["Success"] = "Film zostal usuniety z listy.";

            return RedirectToAction(nameof(Index));
        }

        // Wyświetlenie szczegółów filmu
        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
                return NotFound();

            return View(movie);
        }

    }
}
