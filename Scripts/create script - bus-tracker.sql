USE [BusTracking]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 10/11/2019 02:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[VehicleId] [uniqueidentifier] NOT NULL,
	[CreatedById] [uniqueidentifier] NULL,
	[UpdatedById] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Locations]    Script Date: 10/11/2019 02:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationId] [uniqueidentifier] NOT NULL,
	[VehicleId] [uniqueidentifier] NOT NULL,
	[CreatedById] [uniqueidentifier] NULL,
	[UpdatedById] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[SessionId] [uniqueidentifier] NOT NULL,
	[Latitude] [decimal](18, 2) NOT NULL,
	[Longitude] [decimal](18, 2) NOT NULL,
	[TrackingTime] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



