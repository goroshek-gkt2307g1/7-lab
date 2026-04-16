

using _7_lab;


EventMonitor monitor = new();
monitor.OnMetricExceeded += e => Console.WriteLine($"Метрика {e.Data.MetricName} превышена!");

monitor.CheckMetric("Lol", 90.0, 80.0);
