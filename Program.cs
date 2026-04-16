using _7_lab;

EventMonitor monitor = new();

var consoleHandler = new ConsoleHandler(new TextFormatStrategy());
var fileHandler = new FileHandler(new JsonFormatStrategy());

monitor.OnMetricExceeded += consoleHandler.ProcessEvent;
monitor.OnMetricExceeded += fileHandler.ProcessEvent;

consoleHandler.SetStrategy(new JsonFormatStrategy()); 

monitor.CheckMetric("CPU_Load", 95.0, 80.0);
monitor.CheckMetric("Memory_Usage", 85.0, 70.0);
monitor.CheckMetric("Network_Traffic", 120.0, 100.0);

Console.ReadLine();