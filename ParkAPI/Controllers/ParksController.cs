using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParkFinder.Models;

namespace ParkFinder.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParkAPIContext _db;
        public ParksController(ParkAPIContext db)
        {
            _db = db;
        }

        //GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string parkName, string fees, string alerts, bool hasHikingTrails, bool isCurrentlyOpen)
        {
            var query = _db.Parks.AsQueryable();

            if (parkName != null)
            {
                query = query.Where(entry => entry.ParkName == parkName);
            }

            if (fees != null)
            {
                query = query.Where(entry => entry.Fees == fees);
            }

            if (alerts != null)
            {
                query = query.Where(entry => entry.Alerts == alerts);
            }

            if (hasHikingTrails == true)
            {
                query = query.Where(entry => entry.HasHikingTrails == hasHikingTrails);
            }

            if (isCurrentlyOpen == true)
            {
                query = query.Where(entry => entry.IsCurrentlyOpen == isCurrentlyOpen);
            }

            return query.ToList();
        }

        //POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        //GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        //PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}