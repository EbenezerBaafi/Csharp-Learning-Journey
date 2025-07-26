namespace ExceptionTut

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repeat = 1;
            int response = 1;

            while (response == 1)
            {

                try
                {

                    Console.WriteLine($"Hello {repeat} ");
                    Console.Write("Repeat ? 1: Yes, 0: No Ans");
                    response = Convert.ToInt32(Console.ReadLine());

                    if (response != 1 && response != 0)
                    {
                        throw new ValidInputException();
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine($"*****FormatException Occured ********\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception details -> {e.ToString()} ");
                }

                finally
                {
                    repeat++;

                }
            }
        }
    }
}
