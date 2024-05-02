using construccion.Shared.Entities;
using Construccion.API.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Construccion.API.Controllers
{
    [ApiController]
    [Route("/api/Materialess")]
    public class MaterialesController : ControllerBase
    {
        private readonly DataContext _context;

        public MaterialesController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Materialess.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var Materiales = await _context.Materialess.FirstOrDefaultAsync(x => x.id == id);

            if (Materiales == null)
            {


                return NotFound();

            }



            return Ok(Materiales);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Materiales materiales)
        {

            _context.Add(materiales);
            await _context.SaveChangesAsync();
            return Ok(materiales);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Materiales materiales)
        {

            _context.Update(materiales);
            await _context.SaveChangesAsync();
            return Ok(materiales);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.Materialess

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

