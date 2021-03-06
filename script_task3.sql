USE [master]
GO
/****** Object:  Database [MonthlyTransactions]    Script Date: 8.08.2019 04:51:31 ******/
CREATE DATABASE [MonthlyTransactions]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MonthlyTransactions', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MonthlyTransactions.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MonthlyTransactions_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MonthlyTransactions_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MonthlyTransactions] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MonthlyTransactions].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MonthlyTransactions] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET ARITHABORT OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MonthlyTransactions] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MonthlyTransactions] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MonthlyTransactions] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MonthlyTransactions] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MonthlyTransactions] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MonthlyTransactions] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MonthlyTransactions] SET  MULTI_USER 
GO
ALTER DATABASE [MonthlyTransactions] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MonthlyTransactions] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MonthlyTransactions] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MonthlyTransactions] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MonthlyTransactions] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MonthlyTransactions] SET QUERY_STORE = OFF
GO
USE [MonthlyTransactions]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MonthlyTransactions]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8.08.2019 04:51:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8.08.2019 04:51:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Icon] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 8.08.2019 04:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[TransactionType] [bit] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190806193216_mt', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190807150947_migration1', N'2.1.8-servicing-32085')
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (1, N'Salary', N'<i class="fas fa-briefcase fa-2x" style="color: blue"></i>')
INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (2, N'Car', N'<i class="fas fa-car fa-2x" style="color: red"></i>')
INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (3, N'Clothing', N'<i class="fas fa-tshirt fa-2x" style="color: green"></i>')
INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (4, N'Food', N'<i class="fas fa-hamburger fa-2x" style="color: orange"></i>')
INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (5, N'Leisure', N'<i class="fas fa-cocktail fa-2x" style="color: red"></i>')
INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (6, N'Living', N'<i class="fas fa-home fa-2x" style="color: black"></i>')
INSERT [dbo].[Categories] ([Id], [Name], [Icon]) VALUES (7, N'Others', N'<i class="fas fa-file fa-2x" style="color: black"></i>')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Transactions] ON 

INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (1, 1, N'July', CAST(N'2019-08-08T04:23:16.0828420' AS DateTime2), 1, CAST(4000.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (2, 2, N'Repair', CAST(N'2019-08-08T04:23:17.3679776' AS DateTime2), 0, CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (3, 3, N'New shoes', CAST(N'2019-08-08T04:23:17.8150062' AS DateTime2), 0, CAST(550.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (4, 4, N'McDonalds', CAST(N'2019-08-08T04:23:18.3210918' AS DateTime2), 0, CAST(120.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (5, 5, N'Lent Ahmet money', CAST(N'2019-08-08T04:23:18.3951504' AS DateTime2), 0, CAST(220.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (6, 6, N'Rent', CAST(N'2019-08-08T04:23:18.4667146' AS DateTime2), 0, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (7, 7, N'Gift', CAST(N'2019-08-08T04:23:18.4977394' AS DateTime2), 0, CAST(550.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (13, 2, N'new parts', CAST(N'2019-08-08T04:44:51.0000000' AS DateTime2), 0, CAST(170.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (14, 3, N'new dress', CAST(N'2019-08-08T04:45:41.0000000' AS DateTime2), 0, CAST(99.00 AS Decimal(18, 2)))
INSERT [dbo].[Transactions] ([Id], [CategoryId], [Description], [Date], [TransactionType], [Amount]) VALUES (15, 7, N'unknown', CAST(N'2019-08-08T04:46:08.0000000' AS DateTime2), 1, CAST(165.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Transactions] OFF
/****** Object:  Index [IX_Transactions_CategoryId]    Script Date: 8.08.2019 04:51:33 ******/
CREATE NONCLUSTERED INDEX [IX_Transactions_CategoryId] ON [dbo].[Transactions]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [MonthlyTransactions] SET  READ_WRITE 
GO
