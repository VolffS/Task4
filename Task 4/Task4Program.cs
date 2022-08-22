namespace Task_4;

public class Task4Program
{
    public static void Run()
    {
        var Triangles = new List<Triangle>();
        var Rectangles = new List<Rectangle>();
        var Circles = new List<Circle>();
        var Vectors = new List<Vector>();
        string choise;
        var workingProgram = true;

        Console.WriteLine("Привет.");
        while (workingProgram)
        {
            Console.WriteLine(
                "Выбери одно издействий.\n1)Создать Фигуру\n2)Передвинуть фигуру\n3)Посчитать суммарную площадь всех созданных фигур\n4)Векторы\n5)Выход из программы");
            choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                {
                    SelectingFigureToBeCreated();
                    break;
                }
                case "2":
                {
                    SelectingFigureToBeMove();
                    break;
                }
                case "3":
                {
                    double sumSquare = 0;
                    if (Triangles.Count == 0 && Rectangles.Count == 0 && Circles.Count == 0)
                    {
                        Console.WriteLine($"Вы не создали ещё не одной фигуры");
                    }
                    else
                    {
                        foreach (var figure in Triangles) sumSquare += figure.Square();
                        foreach (var figure in Rectangles) sumSquare += figure.Square();
                        foreach (var figure in Circles) sumSquare += figure.Square();
                        Console.WriteLine($"Сумарная площадь равна: {sumSquare}");
                    }

                    break;
                }
                case "4":
                {
                    ActionWithVectors();
                    break;
                }
                case "5":
                {
                    workingProgram = false;
                    Console.WriteLine($"Завершение программы");
                    break;
                }
                default:
                {
                    Console.Clear();
                    Console.WriteLine("Вы сделали не правильный ввод");
                    break;
                }
            }
        }

