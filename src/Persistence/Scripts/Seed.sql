USE [BayouTechMusic]
GO


--- Insert values into Music Labels Table ----

INSERT INTO [dbo].[MusicLabels]
           ([LabelName]
           ,[Owner]
           ,[Company])
     VALUES
           ('Mo-Town Records',
           'Berry Gordy'
           ,'Universal Music Group')
GO


---- Insert values into Artist Labels Table ----

INSERT INTO [dbo].[Artists]
           ([ArtistName]
           ,[Genre]
           ,[BirthDate]
           ,[Origin])
     VALUES
           ('Rick James'
           ,'Pop'
           ,'1948-02-01 06:00:00'
           ,'Buffalo, New York')
GO


---- Insert values into Album Table ----

INSERT INTO [dbo].[Albums]
           ([Title]
           ,[ReleaseDate]
           ,[ArtistId]
           ,[MusicLabelId])
     VALUES
           ('Street Songs'
           ,'1981-04-07 06:00:00'
           ,0
           ,0)

GO

---- Insert values into Song Table ----



INSERT INTO [dbo].[Songs]
           ([Title]
           ,[ArtistId]
           ,[ReleaseDate]
           ,[AlbumId]
           ,[Feature]
           ,[Producer])
     VALUES
           ('Give It To Me Baby'
           ,0
           ,'1981-01-20 06:00:00'
           ,0
           ,NULL
           ,'Rick James')

GO


