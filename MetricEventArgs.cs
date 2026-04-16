using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	/// <summary>
	/// Можно было бы использовать делегат EventHandler<T>, но он содержит инфу об отправителе (избыточно)
	/// EventHandler<T> - шаблон для создания события: кто вызвал событие и какие данные передаются
	/// делегат - объект, который указывает на метод (переменная, в которой хранится ссылка на функцию)
	/// </summary>
	
	public class MetricEventArgs(string eventType, MetricData data) : EventArgs
	{
		public string EventType { get; } = eventType ?? throw new ArgumentNullException(nameof(eventType));
		public MetricData Data { get; } = data ?? throw new ArgumentNullException(nameof(data)); //выделяем в отдельный кдасс с типом события, т.к. их может быть много
	}
}
