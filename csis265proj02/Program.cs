using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj02
{
    public class Program
    {
        public static void Main()
        {
            double length = 0;
            double width = 0;
            double acreage = 0;
            double sideLengthOfSquare = 0;
            const int SQ_FT_PER_ACRE = 43560;
            int programControl = 0;

            do
            {
                System.Console.WriteLine("Action Menu:");
                System.Console.WriteLine("(1) Enter land length/width and calculate acreage");
                System.Console.WriteLine("(2) Enter desired acreage and calculate land length/width");
                System.Console.WriteLine("(3) Quit program" + '\n');

                programControl = Convert.ToInt32(System.Console.ReadLine());

                switch(programControl)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Enter the width of your parcel of land (in feet): ");
                            width = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine("Enter the length of your parcel of land (in feet): ");
                            length = Convert.ToDouble(System.Console.ReadLine());

                            acreage = (width * length) / SQ_FT_PER_ACRE;

                            System.Console.WriteLine("The acreage of your land is: " + acreage + '\n');
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Enter the acreage of your parcel of land: ");
                            acreage = Convert.ToDouble(System.Console.ReadLine());

                            sideLengthOfSquare = Math.Sqrt(acreage * SQ_FT_PER_ACRE);

                            System.Console.WriteLine("The length and width of your parcel of land (in feet) is: " + sideLengthOfSquare + '\n');
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid input.");
                            break;
                        }
                }
            
            }
            while (programControl != 3);

            

            System.Console.ReadLine();
        }
    }
}
