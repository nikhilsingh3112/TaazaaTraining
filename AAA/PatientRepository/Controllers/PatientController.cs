using Microsoft.AspNetCore.Mvc;
using PatientRepository.Models;
using PatientRepository.DataAccess;
using System.Linq;
namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PatientController:ControllerBase
    {
        IPatientsRepository ipatientsRepository;
        
        public PatientController(IPatientsRepository _IpatientRepository)
        {
            ipatientsRepository=_IpatientRepository;
            
        }
        [HttpPost("Add")]
        public IActionResult CreatePatient(Patients patients)
        {
           ipatientsRepository.AddPatientRecord(patients);
           return Ok("record added");
        } 

        [HttpPut("Update")]

        public IActionResult UpdatePatientRecord(Patients patients)  
        { 
            if(ModelState.IsValid)
            {
                ipatientsRepository.UpdatePatientRecord(patients);
                return Ok("Record is updated");
            }
            return BadRequest();          
        }
        
        
        [HttpGet("{id}")]  
        public  PatientDetails(string id)  
        {  
            return ipatientsRepository.GetPatientSingleRecord(id);  
        } 

         [HttpPut]  
        public IActionResult Edit(Patients patients)  
        {  
            if (ModelState.IsValid)  
            {  
                ipatientsRepository.UpdatePatientRecord(patients);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data =ipatientsRepository.GetPatientSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            ipatientsRepository.DeletePatientRecord(id);  
            return Ok();  
        }   

    }
}