using PatientManager.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Hospital hospital = new Hospital();

        Patient patient1 = new Patient(1, "a", 12);
        Patient patient2 = new Patient(2, "b", 11);
        Patient patient3 = new Patient(3, "c", 10);
        Patient patient4 = new Patient(4, "d", 9);
        Patient patient5 = new Patient(5, "e", 8);

        hospital.RecievePatient(patient4);
        hospital.RecievePatient(patient1);
        hospital.RecievePatient(patient3);
        hospital.RecievePatient(patient5);
        hospital.RecievePatient(patient2);

        hospital.StartShift();

    }
}