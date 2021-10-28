using PatientRepository.DataAccess;
using System.Collections.Generic;
using PatientRepository.Models;
using System.Linq;

namespace PatientRepository.DataAccess
{
    public class PatientsRepository : IPatientsRepository
    {
        PatientDBContext patientDBContext;
        public PatientsRepository(PatientDBContext _patientDBContext)
        {
            patientDBContext=_patientDBContext;
            
        }
        void IPatientsRepository.AddPatientRecord(Patients patient)
        {
            patientDBContext.Add(patient);
            patientDBContext.SaveChanges();// commit and save record in db
           
        }

        void IPatientsRepository.DeletePatientRecord(string id)
        {
            var entity =patientDBContext.patients.FirstOrDefault(t => t.id == id);  
            patientDBContext.patients.Remove(entity);  
            patientDBContext.SaveChanges();  
        }  
            

        List<Patients> IPatientsRepository.GetPatientRecords()
        {
           return patientDBContext.patients.ToList();  
        }

        Patients IPatientsRepository.GetPatientSingleRecord(string id)
        {
             return patientDBContext.patients.FirstOrDefault(t => t.id == id);
           
        }

        void IPatientsRepository.UpdatePatientRecord(Patients patient)
        {
            patientDBContext.patients.Update(patient);
            patientDBContext.SaveChanges();
        }
    }
}