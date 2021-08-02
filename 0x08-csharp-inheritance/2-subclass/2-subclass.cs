using System;

///<summary>Class with method for checking inheritance</summary>
class Obj
{
    ///<summary>Returns true/false depending on inheritance of obj.</summary>
    ///<param name="derivedType">Class to check for inhertiance of.</param>
    ///<param name="baseType">Class to check inhyeritance of.</param>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
