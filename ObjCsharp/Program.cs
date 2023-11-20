namespace ObjCsharp;

using static Person;

internal class Program
{
    private static void Main(string[] args)
    {

        objectsJsStyle();
        Console.WriteLine();
        Console.WriteLine("----");
        Constructor();
    }

    private static void Constructor()
    {
        var p1 = new Person();

        p1.name = "Evelyn";
        p1.sex = "Female";
        p1.age = 18;

        var p2 = new Person("Blazej", 21, "Male");

        Console.WriteLine($" Name : {p1.name}| Age :{p1.age}| Sex: {p1.sex}");
        Console.WriteLine($" Name : {p2.name}| Age :{p2.age}| Sex: {p2.sex}");

    }

    private static void objectsJsStyle()
    {
        var obj = new
        {
            p1 = new
            {
                name = "Jacky",
                age = 21,
                sex = "Male"
            },
            p2 = new
            {
                name = "Jenny",
                age = 21,
                sex = "Female"
            },
            p3 = new
            {
                name = "-... .. - -.-. ....",
                age = 332,
                sex = "Alien"
            }
        };

        Console.WriteLine("Hello " + obj.p1.name + " "+ "!!" + "Age : " + obj.p1.age + " " + "Sex : " + obj.p1.sex + "|");
        Console.WriteLine();
        Console.WriteLine($"Hello {obj.p2.name} !! Age : {obj.p2.age} Sex : {obj.p2.sex}|");
        Console.WriteLine();
        Console.WriteLine("Hello {0} !! Age : {1} Sex : {2}|", obj.p3.name, obj.p3.age, obj.p3.sex);
    }
}