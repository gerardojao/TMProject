using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly AppDbContext context;
        public ProjectController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<ProjectController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.user.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult Get(int id)
        {
            try
            {
                var users = context.user.FirstOrDefault(u => u.id == id);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ProjectController>
        [HttpPost]
        public ActionResult Post([FromBody] User users)
        {
            try
            {
                context.user.Add(users);
                context.SaveChanges();
                return CreatedAtRoute("GetUser", new { id = users.id }, users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User users)
        {
            try
            {
                if (users.id == id)
                {
                    context.Entry(users).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetUser", new { id = users.id }, users);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var users = context.user.FirstOrDefault(u => u.id == id);
                if (users != null)
                {
                    context.user.Remove(users);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
