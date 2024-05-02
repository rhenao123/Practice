using construccion.Shared.Entities;
using Construccion.API.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construccion.API.Controllers
{
    [ApiController]
    [Route("/api/AssignmentsTeams")]
    public class AssigTeamsController : ControllerBase
    {
        private readonly DataContext _context;

        public AssigTeamsController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.AssignmentsTeamss.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var AssignmentsTeams = await _context.AssignmentsTeamss.FirstOrDefaultAsync(x => x.Id == id);

            if (AssignmentsTeams == null)
            {


                return NotFound();

            }



            return Ok(AssignmentsTeams);


        }





        [HttpPost]
        public async Task<ActionResult> Post(AssignmentsTeams assignmentsTeams)
        {

            _context.Add(assignmentsTeams);
            await _context.SaveChangesAsync();
            return Ok(assignmentsTeams);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(AssignmentsTeams assignmentsTeams)
        {

            _context.Update(assignmentsTeams);
            await _context.SaveChangesAsync();
            return Ok(assignmentsTeams);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.AssignmentsTeamss

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

