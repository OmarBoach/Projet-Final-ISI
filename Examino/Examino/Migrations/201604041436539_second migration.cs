namespace Examino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserQuizs", "QuizFinalId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserQuizs", "QuizFinalId");
            AddForeignKey("dbo.UserQuizs", "QuizFinalId", "dbo.QuizModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserQuizs", "QuizFinalId", "dbo.QuizModels");
            DropIndex("dbo.UserQuizs", new[] { "QuizFinalId" });
            DropColumn("dbo.UserQuizs", "QuizFinalId");
        }
    }
}
