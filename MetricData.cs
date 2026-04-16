using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	public class MetricData (string metricName, double value, double threshold, DateTime timestamp)
	{
		//название метрики
		public string MetricName { get; } = metricName ?? throw new ArgumentNullException(nameof(metricName)); //?? - левое значение, если не null; если null - правый
																											   //Зарегистрированное значение
		public double Value { get; } = value;
		//Критический порог
		public double Threshold { get; } = threshold;
		public DateTime Timestamp { get; } = timestamp;
		public override string ToString()
		{
			return $"Metric: {MetricName}, Value: {Value} (Threshold: {Threshold})";
		}



	}
}
