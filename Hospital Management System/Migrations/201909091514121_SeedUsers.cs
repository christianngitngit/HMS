namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3b6c6b6c-e4b0-4e15-8ed4-38f0b9f0a749', N'user1@hms.com', 0, N'ABUOEB/1J8ze8Vc/faWAe+iLTASOSn71WKIKeTW8W5BD6m9NKDmh7y3aQxV+C5rSiQ==', N'2800c7a5-6003-4740-beaf-ae93b4731795', NULL, 0, 0, NULL, 1, 0, N'user1@hms.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d2abe9d-dba1-41dc-8e6b-aba21688a404', N'admin@hms.com', 0, N'ALplfJaXN93Mo49WTF1t99OqLdR/UcPlHbFpu/AFHU/L7PjNk/2ZSJcX+hvhhS+0LQ==', N'0ca376ad-683e-45c1-9f85-fcd4bbef3db2', NULL, 0, 0, NULL, 1, 0, N'admin@hms.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5438dc6-7015-4ccd-aca2-c6d8673d7596', N'user2@hms.com', 0, N'AHR8I5MY/5KgMmn6BjQum4+o6I2DCJmcm9VimP1RtjAvmtT/CS9IlqYBj51/uqf35w==', N'5bb4488e-2248-4bb6-96da-3e897d35855d', NULL, 0, 0, NULL, 1, 0, N'user2@hms.com')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5d2abe9d-dba1-41dc-8e6b-aba21688a404', N'49605b2c-629f-41eb-b054-9a531642a16c')
            ");
        }

        public override void Down()
        {
        }
    }
}
