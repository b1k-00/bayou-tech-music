USE [BayouTechMusic]
GO

/****** Object:  Table [dbo].[Songs]    Script Date: 4/28/2024 1:06:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Songs]') AND type in (N'U'))
DROP TABLE [dbo].[Songs]
GO

/****** Object:  Table [dbo].[Albums]    Script Date: 4/28/2024 1:07:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Albums]') AND type in (N'U'))
DROP TABLE [dbo].[Albums]
GO

/****** Object:  Table [dbo].[Artists]    Script Date: 4/28/2024 1:07:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Artists]') AND type in (N'U'))
DROP TABLE [dbo].[Artists]
GO


/****** Object:  Table [dbo].[MusicLabels]    Script Date: 4/28/2024 1:07:30 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MusicLabels]') AND type in (N'U'))
DROP TABLE [dbo].[MusicLabels]
GO




