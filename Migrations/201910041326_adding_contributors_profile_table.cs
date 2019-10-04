using System;
using Domain.Framework.Constants;
using FluentMigrator;
using FluentMigrator.SqlServer;
using Migrations.Framework;

namespace Migrations
{
    [Migration(201910041326)]
    public class _201910041326_adding_contributors_profile_table : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.ContributorProfiles);
        }

        public override void Up()
        {
            Create.Table(TableConstants.ContributorProfiles)
                .WithCommonColumns()
                .WithColumn("Login").AsString().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Bio").AsString().NotNullable()
                .WithColumn("AvatarUrl").AsString().NotNullable()
                .WithColumn("Blog").AsString().NotNullable()
                .WithColumn("Hireable").AsBoolean().NotNullable();
        }
    }
}