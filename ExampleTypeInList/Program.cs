using System.Reflection;

var list = new List<Type>();


list.Add(typeof(int));
list.Add(typeof(double));
list.Add(typeof(long));
list.Add(typeof(sbyte));
//list.Add(typeof(string)); This does not work becasue it does not have a maxvalue

foreach (var item in list)
{
    var fieldInfo = item.GetField("MaxValue");

    //to ensure we do not get a null exception pointer
    if (fieldInfo is not null)
    {
        Console.WriteLine(fieldInfo.GetValue(item.GetField("MaxValue")));
    }

    //This allowed me to see what all the fields where from the datatype.
    //foreach (var item2 in item.GetFields())
    //{
    //  Console.WriteLine(item2);
    //}
}
