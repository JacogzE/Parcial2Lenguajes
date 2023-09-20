namespace PatientManager.src
{
    public class PatientService
    {
        private Patient head;

        public PatientService(Patient first)
        {
            head = first;
        }

        public Patient GetHead()
        {
            return head;
        }

        private Patient Create(int id, string name, int numberOfSymptoms)
        {
            return new Patient(id, name, numberOfSymptoms);
        }

        private void ReplaceHead(Patient NewHead)
        {
            NewHead.Next = head;
            head = NewHead;
        }

        private void RemoveHead(Patient NewHead)
        {
            head = NewHead;
        }

        public void InsertPatient(int id, string name, int numberOfSymptoms)
        {
            Patient patient = Create(id, name, numberOfSymptoms);
            Patient current = head;
            while(true)
            {
                Patient next = current is null? null : current.Next;
                if(current is null)
                {
                    ReplaceHead(patient);
                    break;
                }
                else if(next is not null)
                {
                    if(current.NumberOfSymptoms >= patient.NumberOfSymptoms && next.NumberOfSymptoms < patient.NumberOfSymptoms)
                    {
                        current.Next = patient;
                        patient.Next = next;
                        break;
                    }
                }
                else
                {
                    if(current.NumberOfSymptoms >= patient.NumberOfSymptoms)
                    {
                        current.Next = patient;
                        break;
                    }
                }
                current = next;
            }
        }

        public void DischargePatient(Patient patient)
        {
            Patient current = head;
            while(true)
            {
                Patient next = current is null? null : current.Next;
                if(patient == head)
                {
                    RemoveHead(next);
                    break;
                }
                else if(next is not null)
                {
                    if(patient == next)
                    {
                        current.Next = next.Next;
                        break;
                    }
                }
                current = next;
            }
        }
    }
}