namespace Nanny
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FactoryModel : DbContext
    {
        // Your context has been configured to use a 'FactoryModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Nanny.FactoryModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FactoryModel' 
        // connection string in the application configuration file.
        public FactoryModel()
            : base("name=FactoryModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ChildCare> ChildCares { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}