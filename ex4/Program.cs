//ввести число и узнать какой день недели
string [] ai ={"Понедельник", "Вторник", "среда",
 "четверг", "пятница", "суббота", "воскресенье"};

Console.Write ("Введите число от 1 до 7: ");

int b = Convert.ToInt32(Console.ReadLine());

int index = b - 1;

Console.WriteLine(ai[index]);
