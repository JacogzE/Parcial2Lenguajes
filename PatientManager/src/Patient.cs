namespace PatientManager.src
{
    public class Patient
    {
        public int Id;
        public string Name;
        public int NumberOfSymptoms;
        public Patient Next;

        public Patient(int Id, string Name, int NumberOfSymptoms)
        {
            this.Id = Id;
            this.Name = Name;
            this.NumberOfSymptoms = NumberOfSymptoms;
            Next = null;
        }
    }

}