using PricingTool.DAL.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PricingTool.DAL.Context
{
    public class DataContext: DbContext
    {
        private void InitConfiguration()
        {
            Configuration.UseDatabaseNullSemantics = true;
            Configuration.AutoDetectChangesEnabled = true;
        }
        private static ConventionsConfiguration InitCoventions(DbModelBuilder dbModelBuilder)
        {
            return dbModelBuilder.Conventions;
        }
        private static void SetupConventions(DbModelBuilder dbModelBuilder)
        {
            var conventions = InitCoventions(dbModelBuilder);
            conventions.Remove<PluralizingTableNameConvention>();
            conventions.Remove<PluralizingEntitySetNameConvention>();
            conventions.Add<OneToManyCascadeDeleteConvention>();
            conventions.Add<ManyToManyCascadeDeleteConvention>();
        }

        public DataContext() : base("DataContext")
        {
            InitConfiguration();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Настройка соглашений.
            SetupConventions(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet
        public DbSet<ClassifierType> ClassifierType { get; set; }
        public DbSet<Classifier> Classifier { get; set; }
        #endregion
    }
}
