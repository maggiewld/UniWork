using System;

namespace paintProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coverage of chosen paint
            byte paint;
            byte roomWidth, roomLength, roomHeight;
            byte windowHeight, windowWidth, windowArea;


            //Calculate room area
                //User input
                Console.WriteLine("Input wall length: ");
                roomLength = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Input wall width: ");
                roomWidth = Convert.ToByte(Console.ReadLine());                
      
                Console.WriteLine("Input wall height: ");
                roomHeight = Convert.ToByte(Console.ReadLine());


            //Calculate window area
                //User input
                Console.WriteLine("Input window height: ");
                windowHeight = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Input window width: ");
                windowWidth = Convert.ToByte(Console.ReadLine());

                //Window area
                windowArea = windowHeight * windowWidth

            //Minus window area from room
                //Area of paintable wall

            //Calculate how much paint is required for user's room
                
        }
    }
}
