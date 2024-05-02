using construccion.Shared.Entities;
using Construccion.API.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construccion.API.Controllers
{
    [ApiController]
    [Route("/api/Presupuestos")]
    public class PresupuestoController : ControllerBase
    {
        private readonly DataContext _context;

        public PresupuestoController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Presupuestos.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var Presupuesto = await _context.Presupuestos.FirstOrDefaultAsync(x => x.id == id);

            if (Presupuesto == null)
            {


                return NotFound();

            }



            return Ok(Presupuesto);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Presupuesto presupuesto)
        {

            _context.Add(presupuesto);
            await _context.SaveChangesAsync();
            return Ok(presupuesto);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Presupuesto presupuesto)
        {

            _context.Update(presupuesto);
            await _context.SaveChangesAsync();
            return Ok(presupuesto);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.Presupuestos

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

