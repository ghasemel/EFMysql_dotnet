namespace EFMysql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change940820 : DbMigration
    {
        public override void Up()
        {
            this.Sql(@"CREATE VIEW V_STUDENT AS SELECT * FROM students;");
        }
        
        public override void Down()
        {
            this.Sql(@"DROP VIEW V_STUDENT;");
        }
    }
}
