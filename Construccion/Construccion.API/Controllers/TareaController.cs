
using Construccion.API.Data;
using construccion.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Construccion.API.Controllers
{


    [ApiController]
    [Route("/api/tarea")]
    public class TareaController: ControllerBase
    {

        private readonly DataContext _context;

        public TareaController(DataContext context)
        {



            _context = context;
        }

        // Método Get- LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Tareas.ToListAsync());


        }



        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var tarea = await _context.Tareas.FirstOrDefaultAsync(x => x.Id == id);

            if (tarea == null)
            {


                return NotFound();

            }



            return Ok(tarea);
        }






        [HttpPost]
        public async Task<ActionResult> Post(Tarea tarea)
        {

            _context.Add(tarea);
            await _context.SaveChangesAsync();
            return Ok(tarea);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Tarea tarea)
        {

            _context.Update(tarea);
            await _context.SaveChangesAsync();
            return Ok(tarea);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.Tareas

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (Filasafectadas == 0)
            {


                return NotFound();

            }


            return NoContent();

        }
    }

}