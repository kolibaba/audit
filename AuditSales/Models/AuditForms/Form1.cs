using System.ComponentModel.DataAnnotations;

namespace AuditSales.Models.AuditForms
{
	public enum KindOfActivity
	{
		[Display(Name = "Сервисное обслуживание")]
		Service,
		[Display(Name = "Продажа товаров")]
		Sales
	}

	public class Form1
	{
		[Required]
		[Display(Name = "Количество сотрудников")]
		public int PersonsCount { get; set; }

		[Required]
		[Display(Name = "Вид деятельности")]
		public KindOfActivity KindOfActivity { get; set; }
	}
}