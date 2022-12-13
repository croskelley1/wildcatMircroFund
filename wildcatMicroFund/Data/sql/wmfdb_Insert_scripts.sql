
--drop table __EFMigrationsHistory;
--drop table ApplicationStatus;
--drop table AspNetUserRoles;
--drop table AspNetRoleClaims;
--drop table AspNetUserClaims;
--drop table AspNetUserLogins;
--drop table AspNetUserTokens;
--drop table AspNetRoles;
--drop table Availability;
--drop table Award;
--drop table AwardType;
--drop table Document;
--drop table DocumentType;
--drop table ReadyEmail;
--drop table EmailTemplate;
--drop table Note;
--drop table NoteType;
--drop table Score;
--drop table PitchEventApplication;
--drop table Response;
--drop table PitchEvent;
--drop table QuestionDetail;
--drop table AssignedQuestion;
--drop table QuestionUse;
--drop table Question;
--drop table QCategory;
--drop table [Status];
--drop table UserAssignment;
--drop table UserApplicationAssignmentType;
--drop table Application;
--drop table AspNetUsers;

SET IDENTITY_INSERT [dbo].[Application] ON
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (1, N'Wally''s Bistro', CAST(N'2019-01-01T00:01:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (2, N'Microsoft', CAST(N'2019-01-01T00:01:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (3, N'Lenovo', CAST(N'2019-01-01T00:01:00.0000000' AS DateTime2), 3)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (4, N'Playstation', CAST(N'2019-01-01T00:01:00.0000000' AS DateTime2), 4)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (5, N'Nintento', CAST(N'2019-01-01T00:00:00.0000000' AS DateTime2), 5)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (6, N'XBOX', CAST(N'2022-11-27T21:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (7, N'John Deere', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (8, N'Willy Wonka', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (9, N'Mountain America', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (10, N'America First', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (11, N'Wells Fargo', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (12, N'Wasatch Brewing Co.', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (13, N'The Hive Winery', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (14, N'Ogden''s Own Distillery', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Application] ([Id], [CompanyName], [CreatedDate], [AppStatus]) VALUES (15, N'Fisher''s Brewery', CAST(N'2022-11-27T22:37:00.0000000' AS DateTime2), 1)

SET IDENTITY_INSERT [dbo].[Application] OFF
GO

SET IDENTITY_INSERT [dbo].[Status] ON
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (1, N'Submitted')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (2, N'Reviewed')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (3, N'Mentor Phase')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (4, N'Ready for Pitch Event')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (5, N'Scored')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (6, N'Assigned Pitch Event')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (7, N'Awarded')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (8, N'1 Month Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (9, N'3 Month Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (10, N'6 Month Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (11, N'9 Month Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (12, N'12 Month Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (13, N'18 Month Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (14, N'2 Year Follow-Up')
INSERT [dbo].[Status] ([StatusID], [StatusDesc]) VALUES (15, N'3 Year Follow-Up')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO

SET IDENTITY_INSERT [dbo].[ApplicationStatus] ON

INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (1, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 1, 1, CAST(N'2022-12-03T01:15:14.4784382' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (2, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 2, 1, CAST(N'2022-12-03T01:15:33.0240016' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (3, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 3, 2, CAST(N'2022-12-03T01:15:37.5469006' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 4, 2, CAST(N'2019-01-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (5, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 5, 2, CAST(N'2019-01-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (6, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 6, 2, CAST(N'2022-11-27T20:37:27.9406685' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (7, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 7, 3, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (8, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 8, 3, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (9, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 9, 3, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (10, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 10, 4, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (11, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 11, 4, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (12, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 12, 4, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (13, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 13, 6, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (14, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 14, 6, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
INSERT [dbo].[ApplicationStatus] ([AppStatId], [UserID], [ApplicationId], [StatusId], [StatusDate]) VALUES (15, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 15, 6, CAST(N'2022-11-27T21:37:27.3185992' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ApplicationStatus] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'ApplicationUser', N'Catherine', N'Clark', N'Weber St', N'Odgen', N'UT', N'84405', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEECubHYo82aWS8UM6q1alGKnv2jb9vN6rw1VqQbnO/v1p4i1DWMpdUQy1OFcVEz6fQ==', N'UQH5E3ZZTEPQLJWAY5UYU52XICDVIOLR', N'84dd6d2b-22a1-485d-9051-879f9b17d778', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'aab7d5db-54d0-45b3-8618-8ed48677cc93', N'ApplicationUser', N'Test', N'User', N'Weber St', N'Odgen', N'UT', N'84405', N'Test@gmail.com', N'TEST@GMAIL.COM', N'Test@gmail.com', N'TEST@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEB8ULRRDOhlRhgRsGlIcXF+D9KrIPdMWPpWdzG8F/0GgUMgy30SjoO3MTvXDNqi4TA==', N'CO7KXQBQ3IGLLW4G6TT4CCO45HAWOBAQ', N'02951891-96e8-4f5c-b5ce-7deefde2afc7', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd62f7c54-d9c9-4bb4-8169-1f0a5a7c20ad', N'ApplicationUser', N'Judy', N'Blum', N'Weber St', N'Odgen', N'UT', N'84405', N'Judge@gmail.com', N'JUDGE@GMAIL.COM', N'Judge@gmail.com', N'JUDGE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMfzRJb10rHlilLCTFb+xmaey5BXcG2Eiymy1GhZm0vDLxsIJqijiR2ieERQjdUVSA==', N'7D4ZMCA6LBSWJQPQHVNRS6ILNWEBQUYE', N'20072199-03de-40aa-b366-39dc5cf2409b', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'db3e05c6-c885-437b-94f5-87cb3b4de9d3', N'ApplicationUser', N'Kaley', N'Smith', N'Weber St', N'Odgen', N'UT', N'84405', N'Mentor@gmail.com', N'MENTOR@GMAIL.COM', N'Mentor@gmail.com', N'MENTOR@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJCMfoJif7RGb+OoyUP9mfc9vl1Hf1zn8hUK6xV/MsrWt6QvC8gG7m/3I2/AG6QhzA==', N'OAW7XQVC55NY4QQ3P4V5WUC2XECVNP4E', N'cc27cf33-85b7-4b4c-9913-22e59ac0b901', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'db3e05c6-c885-437b-94f5-87cb3b4de9d4', N'ApplicationUser', N'Chris', N'Roskelley', N'Weber St', N'Odgen', N'UT', N'84405', N'Chris@gmail.com', N'Chris@GMAIL.COM', N'CHRIS@gmail.com', N'CHRIS@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEABInNSrPYXrx8mpIMBxHY5/2tgb8JvkZ5djWkWYCD6rSmE4YpgOBGwyO+brLQ2vgA==', N'3ZIE4LRURURKD7S7L65NGUNDBDDJAPTG', N'93fa99cc-6e92-40a8-a5ea-f0c5e6d98de4', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', N'ApplicationUser', N'Waldo', N'Wildcat', N'Weber St', N'Odgen', N'UT', N'84405', N'Entrepreneur@gmail.com', N'ENTREPRENEUR@GMAIL.COM', N'Entrepreneur@gmail.com', N'ENTREPRENEUR@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEABInNSrPYXrx8mpIMBxHY5/2tgb8JvkZ5djWkWYCD6rSmE4YpgOBGwyO+brLQ2vgA==', N'3ZIE4LRURURKD7S7L65NGUNDBDDJAPTG', N'93fa99cc-6e92-40a8-a5ea-f0c5e6d98de4', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', N'ApplicationUser', N'Jack', N'Black', N'Weber St', N'Odgen', N'UT', N'84405', N'Entrepreneur2@gmail.com', N'ENTREPRENEUR2@GMAIL.COM', N'Entrepreneu2r@gmail.com', N'ENTREPRENEUR2@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEABInNSrPYXrx8mpIMBxHY5/2tgb8JvkZ5djWkWYCD6rSmE4YpgOBGwyO+brLQ2vgA==', N'3ZIE4LRURURKD7S7L65NGUNDBDDJAPTG', N'93fa99cc-6e92-40a8-a5ea-f0c5e6d98de4', N'1234567890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [FirstName], [LastName], [StreetAddress], [City], [State], [PostalCode], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', N'ApplicationUser', N'Jaden', N'Roskelley', N'Weber St', N'Odgen', N'UT', N'84405', N'Jaden@gmail.com', N'JADEN@GMAIL.COM', N'Jaden@gmail.com', N'JADEN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEABInNSrPYXrx8mpIMBxHY5/2tgb8JvkZ5djWkWYCD6rSmE4YpgOBGwyO+brLQ2vgA==', N'3ZIE4LRURURKD7S7L65NGUNDBDDJAPTG', N'93fa99cc-6e92-40a8-a5ea-f0c5e6d98de4', N'1234567890', 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[UserApplicationAssignmentType] ON

INSERT [dbo].[UserApplicationAssignmentType] ([UserApplicationAssignmentTypeId], [UserApplicationAssignmentDesc]) VALUES (1, N'Admin')
INSERT [dbo].[UserApplicationAssignmentType] ([UserApplicationAssignmentTypeId], [UserApplicationAssignmentDesc]) VALUES (2, N'Mentor')
INSERT [dbo].[UserApplicationAssignmentType] ([UserApplicationAssignmentTypeId], [UserApplicationAssignmentDesc]) VALUES (3, N'Judge')
INSERT [dbo].[UserApplicationAssignmentType] ([UserApplicationAssignmentTypeId], [UserApplicationAssignmentDesc]) VALUES (4, N'Entrepreneur')
SET IDENTITY_INSERT [dbo].[UserApplicationAssignmentType] OFF
GO
SET IDENTITY_INSERT [dbo].[UserAssignment] ON

INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (1,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', 1)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (2,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 2)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (3,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 3)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (4,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 4)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (5,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 5)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (6,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 6)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (7,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 7)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (8,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 8)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (9,  4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 9 )
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (10, 4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 10)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (11, 4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', 11)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (12, 4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 12)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (13, 4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 13)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (14, 4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 14)
INSERT [dbo].[UserAssignment] ([UserAssignmentID], [UserApplicationAssignmentTypeId], [ApplicationUserId], [ApplicationId]) VALUES (15, 4, N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', 15)
SET IDENTITY_INSERT [dbo].[UserAssignment] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a8782739-1c8f-4ec8-b75a-7d6d7bd4271f', N'Judge', N'JUDGE', N'5244c660-e488-4ab3-ad34-47e2d35faacf')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b5df26e3-08a9-4536-84eb-824ce0102a77', N'Admin', N'ADMIN', N'f92a9297-c424-4656-b6a9-20f78dc62479')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f7f3ac0a-ea9a-47ae-aac7-cd27ad2af42d', N'Entrepreneur', N'ENTREPRENEUR', N'80a54bdf-6f9b-478b-bf7d-4ca745cc4cdc')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'fcb3d3b4-d324-4612-9e81-910a6b2ec12c', N'Mentor', N'MENTOR', N'7e48c396-a9ac-4662-a846-e8e951491721')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd62f7c54-d9c9-4bb4-8169-1f0a5a7c20ad', N'a8782739-1c8f-4ec8-b75a-7d6d7bd4271f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'b5df26e3-08a9-4536-84eb-824ce0102a77')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aab7d5db-54d0-45b3-8618-8ed48677cc93', N'b5df26e3-08a9-4536-84eb-824ce0102a77')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56c', N'f7f3ac0a-ea9a-47ae-aac7-cd27ad2af42d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56d', N'f7f3ac0a-ea9a-47ae-aac7-cd27ad2af42d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fb086d38-22e4-4fc2-9ff7-49fcd22bd56e', N'f7f3ac0a-ea9a-47ae-aac7-cd27ad2af42d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db3e05c6-c885-437b-94f5-87cb3b4de9d3', N'fcb3d3b4-d324-4612-9e81-910a6b2ec12c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db3e05c6-c885-437b-94f5-87cb3b4de9d4', N'fcb3d3b4-d324-4612-9e81-910a6b2ec12c')
GO
SET IDENTITY_INSERT [dbo].[EmailTemplate] ON

INSERT [dbo].[EmailTemplate] ([Id], [EmailTemplateName], [TemplateContent], [ModifiedDate], [TemplateSubject]) VALUES (2, N'Welcome Email', N'<p>Hello [FirstName] [LastName],</p>
<p>Welcome to the Wildcat Micro Fund community.</p>
<p>&nbsp;</p>
<p>Thanks,</p>
<p>Admin</p>', CAST(N'2022-12-04T02:36:33.6196033' AS DateTime2), N'Hello and Welcome to the WMF!')
SET IDENTITY_INSERT [dbo].[EmailTemplate] OFF
GO
SET IDENTITY_INSERT [dbo].[PitchEvent] ON

INSERT [dbo].[PitchEvent] ([Id], [PitchEventDate]) VALUES (1, CAST(N'2023-02-01T00:01:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PitchEvent] OFF
GO
SET IDENTITY_INSERT [dbo].[QCategory] ON

INSERT [dbo].[QCategory] ([QCategoryID], [QCategoryDesc]) VALUES (1, N'Initial Submission Criterion')
INSERT [dbo].[QCategory] ([QCategoryID], [QCategoryDesc]) VALUES (2, N'Initial Entrepreneur Survey')
INSERT [dbo].[QCategory] ([QCategoryID], [QCategoryDesc]) VALUES (3, N'Mentorship Survey')
INSERT [dbo].[QCategory] ([QCategoryID], [QCategoryDesc]) VALUES (4, N'Pitch Event Judge Criterion')
SET IDENTITY_INSERT [dbo].[QCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON

INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (1, N'Explanation & Validation of Market Problem or Opportunity', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (2, N'Value Proposition', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (3, N'Customer segment and market opportunity', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (4, N'Customer validation', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (5, N'Overall impression', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (6, N'What is the status of your business?', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (7, N'Tell us about your product/service.', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (8, N'What industry is your business in?', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (9, N'Do you have a website?', 1)
INSERT [dbo].[Question] ([Id], [QuestionSummary], [QuestIsActive]) VALUES (10, N'Do you have a Prototype?', 1)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET IDENTITY_INSERT [dbo].[QuestionUse] ON

INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (1, 1, 4, 1, 1, 1, 20)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (2, 2, 4, 2, 1, 1, 10)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (3, 3, 4, 3, 1, 1, 15)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (4, 4, 4, 4, 1, 1, 20)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (5, 5, 4, 5, 1, 1, 35)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (6, 6, 1, 1, 0, 1, 0)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (7, 7, 1, 2, 0, 1, 0)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (8, 8, 1, 3, 0, 1, 0)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (9, 9, 1, 4, 0, 1, 0)
INSERT [dbo].[QuestionUse] ([QuestionUseID], [QuestID], [QCategoryID], [QuestDisplayOrder], [QuestIsScored], [QuestUseIsActive], [QuestPointValue]) VALUES (10, 10, 1, 5, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[QuestionUse] OFF
GO
SET IDENTITY_INSERT [dbo].[QuestionDetail] ON

INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (1, N'Explain that there is a real and significant problem or opportunity.', 1)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (2, N'How does your product solve the problem/improve the situation?', 2)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (3, N'What specific benefits customers can expect?', 2)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (4, N'Why should customers buy from you over competitors?', 2)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (5, N'Describe your customer segment(s)', 3)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (6, N'Provide market data', 3)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (7, N'Competitive landscape (what are current solutions, and who are competitors?)', 3)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (8, N'A minimum ten (10) customer interviews ', 4)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (9, N'Team', 5)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (10, N'Specific funding request', 5)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (11, N'Presentation', 5)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (12, N'Is there an opportunity for this concept to succeed?', 5)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (13, N'Should this concept be funded?', 5)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (14, N'ie. Concept, Already Started, etc.', 6)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (15, N'If you do have a website, please provide the URL.', 9)
INSERT [dbo].[QuestionDetail] ([QuestionDetailId], [QuestionDetailInfo], [QuestionID]) VALUES (16, N'If you do have a prototype, please provide photos and documents here.', 10)
SET IDENTITY_INSERT [dbo].[QuestionDetail] OFF
GO

insert into Response(Responses, applicationId)
values (N'Open', 1),
       (N'Small cafe for students at Weber', 1),
       (N'Food', 1),
       (N'www.wallysbistro.com', 1),
       (N'No', 1),
       (N'Started', 2),
       (N'Computer stuff', 2),
       (N'Tech', 2),
       (N'www.microsoft.com', 2),
       (N'Many', 2),
       (N'Started', 3),
       (N'We sell computers', 3),
       (N'www.lenovo.com', 3),
       (N'Tech', 3),
       (N'Yes', 3),
	   (N'lorem ipsum', 4),
	   (N'lorem ipsum', 4),
	   (N'lorem ipsum', 4),
	   (N'lorem ipsum', 4),
	   (N'lorem ipsum', 4),
	   (N'lorem ipsum', 5),
	   (N'lorem ipsum', 5),
	   (N'lorem ipsum', 5),
	   (N'lorem ipsum', 5),
	   (N'lorem ipsum', 5),
       (N'lorem ipsum', 6),
       (N'lorem ipsum', 7),
       (N'lorem ipsum', 8),
       (N'lorem ipsum', 9),
       (N'lorem ipsum', 10),
       (N'lorem ipsum', 11),
       (N'lorem ipsum', 12),
       (N'lorem ipsum', 13),
       (N'lorem ipsum', 14),
       (N'lorem ipsum', 15),
       (N'lorem ipsum', 6),
       (N'lorem ipsum', 7),
       (N'lorem ipsum', 8),
       (N'lorem ipsum', 9),
       (N'lorem ipsum', 10),
       (N'lorem ipsum', 11),
       (N'lorem ipsum', 12),
       (N'lorem ipsum', 13),
       (N'lorem ipsum', 14),
       (N'lorem ipsum', 15),
       (N'lorem ipsum', 6),
       (N'lorem ipsum', 7),
       (N'lorem ipsum', 8),
       (N'lorem ipsum', 9),
       (N'lorem ipsum', 10),
       (N'lorem ipsum', 11),
       (N'lorem ipsum', 12),
       (N'lorem ipsum', 13),
       (N'lorem ipsum', 14),
       (N'lorem ipsum', 15),
       (N'lorem ipsum', 6),
       (N'lorem ipsum', 7),
       (N'lorem ipsum', 8),
       (N'lorem ipsum', 9),
       (N'lorem ipsum', 10),
       (N'lorem ipsum', 11),
       (N'lorem ipsum', 12),
       (N'lorem ipsum', 13),
       (N'lorem ipsum', 14),
       (N'lorem ipsum', 15),
       (N'lorem ipsum', 6),
       (N'lorem ipsum', 7),
       (N'lorem ipsum', 8),
       (N'lorem ipsum', 9),
       (N'lorem ipsum', 10),
       (N'lorem ipsum', 11),
       (N'lorem ipsum', 12),
       (N'lorem ipsum', 13),
       (N'lorem ipsum', 14),
       (N'lorem ipsum', 15);
Go

SET IDENTITY_INSERT [dbo].[Award] ON

INSERT [dbo].[Award] ([AwardId], [AppID], [AwardTypeID], [AwardAmount], [AwardDate], [WasRecieved]) VALUES (1, 1, 1, 1000, CAST(N'2019-03-01T00:01:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Award] OFF
GO
SET IDENTITY_INSERT [dbo].[AwardType] ON

INSERT [dbo].[AwardType] ([AwardTypeId], [AwardTypeDesc]) VALUES (1, N'Cash')
SET IDENTITY_INSERT [dbo].[AwardType] OFF
GO
SET IDENTITY_INSERT [dbo].[Document] ON

INSERT [dbo].[Document] ([DocID], [AppID], [DocFile]) VALUES (1, 1, N'test.txt')
SET IDENTITY_INSERT [dbo].[Document] OFF
GO
SET IDENTITY_INSERT [dbo].[DocumentType] ON

INSERT [dbo].[DocumentType] ([DocTypeID], [DocTypeDesc]) VALUES (1, N'Text file')
SET IDENTITY_INSERT [dbo].[DocumentType] OFF
GO

SET IDENTITY_INSERT [dbo].[NoteType] ON

INSERT [dbo].[NoteType] ([NoteTypeID], [NoteTypeDesc]) VALUES (1, N'General Update')
SET IDENTITY_INSERT [dbo].[NoteType] OFF
GO

insert into note(NoteContent, NoteVisibility, NoteInternal, NoteCreatorUserId, CreatedDate, ApplicationId, NoteTypeId)
values  (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 3, 1),
        (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 4, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 5, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 6, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 7, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 8, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 9, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 10, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 11, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 12, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 13, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 14, 1),
       (N'Application been reviewed by admin', 1, 1, N'7e0b38c8-9d5b-45a5-b1b5-6b40385068b6', N'2022-12-01 00:00:00.0000000', 15, 1);
GO