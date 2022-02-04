using LessonNine;

SimpleClass sc = new();
SimpleClass sc2 = new("Mike", 33);

Console.WriteLine(sc); // User: no-name; Age: 0; Class: SimpleClass

// we override base method "ToString()"
Console.WriteLine(sc2); // User: Mike; Age: 33; Class: SimpleClass
Console.WriteLine(sc2.ToString()); // User: Mike; Age: 33; Class: SimpleClass

// Checking a reference to the same object
SimpleClass sc3 = sc2;
Console.WriteLine(sc2.Equals(sc3)); // True
Console.WriteLine(sc.Equals(sc3)); // False
Console.WriteLine(Object.Equals(sc2, sc3)); // True

Console.WriteLine(sc2.GetHashCode()); // 43942917
Console.WriteLine(sc2.GetType()); // LessonNine.SimpleClass