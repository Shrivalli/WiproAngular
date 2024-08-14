using FirstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly WiproSampleDbContext _context;

        public CourseController(WiproSampleDbContext context)
        {
            _context = context;
        }

        [HttpGet] //fetch the records from DB
        public async Task<ActionResult<List<Course>>> GetAllCourses()
        {
            return Ok(await _context.Courses.ToListAsync());
        }

        //Swagger is a documentation and testing tool for APIs. - postman, fiddler
        //HTTP verbs - create(insert), Delete, update, Read(select)
        //HTTPPost - insert, HTTPPut - update, HTTPDelete - delete, HTTPGET - select
        //*** Any method in API has to be annotated with any of these HTTP verbs

        [HttpPost]
        public async Task<ActionResult> AddCourse(Course c)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(c);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest("Sorry! validations are not satisfied");
            }
        }

        [HttpGet]
        [Route("GetCourseByID")]
        public async Task<ActionResult<Course>> GetCourseByID(int id)
        {
            var C=_context.Courses.Where(x=>x.Cid==id).SingleOrDefault();
            return Ok(C);
        }



        [HttpPut]
        public async Task<ActionResult> UpdateCourse(int id, Course c)
        {
            if(ModelState.IsValid) 
            {
                _context.Courses.Update(c);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCourse(int id)
        {
            if (ModelState.IsValid)
            {
                Course c = await _context.Courses.FindAsync(id);
                _context.Courses.Remove(c);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
