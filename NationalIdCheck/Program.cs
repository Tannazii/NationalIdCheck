namespace NationalIdCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            do
            {
                NationalId idAp = new NationalId();

                Console.WriteLine("ENTER NationalId :");
                idAp.Id = Console.ReadLine();


                IdValidator service = new IdValidator();

                isValid = service.Validate(idAp);
                Console.WriteLine($" NationalId is {isValid} ");

            }
            while ( isValid == false);
        }
    }
}
