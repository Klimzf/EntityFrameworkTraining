﻿namespace EntityFrameworkTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupTypeAndSong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Type");
        }
    }
}
