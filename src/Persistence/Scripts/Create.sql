USE [BayouTechMusic]
GO

/****** Object:  Table [dbo].[MusicLabels]    Script Date: 4/24/2024 5:07:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MusicLabels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LabelName] [varchar](50) NOT NULL,
	[Owner] [varchar](50) NOT NULL,
	[Company] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MusicLabel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Artists]    Script Date: 4/24/2024 5:08:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Artists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtistName] [varchar](20) NOT NULL,
	[Genre] [varchar](20) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Origin] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Albums]    Script Date: 4/24/2024 5:09:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Albums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
	[ArtistId] [int] NOT NULL,
	[MusicLabelId] [int] NOT NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Albums]  WITH CHECK ADD  CONSTRAINT [FK_Albums_MusicLabels] FOREIGN KEY([MusicLabelId])
REFERENCES [dbo].[MusicLabels] ([Id])
GO

ALTER TABLE [dbo].[Albums] CHECK CONSTRAINT [FK_Albums_MusicLabels]
GO

/****** Object:  Table [dbo].[Songs]    Script Date: 4/24/2024 5:09:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Songs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[ArtistId] [int] NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
	[AlbumId] [int] NULL,
	[Feature] [varchar](50) NULL,
	[Producer] [varchar](50) NULL,
 CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Songs]  WITH CHECK ADD  CONSTRAINT [FK_Songs_Albums] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Albums] ([Id])
GO

ALTER TABLE [dbo].[Songs] CHECK CONSTRAINT [FK_Songs_Albums]
GO

ALTER TABLE [dbo].[Songs]  WITH CHECK ADD  CONSTRAINT [FK_Songs_Artists] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artists] ([Id])
GO

ALTER TABLE [dbo].[Songs] CHECK CONSTRAINT [FK_Songs_Artists]
GO


