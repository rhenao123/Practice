
using construccion.Shared.Entities;
using Construccion.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Construccion.API.Controllers
{


    [ApiController]
    [Route("/api/ProjectConstru")]
    public class ProjectConstruControllers : ControllerBase
    {

        private readonly DataContext _context;

        public ProjectConstruControllers(DataContext context)
        {



            _context = context;
        }

        // Método Get- LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.ProjectConstrs.ToListAsync());


        }



        // Método Get- por Id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {



            var projectConstr = await _context.ProjectConstrs.FirstOrDefaultAsync(x => x.id == id);

            if (projectConstr == null)
            {


                return NotFound();

            }



            return Ok(projectConstr);
        }






        [HttpPost]
        public async Task<ActionResult> Post(ProjectConstr projectConstr)
        {

            _context.Add(projectConstr);
            await _context.SaveChangesAsync();
            return Ok(projectConstr);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(ProjectConstr projectConstr)
        {

            _context.Update(projectConstr);
            await _context.SaveChangesAsync();
            return Ok(projectConstr);



        }


        //Médoro eliminar registro
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.ProjectConstrs

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