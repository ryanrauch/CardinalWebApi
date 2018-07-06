using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CardinalWebApi.Models;
using CardinalWebApiLibrary.Models;
using CardinalWebApi.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace CardinalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabsController : ControllerBase
    {
        private readonly CardinalDbContext _context;
        //private readonly IHubContext<TabsHub> _hubContext;

        public TabsController(
            //IHubContext<TabsHub> hubContext,
            CardinalDbContext context)
        {
            _context = context;
            //_hubContext = hubContext;
        }

        // GET: api/Tabs
        [HttpGet]
        public IEnumerable<Tab> GetTabs()
        {
            return _context.Tabs;
        }

        // GET: api/Tabs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTab([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tab = await _context.Tabs.FindAsync(id);

            if (tab == null)
            {
                return NotFound();
            }

            return Ok(tab);
        }

        // PUT: api/Tabs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTab([FromRoute] Guid id, [FromBody] Tab tab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tab.TabId)
            {
                return BadRequest();
            }

            _context.Entry(tab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TabExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tabs
        [HttpPost]
        public async Task<IActionResult> PostTab([FromBody] Tab tab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tabs.Add(tab);
            await _context.SaveChangesAsync();

            //await _hubContext.Clients.All.SendAsync("PostTab", tab);

            return CreatedAtAction("GetTab", new { id = tab.TabId }, tab);
        }

        // DELETE: api/Tabs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTab([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tab = await _context.Tabs.FindAsync(id);
            if (tab == null)
            {
                return NotFound();
            }

            _context.Tabs.Remove(tab);
            await _context.SaveChangesAsync();

            return Ok(tab);
        }

        private bool TabExists(Guid id)
        {
            return _context.Tabs.Any(e => e.TabId == id);
        }
    }
}