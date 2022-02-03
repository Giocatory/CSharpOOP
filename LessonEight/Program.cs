using LessonEight;

Shape[] shapes = new Shape[] {
                                new Hexagon(),
                                new Hexagon("Mike"),
                                new Circle(),
                                new Circle("Tanya"),
                                new NewCircle(),
                                new NewCircle("Margo")
                            };

foreach (var sp in shapes)
{
    sp.Draw();
}

/*
We draw Hexagon: Hexagon
We draw Hexagon: Mike
We draw Circle: Circle
We draw Circle: Tanya
We draw Circle: NewCircle
We draw Circle: Margo
 */

Console.WriteLine(new Hexagon() is Shape); // true
Console.WriteLine(new NewCircle() is not null); // true