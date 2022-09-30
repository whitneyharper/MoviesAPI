using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _db;

        public MoviesController(MovieDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            if (_db.Movies == null)
            {
                return NotFound();
            }
            return await _db.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            if (_db.Movies == null)
            {
                return NotFound();
            }
            var movie = await _db.Movies.FindAsync(id);

            if(movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }

        [HttpPut]
        public async Task<ActionResult> EditMovie(int id, Movie movie)
        {
            
            if(id != movie?.Id)
            {
                return BadRequest();
            }

            _db.Entry(movie).State = EntityState.Modified;

            try 
            {
                await _db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) 
            {
                var exist = await _db.Movies.FindAsync(id);


                if (exist == null)
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
    }
}
