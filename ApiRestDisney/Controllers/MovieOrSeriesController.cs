using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRestDisney.DataAccess;
using ApiRestDisney.Models.DataModels;

namespace ApiRestDisney.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieOrSeriesController : ControllerBase
    {
        private readonly DisneyDbContext _context;

        public MovieOrSeriesController(DisneyDbContext context)
        {
            _context = context;
        }

        // GET: api/MovieOrSeries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieOrSeries>>> GetMovieOrSeries()
        {
          if (_context.MovieOrSeries == null)
          {
              return NotFound();
          }
            return await _context.MovieOrSeries.ToListAsync();
        }

        // GET: api/MovieOrSeries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieOrSeries>> GetMovieOrSeries(int id)
        {
          if (_context.MovieOrSeries == null)
          {
              return NotFound();
          }
            var movieOrSeries = await _context.MovieOrSeries.FindAsync(id);

            if (movieOrSeries == null)
            {
                return NotFound();
            }

            return movieOrSeries;
        }

        // PUT: api/MovieOrSeries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieOrSeries(int id, MovieOrSeries movieOrSeries)
        {
            if (id != movieOrSeries.Id)
            {
                return BadRequest();
            }

            _context.Entry(movieOrSeries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieOrSeriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MovieOrSeries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieOrSeries>> PostMovieOrSeries(MovieOrSeries movieOrSeries)
        {
          if (_context.MovieOrSeries == null)
          {
              return Problem("Entity set 'DisneyDbContext.MovieOrSeries'  is null.");
          }
            _context.MovieOrSeries.Add(movieOrSeries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieOrSeries", new { id = movieOrSeries.Id }, movieOrSeries);
        }

        // DELETE: api/MovieOrSeries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieOrSeries(int id)
        {
            if (_context.MovieOrSeries == null)
            {
                return NotFound();
            }
            var movieOrSeries = await _context.MovieOrSeries.FindAsync(id);
            if (movieOrSeries == null)
            {
                return NotFound();
            }

            _context.MovieOrSeries.Remove(movieOrSeries);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieOrSeriesExists(int id)
        {
            return (_context.MovieOrSeries?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
