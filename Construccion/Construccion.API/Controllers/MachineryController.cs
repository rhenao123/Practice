
using construccion.Shared.Entities;
using Construccion.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Construccion.API.Controllers
{


    [ApiController]
    [Route("/api/machinery")]
    public class MachineryController : ControllerBase
    {

        private readonly DataContext _context;

        public MachineryController(DataContext context)
        {



            _context = context;
        }

        // Método Get- LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Machineries.ToListAsync());


        }



        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var machinery = await _context.Machineries.FirstOrDefaultAsync(x => x.id == id);

            if (machinery == null)
            {


                return NotFound();

            }



            return Ok(machinery);
        }






        [HttpPost]
        public async Task<ActionResult> Post(machinery  Machinery)
        {

            _context.Add(Machinery);
            await _context.SaveChangesAsync();
            return Ok(Machinery);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(machinery Machinery)
        {

            _context.Update(Machinery);
            await _context.SaveChangesAsync();
            return Ok(Machinery);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.Machineries

                .Where(x => x.id == id)
                .ExecuteDeleteAsync();

            if (Filasafectadas == 0)
            {


                return NotFound();

            }


            return NoContent();

        }
    }

}