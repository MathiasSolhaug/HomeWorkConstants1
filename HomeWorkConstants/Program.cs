/*1.
 Constant nelzya menyat posli prisvoeniya
    const int maxScore = 100;
    maxScore = 150;


2.
switch rabotayet tolko s constantami
int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
    case 2:
        Console.WriteLine("Вторник");
    case 3:
        Console.WriteLine("Среда");
        break;
}


3.*/

//enum Colorss { Red, Green, Blue, }
//Colorss myColor = Colorss.Red;

/*
4.
Ternalnymi operatsia rabotaet s bool i vozrasyaet string, no bool net
int a = 10;
string result = a > 5 ? "Большое" : "Маленькое";
Console.WriteLine(result ? "Да" : "Нет");
/*
5.
Zdesj v Console.WriteLine vernyetsa Melenkoe, i vivedet ego
int x = 5;
string message = (x > 10) ? "Больше" : "Меньше";
Console.WriteLine(x == 5 ? "Маленькое" : 123);*/
 

void Task1and2()
{
    DayOfWeek today = DayOfWeek.Wednesday;
    int day = 2;

    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        default:
            Console.WriteLine("Takogo dnya net");
            break;
    }

}

void Task3()
{
    const float PI = 3.14159f;
    float radius = 5f;
    Console.WriteLine(PI * radius * radius);
}
void Task4()
{
    string answ = Convert.ToInt32(Console.ReadLine()) % 2>0 ? "Odd" : "Natural";
    Console.WriteLine(answ);
}
void Task5()
{
    int userNum = Convert.ToInt32(Console.ReadLine());
    switch (userNum)
    {
        case 1:
             Console.WriteLine(Books.Fiction); 
            break;
        case 2:
            Console.WriteLine(Books.NonFiction);
            break;
        case 3:
            Console.WriteLine(Books.Science);
            break;
        case 4:
            Console.WriteLine(Books.Biography);
            break;
    }
}
void Practice()
{
    double discount = 0;
    Console.WriteLine("Type in the number of the product type \n 1 - Electronics, 2 - Clothing, 3 - Groceries, 4 - Books");
    int input = Convert.ToInt32(Console.ReadLine());
    ProductCategory category = (ProductCategory)input;
    switch (category)
    {
        case ProductCategory.Electronics:
            discount = 0.10;
            break;
        case ProductCategory.Clothes:
            discount = 0.15;
            break;
        case ProductCategory.Groceries:
            discount = 0.05;
            break;
        case ProductCategory.Books:
            discount = 0;
            break;
        default:
            break;
    }
    Console.WriteLine("Price of product: ");
    int price = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Total price: {price - (price * discount)}");
}



enum DaysOfWeek {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
enum Books {Fiction, NonFiction, Science, Biography}
enum ProductCategory
{
    Electronics = 1,
    Clothes,
    Groceries,
    Books ,
}