USE [master]
GO
/****** Object:  Database [ProgrammingDB]    Script Date: 15.09.2019 23:16:36 ******/
CREATE DATABASE [ProgrammingDB]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProgrammingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProgrammingDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProgrammingDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProgrammingDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProgrammingDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProgrammingDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProgrammingDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProgrammingDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProgrammingDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProgrammingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProgrammingDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProgrammingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProgrammingDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProgrammingDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProgrammingDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProgrammingDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProgrammingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProgrammingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProgrammingDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProgrammingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProgrammingDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProgrammingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProgrammingDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProgrammingDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProgrammingDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProgrammingDB] SET DB_CHAINING OFF 
GO
USE [ProgrammingDB]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 15.09.2019 23:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[language] [nvarchar](50) NOT NULL,
	[founder] [nvarchar](50) NOT NULL,
	[year] [int] NOT NULL,
	[isPopular] [bit] NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 15.09.2019 23:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userKey] [uniqueidentifier] NULL CONSTRAINT [DF_Users_userKey]  DEFAULT (newid()),
	[name] [nvarchar](50) NULL,
	[role] [nvarchar](30) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (1, N'CSharp', N'Anders Hejlsberg', 2000, 1)
INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (2, N'Delphi', N'Anders Hejlsberg', 1995, 0)
INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (3, N'Java', N'James Gosling', 1995, 1)
INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (4, N'C', N'Dennis Ritche', 1972, 1)
INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (5, N'C++', N'Bjarne Stroustrup', 1983, 1)
INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (6, N'JavaScript', N'Brendan Eich', 1995, 1)
INSERT [dbo].[Languages] ([ID], [language], [founder], [year], [isPopular]) VALUES (11, N'New Language', N'Mustafa ÇEVİK', 2019, 1)
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [userKey], [name], [role]) VALUES (1, N'a5899cb0-b41f-4b80-93b6-3e285ae5221f', N'Mustafa ÇEVİK', N'Admin')
INSERT [dbo].[Users] ([ID], [userKey], [name], [role]) VALUES (2, N'4233ddf2-2f6a-49dc-8448-ce310a433f6e', N'Ali Baş', N'User')
SET IDENTITY_INSERT [dbo].[Users] OFF
USE [master]
GO
ALTER DATABASE [ProgrammingDB] SET  READ_WRITE 
GO
