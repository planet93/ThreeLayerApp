using PricingTool.DAL.Context;
using System.Data.Entity.Migrations;

namespace Phoenix.Infrastructure.Data.Migrations {
	/// <summary>
	/// Конфигурация миграций
	/// </summary>
	public class Configuration : DbMigrationsConfiguration<DataContext> {
		/// <summary>
		/// Конфигурация миграций
		/// </summary>
		public Configuration() {
			//Миграции автоматические
			AutomaticMigrationsEnabled = true;
			//Разрешить потерю данных при автоматической миграции
			AutomaticMigrationDataLossAllowed = true;
		}
		/// <inheritdoc />
		/// <summary>
		/// Seed
		/// </summary>
		/// <param name="dataContext"></param>
		protected override void Seed(DataContext dataContext) {
		}
	}
}
