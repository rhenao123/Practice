using construccion.Shared.Entities;
using Construccion.API.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construccion.API.Controllers
{
    [ApiController]
    [Route("/api/EquiConss")]
    public class EquiConsController:ControllerBase
    {
        private readonly DataContext _context;

        public EquiConsController(DataContext context)
        {
            _context = context; 
        }
        
        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.EquiConss.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var EquiCons = await _context.EquiConss.FirstOrDefaultAsync(x => x.id == id);

            if (EquiCons == null)
            {


                return NotFound();

            }



            return Ok(EquiCons);


        }





        [HttpPost]
        public async Task<ActionResult> Post(EquiCons EquiCons)
        {

            _context.Add(EquiCons);
            await _context.SaveChangesAsync();
            return Ok(EquiCons);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(EquiCons equiCons)
        {

            _context.Update(equiCons);
            await _context.SaveChangesAsync();
            return Ok(equiCons);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.EquiConss

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

