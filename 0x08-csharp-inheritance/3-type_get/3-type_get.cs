using System;
using System.Reflection;

///<summary>Class with a method</summary>
class Obj
{
    ///<summary>Prints the names of available properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        TypeInfo infoList = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", infoList.Name);

        foreach (PropertyInfo item in infoList.GetProperties())
            Console.WriteLine(item.Name);

        Console.WriteLine("{0} Methods:", infoList.Name);

        foreach (MethodInfo item in infoList.GetMethods())
            Console.WriteLine(item.Name);
    }
}
