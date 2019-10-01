using System;

namespace paintProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintCoverage = 100;
            int roomWidth, roomLength, roomHeight, roomArea;
            int windowHeight, windowWidth, windowArea;
            int availableWall, paintRequired;
            
            //Calculate room area
                //User input
                Console.WriteLine("Input wall length: ");
                    roomLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input wall width: ");
                roomWidth = Convert.ToInt32(Console.ReadLine());                
      
                Console.WriteLine("Input wall height: ");
                roomHeight = Convert.ToInt32(Console.ReadLine());

            //Room area = 2(H*W)+2(H*L)+(W*L)
            roomArea = (2*(roomHeight * roomWidth)) + (2*(roomHeight * roomLength)) + (roomWidth * roomLength);

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
                availableWall = roomArea - windowArea;
            //Calculate how much paint is required for user's room
                paintRequired = availableWall / paintCoverage;
        }
    }
}
