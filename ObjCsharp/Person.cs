using System.Security.Cryptography.X509Certificates;

namespace ObjCsharp
{
    class Person

    {
        public byte age;
        //{ private get; set; }

        public string name; 
        //{ get; private set; }
        public string sex;
        //private string sex;
        public Person()
        {
            age = 0;
            name = "Unknown";
            sex = "Unknown";
        }

        public Person(string Name, byte Age, string Sex)
        {
            name = Name;
            age = Age;
            sex = Sex;
        }
    }
}