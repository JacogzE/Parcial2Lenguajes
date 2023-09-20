using PatientManager.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        
        hospital.RecievePatient(4, "d", 9);
        hospital.RecievePatient(1, "a", 12);
        hospital.RecievePatient(3, "c", 10);
        hospital.RecievePatient(5, "e", 8);
        hospital.RecievePatient(2, "b", 11);

        hospital.StartShift();

    }
}