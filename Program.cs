// //Напишите программу, которая принимает на вход трёхзначное число
// // и на выходе показывает вторую цифру этого числа.

void CutNumber(){
    Console.WriteLine("Введите трехзначное число: ");            //ввод данных
    int num = Convert.ToInt32(Console.ReadLine());
    if (num>99 && num<1000){
        int sec = num % 100;                                     //отсекаем первую цифру
        int result = sec /10;                                    //убираем последнюю цифру
        Console.WriteLine("Вторая цифра числа - " + result);     //вывод результата
    }
    else{
        Console.WriteLine("Число не трехзначное");
    }
}

CutNumber();



//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

void ThreeNumber(){
    Console.WriteLine("Введите число: ");                  //ввод данных
    int num = Convert.ToInt32(Console.ReadLine());
    string number = Convert.ToString(num);                 //конвертация числа в строку 
    if (number.Length > 2){                                //проверка количества символов в строке>2
    Console.WriteLine("Третья цифра числа - " + number[2]);//вывод цифры с индексом 2
    }
    else {
        Console.WriteLine("Третьей цифры нет");            //вывод если кол-во символов в строке меньше3
    }
}

ThreeNumber();


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void Week(){
    Console.WriteLine("Введите число, соответствующее дню недели: ");//ввод данных
    int day = Convert.ToInt32(Console.ReadLine());

    if (day>=1 && day<=5){               //дни недели с 1 по 5
        Console.WriteLine("Рабочий день");
    }
    else if(day>=6 && day<=7){           //6 и 7день
        Console.WriteLine("Выходной");
    }
    else{
        Console.WriteLine("Число не является днем недели");
    }
}

Week();