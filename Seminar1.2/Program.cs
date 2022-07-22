//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int test = 3;

string Quote(int num)
{
    if (num >= 1 && num <= 4)
    {
        switch (num)
        { 
            case 1:
            {
                return "Все положительные";
            }
            case 2:
            {
                return "По X отрицательные, по Y положительные";

            }
            case 3:
            {
                return "Все отрицательные";

            }
            case 4:
            {
                return "По X положительные, по Y отрицательные";

            }

        }
    }
    return "erorr";
}

Console.WriteLine(Quote(test));