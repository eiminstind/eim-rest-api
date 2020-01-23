namespace eimdbapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEmployeeDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees (Name, Job) VALUES ('Nivaldo Teixeira Filho', 'Diretor Executivo')");
            Sql("INSERT INTO Employees (Name, Job) VALUES ('Leonardo Coelho Ramalho Teixeira', 'Desenvolvedor')");
            Sql("INSERT INTO Employees (Name, Job) VALUES ('Marina Coelho Ramalho Teixeira', 'Gerente de Planejamento')");
            Sql("INSERT INTO Employees (Name, Job) VALUES ('Raimundo Caetano', 'Encarregado de Mecânica')");
            Sql("INSERT INTO Employees (Name, Job) VALUES ('José Tupinambá', 'Encarregado de Elétrica')");
        }
        
        public override void Down()
        {
        }
    }
}
