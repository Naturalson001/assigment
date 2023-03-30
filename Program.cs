
namespace Parameters
{
    class Progress
    {




        static void Main(string[] args)

        {
            bool inputisvalid = false;
            while (!inputisvalid)
            {
                try
                {

                    System.Console.WriteLine(" A: Please Enter a number :");
                    var A = Convert.ToInt32(Console.ReadLine());


                    System.Console.WriteLine(" B: Please Enter a number :");
                    var B = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine(" C: Please Enter a number :");
                    var C = Convert.ToInt32(Console.ReadLine());

                    bool input = Inputs(A, B, C);
                    if (input)
                    {
                        System.Console.WriteLine("valid input");
                    }
                    else
                    {
                        System.Console.WriteLine("invalid input");
                    }
                    break;

                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine(" invalid input please enter a number");
                }
            }

            Console.Read();

        }

        static bool Inputs(int A, int B, int C)
        {
            if (C == 0 && A >= 14 && B >= 14)
            {


                return true;


            }
            else if (C > 0 && A > 2 * (C + 1) && B > 2 * (C + 1))
            {


                return true;
            }
            else
            {
                return false;



            }

        }
    }
}