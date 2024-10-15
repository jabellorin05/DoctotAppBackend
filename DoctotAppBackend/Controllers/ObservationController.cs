using Microsoft.AspNetCore.Mvc;
using DoctotAppBackend.Entities;
using DoctotAppBackend.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoctotAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ObservationController : ControllerBase
    {
        private RepositoryContext? observationContext;

        public ObservationController(RepositoryContext? observationContext)
        {

            this.observationContext = observationContext;



        }

        // GET: api/<DiagnosticsController>
        [HttpGet("PatientID/{pId}")]
        public List< Observation>? GetDiagnosticByPatientId(string pId)
        {
            if (observationContext != null)
            {
                var diagnisticList = observationContext.Observations?.Where(x => x.PatientId.ToString() == pId).ToList();
                return diagnisticList;
            }

         
          

            return null;
        }

        // GET api/<DiagnosticsController>/5
        [HttpGet("id/{id}")]
        public Observation? Get(int id)
        {
            var diagnosticItem = observationContext?.Observations?.Find(id);

            if (diagnosticItem != null)
            {


                return diagnosticItem;
            }


            return null;
        }

        // POST api/<DiagnosticsController>
        [HttpPost]
        public void Post([FromBody] Observation dItem)
        {
            Console.WriteLine("Observation received: " + JsonConvert.SerializeObject(dItem));
            observationContext?.Observations?.Add(dItem);

            observationContext?.SaveChanges();

        }

        // PUT api/<DiagnosticsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Observation newDiagnostic)
        {

            var diag= observationContext?.Observations?.FirstOrDefault(item => item.PatientId == id);

            if (diag == null)
            {
               return NotFound();

            }
            diag.Notes = newDiagnostic.Notes;
            diag.Date = newDiagnostic.Date;


            observationContext.Entry(diag).State = EntityState.Modified;
            observationContext.SaveChanges();
            return Ok(diag);


        }

        // DELETE api/<DiagnosticsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var diagnosticObj = observationContext?.Observations?.Find(id);

            if (diagnosticObj == null)
            {
                return NotFound();
            }

            


            observationContext.Remove(diagnosticObj); 
            
            observationContext.SaveChanges();

            return Ok(diagnosticObj);
        

        }
    }
}
