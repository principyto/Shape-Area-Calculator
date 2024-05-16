using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        float result = 0;
        float height;
        float width;
        float plinth;
        float sideLenght;
        Console.WriteLine("what shape would you like to calculate the area of?");
        Console.WriteLine("1. Rectangle 2. Circle 3. Triangle 4. Octagon 5. Square 6. Pentagon");

        answer = Console.ReadLine();
        switch (answer)
        {
            case "1":
                Console.WriteLine("please enter the height of the rectangle.");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle.");
                width = float.Parse(Console.ReadLine());

                result = height * width;
                break;
            case "2":
                Console.WriteLine("Please enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());
                result = (float)Math.PI * (radius * radius);
                break;
            case "3":
                Console.WriteLine("Please enter de height of the triangle");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the base of the triangle");
                plinth = float.Parse(Console.ReadLine());

                result = (height * plinth) / 2;
                break;
            case "4":
                Console.WriteLine("Please enter the lenght of one of the sides of the octagon");
                sideLenght = float.Parse(Console.ReadLine());

                result = (2 * (1 + Convert.ToSingle(Math.Sqrt(2)))) * (sideLenght * sideLenght);
                break;
            case "5":
                Console.WriteLine("Please enter the lenght of one of the sides of the square");
                sideLenght = float.Parse(Console.ReadLine());

                result = sideLenght * sideLenght;
                break;
            case "6":
                Console.WriteLine("Please enter the lenght of one of the sides of the Pentagon");
                sideLenght = float.Parse(Console.ReadLine());

                result = 0.25f * Convert.ToSingle(Math.Sqrt(5 * (5 + (2 * Convert.ToSingle(Math.Sqrt(5)))))) * (sideLenght * sideLenght);
                break;
            default:
                Console.WriteLine("not an option");
                break;
           
        }
        Console.WriteLine("The result is " + result);
        Console.ReadKey();
    }
}