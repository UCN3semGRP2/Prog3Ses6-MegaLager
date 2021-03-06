USE [master]
GO
/****** Object:  Database [MegaLager]    Script Date: 13-10-2017 12:35:01 ******/
CREATE DATABASE [MegaLager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MegaLager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\MegaLager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MegaLager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\MegaLager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MegaLager] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MegaLager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MegaLager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MegaLager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MegaLager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MegaLager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MegaLager] SET ARITHABORT OFF 
GO
ALTER DATABASE [MegaLager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MegaLager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MegaLager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MegaLager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MegaLager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MegaLager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MegaLager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MegaLager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MegaLager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MegaLager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MegaLager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MegaLager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MegaLager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MegaLager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MegaLager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MegaLager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MegaLager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MegaLager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MegaLager] SET  MULTI_USER 
GO
ALTER DATABASE [MegaLager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MegaLager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MegaLager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MegaLager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MegaLager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MegaLager] SET QUERY_STORE = OFF
GO
USE [MegaLager]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MegaLager]
GO
/****** Object:  Table [dbo].[Commercial]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commercial](
	[Id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[ean] [varchar](255) NOT NULL,
	[cvr] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Commercial] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Copy]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Copy](
	[id] [int] NOT NULL,
	[serial_no] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Copy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[phone] [varchar](255) NOT NULL,
	[customer_no] [varchar](255) NOT NULL,
	[address] [varchar](255) NOT NULL,
	[zip] [varchar](255) NOT NULL,
	[account_no] [varchar](255) NOT NULL,
	[type] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] NOT NULL,
	[order_date] [datetime] NOT NULL,
	[state] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orderline]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orderline](
	[Id] [int] NOT NULL,
	[amount] [int] NOT NULL,
 CONSTRAINT [PK_Orderline] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Private]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Private](
	[Id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
 CONSTRAINT [PK_Private] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 13-10-2017 12:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[supply] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Commercial]  WITH CHECK ADD  CONSTRAINT [FK_Commercial_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Commercial] CHECK CONSTRAINT [FK_Commercial_Customer]
GO
ALTER TABLE [dbo].[Private]  WITH CHECK ADD  CONSTRAINT [FK_Private_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Private] CHECK CONSTRAINT [FK_Private_Customer]
GO
USE [master]
GO
ALTER DATABASE [MegaLager] SET  READ_WRITE 
GO
