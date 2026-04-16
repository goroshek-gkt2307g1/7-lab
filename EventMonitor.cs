using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	public delegate void MetricEventHandler(MetricEventArgs e); //шаблон метода, который будет обрабатывать событие

	/// <summary>
	/// Субъект (Subject). Вместо интерфейса ISubject и методов Attach/Detach
	/// использует стандартное событие .NET.
	/// </summary>

	public class EventMonitor
	{
		//Событие - ключевой элемеет паттерна Observer 
		public event MetricEventHandler? OnMetricExceeded;

		public void CheckMetric(string metricName, double value, double threshold)
		{
			Console.WriteLine($"[Monitor]: Checking {metricName} ({value} vs {threshold})");
			if (value > threshold)
			{
				//создание данных метрик (eventData)
				
				var eventData = new MetricData(metricName, value, threshold, DateTime.Now);	

				//вместо foreach - просто вызов события
				//?. проверка на наличие подписчиков
				OnMetricExceeded?.Invoke(new MetricEventArgs(eventType: metricName + "_Exceeded", data: eventData));

			}
		}
	}
}
