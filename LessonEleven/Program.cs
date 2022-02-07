using LessonEleven;

// Work With Interfaces
ConsoleDataProcessor dataProcessor = new();
dataProcessor.ProcessorData(new DbDataProvider());
dataProcessor.ProcessorData(new FileDataProvider());
dataProcessor.ProcessorData(new APIDataProvider());