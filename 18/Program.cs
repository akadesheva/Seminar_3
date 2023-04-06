// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (x и y)

// примечание: применяется конструкция switch case. Применяется когда мы заранее знаем примерные данные значения "quarter"

Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

  switch(quarter)
  {
    case 1: {
        Console.WriteLine("x>0 y>0");
        break;
    }
    case 2: {
        Console.WriteLine("x<0 y>0");
        break;
    }
    case 3: {
        Console.WriteLine("x<0 y<0");
        break;
    }
    case 4: {
        Console.WriteLine("x>0 y<0");
        break;
    }
    default: {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
  }

// при использовании конструкции IF это выглядело бы так:

// Console.Write("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine());

// if (quarter == 1){
//     Console.WriteLine("x>0 y>0");
// }else if(quarter == 2){
//     Console.WriteLine("x<0 y>0");
// }else if(quarter == 3){
//     Console.WriteLine("x<0 y<0");
// }else if(quarter == 4){
//     Console.WriteLine("x>0 y<0");
// }