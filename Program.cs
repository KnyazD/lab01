//lab01 ИУ8-31 Лукьяненко Эдуард
//Part 1 
/*
Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных CTS на C#");

Console.WriteLine("Целочисленные типы:");
Console.WriteLine($"sbyte: минимальное значение {sbyte.MinValue}, максимальное значение {sbyte.MaxValue}");
Console.WriteLine($"byte: минимальное значение {byte.MinValue}, максимальное значение {byte.MaxValue}");
Console.WriteLine($"short: минимальное значение {short.MinValue}, максимальное значение {short.MaxValue}");
Console.WriteLine($"ushort: минимальное значение {ushort.MinValue}, максимальное значение {ushort.MaxValue}");
Console.WriteLine($"int: минимальное значение {int.MinValue}, максимальное значение {int.MaxValue}");
Console.WriteLine($"uint: минимальное значение {uint.MinValue}, максимальное значение {uint.MaxValue}");
Console.WriteLine($"long: минимальное значение {long.MinValue}, максимальное значение {long.MaxValue}");
Console.WriteLine($"ulong: минимальное значение {ulong.MinValue}, максимальное значение {ulong.MaxValue}");

Console.WriteLine("Вещественные типы:");
Console.WriteLine($"float: минимальное значение {float.MinValue}, максимальное значение {float.MaxValue}");
Console.WriteLine($"double: минимальное значение {double.MinValue}, максимальное значение {double.MaxValue}");
Console.WriteLine($"decimal: минимальное значение {decimal.MinValue}, максимальное значение {decimal.MaxValue}");

Console.WriteLine("Символьные типы:");
Console.WriteLine($"char: минимальное значение {char.MinValue}, максимальное значение {char.MaxValue}");

Console.WriteLine("Логический тип:");
Console.WriteLine($"bool: минимальное значение {bool.FalseString}, максимальное значение {bool.TrueString}");
*/

//part 2

/*
namespace Myprog2
{
class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double sideA, double sideB)
    {
        this.side1 = sideA;
        this.side2 = sideB;
    }

    private double CalculateArea()
    {
        return side1 * side2;
    }

    private double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get
        {
            return CalculateArea();
        }
    }

    public double Perimeter
    {
        get
        {
            return CalculatePerimeter();
        }
    }
}
class Program1
{
    static bool TestCalculateArea()
    {
        Rectangle rectangle = new(5, 10);
        return rectangle.Area == 50;
    }

    static bool TestCalculatePerimeter()

    {
        Rectangle rectangle = new Rectangle(5, 10);
        return rectangle.Perimeter == 30;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the length of side1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine("Perimeter: " + rectangle.Perimeter);
        Console.WriteLine("Area: " + rectangle.Area);
        Console.WriteLine("Test CalculateArea: " + (TestCalculateArea() ? "Passed" : "Failed"));
        Console.WriteLine("Test CalculatePerimeter: " + (TestCalculatePerimeter() ? "Passed" : "Failed"));
    }
}

}

*/

// Part 3

namespace Myprog3
{ 
    class Point
   {
    private int x;
    private int y;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

    class Figure
    {
        private Point[] points;
        public string Name { get; set; }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public double LengthSide(Point A, Point B)
        {
            int dx = A.X - B.X;
            int dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            if (points.Length > 2)
            {
                perimeter += LengthSide(points[points.Length - 1], points[0]);
            }

            Console.WriteLine($"Figure: {Name}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание точек
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 3);
            Point p3 = new Point(4, 0);

            // Создание многоугольника (треугольник)
            Figure triangle = new Figure(p1, p2, p3);
            triangle.Name = "Triangle";
            triangle.PerimeterCalculator();

            // Создание еще одной точки
            Point p4 = new Point(3, 4);

            // Создание многоугольника (четырехугольник)
            Figure quadrilateral = new Figure(p1, p2, p3, p4);
            quadrilateral.Name = "Quadrilateral";
            quadrilateral.PerimeterCalculator();

            // Создание еще одной точки
            Point p5 = new Point(2, 1);

            // Создание многоугольника (пятиугольник)
            Figure pentagon = new Figure(p1, p2, p3, p4, p5);
            pentagon.Name = "Pentagon";
            pentagon.PerimeterCalculator();
        }
    }
}