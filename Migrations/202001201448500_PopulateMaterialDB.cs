namespace eimdbapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMaterialDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO materials (name, unit, gitCode) VALUES ('ABAFADOR REF 1435 - 3M', 'UN', 4)");
            Sql("INSERT INTO materials (name, unit, gitCode) VALUES ('ABRAÇADEIRA 22 X 32X14MM', 'UN', 14)");
            Sql("INSERT INTO materials (name, unit, gitCode) VALUES ('AGUA SANITARIA 5LT', 'UN', 9)");
            Sql("INSERT INTO materials (name, unit, gitCode) VALUES ('CABO FLEX 750V CONDUSC PT  2,5MM', 'M', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