        void SelectingFigureToBeMove()
        {
            Console.WriteLine("Выбери одну из фигур для перемещения.\n1)Треугольник\n2)Прямоугольник\n3)Круг\n4)Назад");
            choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                {
                    if (Triangles.Count != 0)
                    {
                        Console.WriteLine($"Выбирите какой из треугольников перемещать {Triangles.Count}\nВаш выбор ");
                        var point = new Coordinate();
                        var index = ConversionStringToIntForArray(Triangles.Count);
                        point = CreatingPoint("X");
                        Triangles[index].Move(point.x, point.y);
                        Console.WriteLine($"Новое расположение точек {Triangles[index].ToString()}");
                    }
                    else
                    {
                        Console.WriteLine($"Нет фигур для перемещения");
                    }

                    break;
                }
                case "2":
                {
                    if (Rectangles.Count != 0)
                    {
                        Console.WriteLine(
                            $"Выбирите какой из прямоугольников перемещать {Rectangles.Count}\nВаш выбор ");
                        var point = new Coordinate();
                        var index = ConversionStringToIntForArray(Rectangles.Count);
                        point = CreatingPoint("X");
                        Rectangles[index].Move(point.x, point.y);
                        Console.WriteLine($"Новое расположение точек {Rectangles[index].ToString()}");
                    }
                    else
                    {
                        Console.WriteLine($"Нет фигур для перемещения");
                    }

                    break;
                }
                case "3":
                {
                    if (Circles.Count != 0)
                    {
                        Console.WriteLine($"Выбирите какой из кругов перемещать {Circles.Count}\nВаш выбор ");
                        var point = new Coordinate();
                        var index = ConversionStringToIntForArray(Circles.Count);
                        point = CreatingPoint("X");
                        Circles[index].Move(point.x, point.y);
                        Console.WriteLine($"Новое расположение точек {Circles[index].ToString()}");
                    }
                    else
                    {
                        Console.WriteLine($"Нет фигур для перемещения");
                    }

                    break;
                }
                case "4":
                {
                    break;
                }
                default:
                {
                    Console.Clear();
                    Console.WriteLine("Вы сделали не правильный ввод");
                    break;
                }
            }
        }

        void SelectingFigureToBeCreated()
        {
            Console.WriteLine("Выбери одну из фигур для создания.\n1)Треугольник\n2)Прямоугольник\n3)Круг\n4)Назад");
            choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                {
                    CreateTriangle();
                    break;
                }
                case "2":
                {
                    CreateRectangle();
                    break;
                }
                case "3":
                {
                    CreateCircle();
                    break;
                }
                case "4":
                {
                    break;
                }
                default:
                {
                    Console.Clear();
                    Console.WriteLine("Вы сделали не правильный ввод");
                    break;
                }
            }
        }

        void ActionWithVectors()
        {
            Console.WriteLine("Выбери одно из действий.\n1)Создать\n2)Сложить\n3)Умножить на число\n4)Назад");
            choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                {
                    CreatingVector();
                    break;
                }
                case "2":
                {
                    if (Vectors.Count < 2)
                    {
                        Console.WriteLine("Векторов слишком мало");
                    }
                    else
                    {
                        Console.WriteLine($"Какие из Векторов будем складывать? Их всего: {Vectors.Count} ");
                        Console.WriteLine($"Первый вектор ");
                        var indexV1 = ConversionStringToIntForArray(Vectors.Count);
                        Console.WriteLine($"Второй вектор ");
                        var indexV2 = ConversionStringToIntForArray(Vectors.Count);
                        var tempVector = new Vector();
                        tempVector = Vectors[indexV1] + Vectors[indexV2];
                        Console.WriteLine($"Получился вектор {tempVector.ToString()}");
                        Vectors.Add(tempVector);
                    }

                    break;
                }
                case "3":
                {
                    if (Vectors.Count < 1)
                    {
                        Console.WriteLine("Нету ни одного вектора");
                    }
                    else
                    {
                        Console.WriteLine($"Какой из Векторов будем умножать? Их всего: {Vectors.Count} ");
                        var index = ConversionStringToIntForArray(Vectors.Count);
                        var tempVector = new Vector();
                        Console.WriteLine($"На какое число будем умножать? ");
                        tempVector = Vectors[index] * ConversionStringToInt();
                        Console.WriteLine($"Получился вектор {tempVector.ToString()}");
                        Vectors.Add(tempVector);
                    }

                    break;
                }
                case "4":
                {
                    break;
                }
                default:
                {
                    Console.Clear();
                    Console.WriteLine("Вы сделали не правильный ввод");
                    break;
                }
            }
        }

        
        void CreateTriangle()
        {
            Console.Clear();
            while (true)
            {
                var tempTriangle = new Triangle(CreatingPoint("A"),CreatingPoint("B"),CreatingPoint("C"));
                if (tempTriangle.FigureExists())
                {
                    Console.WriteLine($"Фигура создана {tempTriangle.ToString()}");
                    Triangles.Add(tempTriangle);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Созданные точки не могу создать Треугольник. Попробуйте снова");
                }
            }
        
        }
        void CreateRectangle()
        {
            Console.Clear();
            while (true)
            {
                var tempRectangle = new Rectangle(CreatingPoint("A"),CreatingPoint("B"),CreatingPoint("C"),CreatingPoint("D"));
                if (tempRectangle.FigureExists())
                {
                    Console.WriteLine($"Фигура создана {tempRectangle.ToString()}");
                    Rectangles.Add(tempRectangle);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Созданные точки не могу создать Прямоугольник. Попробуйте снова");
                }
            }
        
        }
        
        void CreateCircle()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Задайте координаты точкам");
                var tempCircle = new Circle(CreatingPoint("O"),CreatingPoint("A"));
                if (tempCircle.FigureExists())
                {
                    Console.WriteLine($"Фигура создана {tempCircle.ToString()}");
                    Circles.Add(tempCircle);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Созданные точки не могу создать круг. Попробуйте снова");
                }
            }
        }
        void CreatingVector()
        {
            var tempVector = new Vector(){PointA = CreatingPoint("A"),PointB = CreatingPoint("B")};
            Vectors.Add(tempVector);
        }
        int ConversionStringToIntForArray(int count)
        {
            int indexFigure;
            while (true)
                if (int.TryParse(Console.ReadLine(), out indexFigure))
                {
                    if (indexFigure > 0 && indexFigure - 1 <= count)
                        return indexFigure - 1;
                    else
                        Console.WriteLine("Вы записали число в не диапозона");
                }
                else
                {
                    Console.WriteLine("Данные введены неверно. Попробуй опять");
                }
        }
        int ConversionStringToInt()
        {
            int indexFigure;
            while (true)
                if (int.TryParse(Console.ReadLine(), out indexFigure))
                    return indexFigure;
                else
                    Console.WriteLine("Данные введены неверно. Попробуй опять");
        }
        double ConversionStringToDouble(string pointCoordinate)
        {
            double number;
            while (true)
            {
                Console.Write($"{pointCoordinate}");
                string convertedText = Console.ReadLine();
                if (Double.TryParse(convertedText, out number) && convertedText.Length!=0 )
                {
                    if (convertedText.IndexOf(",")==-1)
                    {
                        return number;
                    }

                    if ((convertedText.Length - convertedText.IndexOf(","))<=2)
                    {
                        return number;
                    }
                
                }
                Console.WriteLine("Данные введены неверно");
            }
        }

        Coordinate CreatingPoint(string thePointBeingCreated)
        {
            Coordinate point = new Coordinate();
            string notice = "В числе не должно быть больше одного числа полсе запятой\n Пример для ввода: 12 или 2,3";
            Console.WriteLine(notice);
            point.x = ConversionStringToDouble($"{thePointBeingCreated}.x=");
            point.y = ConversionStringToDouble($"{thePointBeingCreated}.y=");
            Console.Clear();
            return point;
        }
    }
}