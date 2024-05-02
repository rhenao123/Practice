using construccion.Shared.Entities;
using Construccion.API.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construccion.API.Controllers
{
    [ApiController]
    [Route("/api/AssigmentMats")]
    public class AssignmentsMatsController : ControllerBase
    {
        private readonly DataContext _context;

        public AssignmentsMatsController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.AssigmentMatss.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var AssigmentMats = await _context.AssigmentMatss.FirstOrDefaultAsync(x => x.Id == id);

            if (AssigmentMats == null)
            {


                return NotFound();

            }



            return Ok(AssigmentMats);


        }





        [HttpPost]
        public async Task<ActionResult> Post(AssigmentMats assigmentMats)
        {

            _context.Add(assigmentMats);
            await _context.SaveChangesAsync();
            return Ok(assigmentMats);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(AssigmentMats assigmentMats)
        {

            _context.Update(assigmentMats);
            await _context.SaveChangesAsync();
            return Ok(assigmentMats);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.AssigmentMatss

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

