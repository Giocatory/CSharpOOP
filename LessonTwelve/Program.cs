using LessonTwelve;

// explicit casting of interfaces
// three interfaces with the same method
// and a class that implements all interfaces
Picture picture = new();

//1
IDrawToForm toForm = (IDrawToForm)picture;
toForm.Draw(); // Draw to Form...
//2
((IDrawToMemory)picture).Draw(); // Draw to Memory
//3
if (picture is IDrawToPrinter toPrinter) toPrinter.Draw(); // Draw to Printer...