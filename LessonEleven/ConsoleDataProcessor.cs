namespace LessonEleven
{
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessorData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
}
