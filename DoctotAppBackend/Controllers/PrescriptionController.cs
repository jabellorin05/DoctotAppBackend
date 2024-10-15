using DoctotAppBackend.Entities;
using DoctotAppBackend.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoctotAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase

    {
        private RepositoryContext _repositoryContext;

        public PrescriptionController(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }




        // GET: api/<PrescriptionController>
        [HttpGet("PatientID/{idP}")]
        public List<Prescription> GetPrescriptionByIdPatient(string idP)
        {
          
            
            
            return _repositoryContext.Prescriptions.Where(item => item.PatientId.ToString() == idP).ToList(); 
        }

        // GET api/<PrescriptionController>/5
        [HttpGet("{id}")]
        public Prescription Get(int id)
        {
          var prescObj =_repositoryContext.Prescriptions.FirstOrDefault(item =>item.PatientId == id);
            
            return prescObj;
        }

        // POST api/<PrescriptionController>
        [HttpPost]
        public void Post([FromBody] Prescription value)
        {
            if (_repositoryContext != null) {


                _repositoryContext.Prescriptions.Add(value);
                _repositoryContext.SaveChanges();
            }


        }

        // PUT api/<PrescriptionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Prescription value)
        {
           var prescObj = _repositoryContext.Prescriptions.FirstOrDefault(item=>item.PatientId==id);

            if (prescObj != null)
            {
                prescObj.Medication=value.Medication; 
                    
                 prescObj.Date = value.Date;
                _repositoryContext.Entry(prescObj).State = EntityState.Modified;
                _repositoryContext.SaveChanges();

            }

        }

        // DELETE api/<PrescriptionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            if (_repositoryContext!=null)
            {
               var prescObj = _repositoryContext.Prescriptions.FirstOrDefault(item=>item.PatientId==id);

                if (prescObj != null) 
                    _repositoryContext.Prescriptions.Remove(prescObj);


            }


        }
    }
}
