using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParkAPI.Models;

namespace ParkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ParkAPIContext _db;
        public LocationsController(ParkAPIContext db)
        {
            _db = db;
        }

        // GET api/locations
        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get(string city, string state, string country, string region)
        {
            var query = _db.Locations.AsQueryable();

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }

            if (state != null)
            {
                query = query.Where(entry => entry.State == state);
            }

            if (country != null)
            {
                query = query.Where(entry => entry.Country == country);
            }

            if (region != null)
            {
                query = query.Where(entry => entry.Region == region);
            }

            return query.ToList();
        }

        //POST api/locations
        [HttpPost]
        public void Post([FromBody] Location location)
        {
            _db.Locations.Add(location);
            _db.SaveChanges();
        }

        // GET api/locations/5
        [HttpGet("{id}")]
        public ActionResult <Location> Get(int id)
        {
            return _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
        }

        //PUT api/locations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Location location)
        {
            location.LocationId = id;
            _db.Entry(location).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/locations/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var locationToDelete = _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
            _db.Locations.Remove(locationToDelete);
            _db.SaveChanges();
        }
    }
}