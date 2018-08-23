using System.Data.Entity;

namespace Com.Entity
{
    public class Entities : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public Entities()
            : base("name=Entities")
        {
            // 禁止对 __MigrationHistory访问
            Database.SetInitializer<Entities>(null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Entities(string name)
            : base(name)
        {
        }

        /// <summary>
        /// 在完成对派生上下文的模型的初始化后，并在该模型已锁定并用于初始化上下文之前，将调用此方法。虽然此方法的默认实现不执行任何操作，但可在派生类中重写此方法，这样便能在锁定模型之前对其进行进一步的配置。
        /// </summary>
        /// <param name="modelBuilder">定义要创建的上下文的模型的生成器。</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
