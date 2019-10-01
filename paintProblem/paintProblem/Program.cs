using System;

namespace paintProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coverage of chosen paint
            int paint;
            int roomWidth, roomLength, roomHeight;
            int windowHeight, windowWidth, windowArea;


            //Calculate room area
                //User input
                Console.WriteLine("Input wall length: ");
                roomLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input wall width: ");
                roomWidth = Convert.ToInt32(Console.ReadLine());                
      
                Console.WriteLine("Input wall height: ");
                roomHeight = Convert.ToInt32(Console.ReadLine());


            //Calculate window area
                //User input
                Console.WriteLine("Input window height: ");
                windowHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input window width: ");
                windowWidth = Convert.ToInt32(Console.ReadLine());

                //Window area
                windowArea = windowHeight * windowWidth;

            //Minus window area from room
                //Area of paintable wall

            //Calculate how much paint is required for user's room
                
        }
    }
}
