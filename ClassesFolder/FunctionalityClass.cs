
//********************************************* start of file *************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingPOEPart1.ClassesFolder
    
{
    internal class FunctionalityClass
    {

        public void FunctionalityClasss() {

          //  ingredients = new List<Ingredients>();
         //   steps = new List<string>();
        }



        //********************** Start of captureDetails methods ****************//

        /*
         * 
         The goal of this method is to propt a  user for details regarding the recipe namely 
        1. The number of ingriddents
        2. The quantity of the ingridents
        3. The unit or measurement of ingridents
        4. Any aditional ingridents
         
         Finally we will need to store the captured data in a storage system.

         */

        public void CaptureDetails() {

            //************************ start of field declerations ****************************//

            int stepCount; // This will keep track of how many steps are needed 

            string step; // This will be used to store the steps

            int ingridentNumbers; // This variable will be used to store how many ingredients are being used 

            string ingredientName; // This field variable will be used to store th ingrident name

            double ingredentQuantity; //This field variable will be used to store the quantity the ingridents

            string ingridentMeasurement; // This field variable will be used to store the measurements 

            //************************* end of field declerations ************************************//

            ////////////////////////////////// start of code ///////////////////////////////

            Console.WriteLine("Please Enter How Many Ingridents Will Be Used In This Recipe :");

            ingridentNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingridentNumbers; i++) {

                // come put a try catch here 

                Console.WriteLine($"Enter the number Name of Ingrident : "); // Prompt user for name
                ingredientName = Console.ReadLine(); // store in ingrident name

                Console.WriteLine($"Enter the quantity for {ingredientName}: ");
                ingredentQuantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the measurement for the {ingredientName} : ");
                ingridentMeasurement = Console.ReadLine();

            }



            ////////////////////////////////// end of code ///////////////////////////////
        }
        //********************** end  of captureDetails methods ****************//

    }

}
//******************************************* end of file *****************************************//