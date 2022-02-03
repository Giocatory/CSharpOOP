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