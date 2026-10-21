/*int dayNumber = 6;

switch (dayNumber) {
    case 5 or 6 or 7 : Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int score = 78;

switch (score) {
    case >= 0 and < 39:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}


int temperature = 20;

string result = temperature switch
{
    t when t < 0 => "Мороз",
    t when t >= 0 && t <= 14 => "Прохладно",
    t when t >= 15 && t <= 24 => "Комфортно",
    t when t >= 25 && t <= 34 => "Жарко",
    t when t >= 35 => "Очень жарко",
    _ => "Некорректная температура"
};

Console.WriteLine(result);

string role = "user";

string result = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};

Console.WriteLine(result);


int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}


int level = 2;

switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        Console.WriteLine("Начальный уровень");
        break;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
    default:
        Console.WriteLine("Неизвестный уровень");
        break;
}




Console.Write("Введите номер месяца (1-12): ");
if (int.TryParse(Console.ReadLine(), out int month))
{
    string season = month switch
    {
        1 or 12 or 2 => "Зима",
        3 or 4 or 5 => "Весна",
        6 or 7 or 8 => "Лето",
        9 or 10 or 11 => "Осень",
        _ => "Неверный месяц"
    };

    Console.WriteLine(season);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}




Console.Write("Введите номер дня недели (1-7): ");
if (int.TryParse(Console.ReadLine(), out int day))
{
       string dayType = day switch
       {
        1 or 2 or 3 or 4 or 5 => "Будний",
        6 or 7 => "Выходной",
        _ => "Неверный день недели"
    };

    Console.WriteLine(dayType);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");





Console.Write("Введите температуру: ");
if (double.TryParse(Console.ReadLine(), out double temp))
{
    string recommendation = temp switch
    {
        < 0 => "Мороз",
        >= 0 and < 10 => "Прохладно",
        >= 10 and < 20 => "Комфортно",
        >= 20 and < 30 => "Тепло",
        _ => "Жарко"
    };

    Console.WriteLine(recommendation);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}*/




Console.Write("Введите тип транспорта (автобус, метро, такси): ");
string transport = Console.ReadLine()?.Trim().ToLower();

string type = transport switch
{
    "автобус" => "Наземный транспорт",
    "метро"   => "Подземный транспорт",
    "такси"   => "Индивидуальный транспорт",
    _         => "Неизвестный транспорт"
};

    Console.WriteLine(type);


