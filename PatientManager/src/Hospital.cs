namespace PatientManager.src
{
    public class Hospital
    {
        PatientService patients;
        public Hospital()
        {
            patients = new PatientService(null);
        }
        private void Operate(Patient patient)
        {
            Console.WriteLine("Operating " + patient.Name);
            Medicate(patient);
        }

        private void Medicate(Patient patient)
        {
            Console.WriteLine("Medicating " + patient.Name);
            Discharge(patient);
        }

        private void Discharge(Patient patient)
        {
            Console.WriteLine(patient.Name + " Discharged");
            patients.DischargePatient(patient);
        }

        private void AttendCritical(Patient patient)
        {
            Operate(patient);
        }

        private void AttendUrgent(Patient patient)
        {
            Medicate(patient);
        }

        private void Attend(Patient patient)
        {
            if(patient.NumberOfSymptoms >= 10)
            {
                AttendCritical(patient);
            }
            else
            {
                AttendUrgent(patient);
            }
        }

        public void RecievePatient(Patient patient)
        {
            patients.InsertPatient(patient);
        }

        public void StartShift()
        {
            Patient current = patients.GetHead();

            while(true)
            {
                Patient next = current.Next;
                if(next is not null)
                {
                    Attend(current);
                    current = next;
                }
                else
                {
                    Attend(current);
                    break;
                }
            }
        }
    }
}