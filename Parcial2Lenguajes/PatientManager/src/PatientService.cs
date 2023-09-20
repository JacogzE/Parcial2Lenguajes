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

        public void ReplaceHead(Patient NewHead)
        {
            NewHead.Next = head;
            head = NewHead;
        }

        public void InsertPatient(Patient patient)
        {
            Patient current = head;
            while(true)
            {
                Patient next = current is null? null : current.Next;

                if(head == null || (current == head && current.NumberOfSymptoms < patient.NumberOfSymptoms))
                {
                    ReplaceHead(patient);
                    break;
                }
                else if(current.NumberOfSymptoms > patient.NumberOfSymptoms && (next.NumberOfSymptoms < patient.NumberOfSymptoms || next is null))
                {
                    current.Next = patient;
                    patient.Next = next;
                    break;
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
                if(current == head)
                {
                    if(next is null)
                    {
                        if(current == patient)
                        {
                            ReplaceHead(null);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Patient not found");
                            break;
                        }
                    }
                }
                else
                {
                    if(next == patient)
                    {
                        current.Next = patient.Next;
                        break;
                    }
                    else
                    {
                        current = next;
                    }
                }
            }
        }
    }
}