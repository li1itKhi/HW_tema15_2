int[] array = new int[10]; //создаем массив

Random random = new Random(); 

for(int i = 0; i < array.Length; i++) //цикл на заполнение массива
{
    array[i] = random.Next(1, 20); //заполняем массив рандомными значенимя от 1 до 19

    Console.Write(array[i]+" "); //выводим элементы на экран
}

int count = 0; //перемменная для подсчета к-ва четных элементов массива

for(int i=0; i<array.Length; i++) //цикл для проверки условия четности
{
    if (array[i] % 2 == 0) count++; //если элементы массива четные, то счетчик увеличивается
}

Console.WriteLine(); // разделение (ендлайн)

Console.WriteLine("Четных элементов: "+ count); //вывод