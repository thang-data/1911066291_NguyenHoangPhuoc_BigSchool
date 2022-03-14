namespace _1911066291_NguyenHoangPhuoc_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories (ID,NAME ) Values ( 1 ,'Development ')");
            Sql("insert into Categories (ID,NAME ) Values ( 2 ,'business ')");
            Sql("insert into Categories (ID,NAME ) Values ( 3 ,'marketing ')");
        }
        
        public override void Down()
        {
        }
    }
}
