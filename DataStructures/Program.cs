
using DataStructures;
using System.Collections;

Dictionary<string, string> countries = new Dictionary<string, string>() {
    {"US", "United States"},
    {"UK", "United Kingdom" },
    {"PK", "Pakistan" }
};
void Dictionary()
{
    // Dictionary of countries 
    // Two ways to Insrt Values in a Dictionaey
    
    countries.Add("UAE", "Dubai");

    //Accessing Elements from Dict
    int i = 1;
    foreach (var c in countries)
    {
        Console.WriteLine(i + " Dictionary " + c + " Key: " + c.Key + " Value: " + c.Value);
        i++;

        if (c.Key == "PK")
        {
            Console.WriteLine("Pakistan Zindabad");
        }
    }

    Console.WriteLine("\n This is the value of KEY PK : " + countries["PK"]);

    if (countries.ContainsKey("France"))
    {
        Console.WriteLine("There is a country called France");
    }
    else
    {
        Console.WriteLine("No Country exists with the name France");
    }
}
void List()
{
    // Two ways for insertion
    List<StudentProp> list = new List<StudentProp>() {
        new StudentProp(){Id = 1, Name="Bill"},
        new StudentProp(){Id = 2, Name="Jim"},
        new StudentProp(){Id = 3, Name="Same"}
    };
    Console.WriteLine("List Acces by index : " + list[1].Name);
    foreach (var c in list)
    {
        Console.WriteLine(c.Id + " " +c.Name);
    }

    //Accending Sorted List
    SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };

    foreach (var item in cities)
    {
        Console.WriteLine(item.Key + " " + item.Value);
    }
}
void HashTable()
{
    //Almost Same as Dictionary bith use IDictionary
    Hashtable ht = new Hashtable(countries);
}
void Stack()
{
    Stack<int> myStack = new Stack<int>();
    myStack.Push(1);
    myStack.Push(2);
    myStack.Push(2);
    myStack.Push(4);

    myStack.Pop();

    foreach (var item in myStack)
    {
        Console.WriteLine(item);
    }
}

Dictionary();
HashTable();
List();
Stack();
Console.ReadLine();
