// //Шаг 1. Линейный поиск с флагом
// using System.Data.Common;

// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1067;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// //Шаг 2. Проверка числа на простоту
// int variant = 1;
// bool isPrime = true;

// if (variant == 1){
//     Console.WriteLine($"Число {variant} не считается ни простым, ни составным числом");
// } else {
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
//     Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// }

// //Шаг 3. continue для пропуска элементов
// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;
// foreach (int points in pointsPerLab){
//     if (points < 0){
//         continue;
//     }
//     sum += points;
//     count++;
// }
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");

// //Шаг 4. Дубликаты в массиве
// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++) {
//     for (int j = i + 1; j < groupIds.Length; j++) {
//         if (groupIds[i] == groupIds[j]) {
//             Console.WriteLine($"Совпавшие номера зачеток: {groupIds[i]} и {groupIds[j]}");
//             hasDuplicates = true;
//             break;
//         }
//     }
//     if (hasDuplicates) {
//         break;
//     }
// }
// if (!hasDuplicates) {
//     Console.WriteLine("Все номера уникальны");
// }

// //Шаг 5. Выход сразу из двух циклов
// int days = 5;
// int lessonPerDay = 6;
// bool found1 = false;

// for (int day = 1; day <= days && !found1; day++){
//     for (int lesson = 1; lesson <= lessonPerDay; lesson++){
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree){
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found1 = true;
//             break;
//         }
//     }
// }
// if (!found1){
//     Console.WriteLine("Свободных слотов нет");
// }

//Самостоятельные задания
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine();
Console.WriteLine("Задача А");
int[] num = { 1, 2, 3, 4, 5 };
int target = 2;
bool found = false;
int index = 0;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] == target)
    {
        found = true;
        index = i;
        break;

    }
}
if (found){
    Console.WriteLine($"Индекс искомого числа: {index}");
} else{
    Console.WriteLine("Число не найдено");
}

Console.WriteLine();
Console.WriteLine("Задача Б");
int number = 2;
bool flag = true;

if (number <= 1){
    flag = false;
} else {
    for (int a = 2; a < number; a++){
        if (number % a == 0){
            flag = false;
            break;
        }
    }
}
if (flag){
    Console.WriteLine($"Число {number} является простым");
} else {
    Console.WriteLine($"Число {number} не является простым");
}