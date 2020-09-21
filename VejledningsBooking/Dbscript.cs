//USE[master]
//GO
///****** Object:  Database [VejledningsBooking]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE DATABASE [VejledningsBooking]
//CONTAINMENT = NONE
// ON PRIMARY
//(NAME = N'VejledningsBooking', FILENAME = N'C:\Users\Nichlas\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\VejledningsBooking.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
// LOG ON
//(NAME = N'VejledningsBooking_log', FILENAME = N'C:\Users\Nichlas\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\VejledningsBooking.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
//GO
//ALTER DATABASE [VejledningsBooking] SET COMPATIBILITY_LEVEL = 130
//GO
//IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
//begin
//EXEC[VejledningsBooking].[dbo].[sp_fulltext_database] @action = 'enable'
//end
//GO
//ALTER DATABASE [VejledningsBooking] SET ANSI_NULL_DEFAULT ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET ANSI_NULLS ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET ANSI_PADDING ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET ANSI_WARNINGS ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET ARITHABORT ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET AUTO_CLOSE OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET AUTO_SHRINK OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET AUTO_UPDATE_STATISTICS ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET CURSOR_CLOSE_ON_COMMIT OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET CURSOR_DEFAULT  LOCAL 
//GO
//ALTER DATABASE [VejledningsBooking] SET CONCAT_NULL_YIELDS_NULL ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET NUMERIC_ROUNDABORT OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET QUOTED_IDENTIFIER ON 
//GO
//ALTER DATABASE [VejledningsBooking] SET RECURSIVE_TRIGGERS OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET DISABLE_BROKER 
//GO
//ALTER DATABASE [VejledningsBooking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET DATE_CORRELATION_OPTIMIZATION OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET TRUSTWORTHY OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET PARAMETERIZATION SIMPLE 
//GO
//ALTER DATABASE [VejledningsBooking] SET READ_COMMITTED_SNAPSHOT OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET HONOR_BROKER_PRIORITY OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET RECOVERY FULL 
//GO
//ALTER DATABASE [VejledningsBooking] SET MULTI_USER 
//GO
//ALTER DATABASE [VejledningsBooking] SET PAGE_VERIFY CHECKSUM  
//GO
//ALTER DATABASE [VejledningsBooking] SET DB_CHAINING OFF 
//GO
//ALTER DATABASE [VejledningsBooking] SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF)
//GO
//ALTER DATABASE [VejledningsBooking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
//GO
//ALTER DATABASE [VejledningsBooking] SET DELAYED_DURABILITY = DISABLED 
//GO
//ALTER DATABASE [VejledningsBooking] SET QUERY_STORE = OFF
//GO
//USE [VejledningsBooking]
//GO
//ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
//GO
//ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
//GO
//ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
//GO
//ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
//GO
//USE[VejledningsBooking]
//GO
///****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[__EFMigrationsHistory](

//[MigrationId][nvarchar](150) NOT NULL,

//[ProductVersion] [nvarchar](32) NOT NULL,
//CONSTRAINT[PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
//(
//	[MigrationId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Bookings]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Bookings](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[StudentId] [int] NOT NULL,

//[StartDateTime] [datetime2](7) NOT NULL,

//[EndDateTime] [datetime2](7) NOT NULL,
//CONSTRAINT[PK_Bookings] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Calenders]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Calenders](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[Description] [nvarchar](max)NULL,
// CONSTRAINT[PK_Calenders] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Hold]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Hold](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[Name] [nvarchar](max)NULL,
//	[CalenderId] [int] NULL,
// CONSTRAINT[PK_Hold] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[HoldLinjer]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[HoldLinjer](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[PersonId] [int] NULL,
//	[HoldId] [int] NULL,
// CONSTRAINT[PK_HoldLinjer] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Persons]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Persons](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[FirstName] [nvarchar](max)NULL,
//	[LastName] [nvarchar](max)NULL,
//	[Username] [nvarchar](max)NULL,
//	[Password] [nvarchar](max)NULL,
//	[Discriminator] [nvarchar](max)NOT NULL,
//	[Speciality] [nvarchar](max)NULL,
// CONSTRAINT[PK_Persons] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[StoredCookies]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[StoredCookies](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[Value] [nvarchar](max)NULL,
//	[PersonId] [int] NOT NULL,
// CONSTRAINT[PK_StoredCookies] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Timeslots]    Script Date: 21-09-2020 15:06:55 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Timeslots](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[TeacherId] [int] NOT NULL,

//[CalendarId] [int] NOT NULL,

//[BookingId] [int] NULL,
//	[StartDateTime] [datetime2](7) NOT NULL,
//	[EndDateTime] [datetime2](7) NOT NULL,
//	[RowVersion] [timestamp] NULL,
// CONSTRAINT[PK_Timeslots] PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY]
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'20200911175311_init', N'5.0.0-preview.8.20407.4')
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'20200913080603_Kage', N'5.0.0-preview.8.20407.4')
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'20200913090616_mib', N'5.0.0-preview.8.20407.4')
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'20200916125818_mib213123', N'5.0.0-preview.8.20407.4')
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'20200916195018_nono', N'5.0.0-preview.8.20407.4')
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'20200916195052_nono1', N'5.0.0-preview.8.20407.4')
//GO
//SET IDENTITY_INSERT [dbo].[Bookings] ON
//GO
//INSERT [dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1, 1, CAST(N'2020-09-17T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(4, 2002, CAST(N'2020-09-16T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-16T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1002, 2002, CAST(N'2020-09-16T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1003, 2002, CAST(N'2020-09-16T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1004, 2002, CAST(N'2020-09-17T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1005, 2002, CAST(N'2020-09-16T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1006, 2002, CAST(N'2020-09-16T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-16T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1007, 2002, CAST(N'2020-09-14T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1008, 2002, CAST(N'2020-09-14T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1009, 2002, CAST(N'2020-09-14T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1010, 2002, CAST(N'2020-09-14T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(1011, 2002, CAST(N'2020-09-14T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(2002, 2002, CAST(N'2020-09-16T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-16T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(2003, 2002, CAST(N'2020-09-17T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3003, 2002, CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3004, 2002, CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3005, 2002, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3006, 2002, CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3007, 2002, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3008, 2002, CAST(N'2020-09-18T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(3009, 2002, CAST(N'2020-09-18T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(4003, 2002, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(4004, 2002, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(4005, 2002, CAST(N'2020-09-17T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(4006, 2002, CAST(N'2020-09-17T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(5003, 2002, CAST(N'2020-09-17T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(5004, 2002, CAST(N'2020-09-17T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(5005, 2002, CAST(N'2020-09-17T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(5006, 2002, CAST(N'2020-09-17T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(5007, 2002, CAST(N'2020-09-17T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(5008, 2002, CAST(N'2020-09-17T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(6003, 2002, CAST(N'2020-09-17T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(6004, 2002, CAST(N'2020-09-17T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(6005, 2002, CAST(N'2020-09-17T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(6006, 2002, CAST(N'2020-09-17T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7003, 2002, CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7004, 2002, CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7005, 2002, CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7006, 2002, CAST(N'2020-09-17T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7007, 2002, CAST(N'2020-09-17T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7008, 2002, CAST(N'2020-09-17T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7009, 2002, CAST(N'2020-09-17T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7010, 2002, CAST(N'2020-09-17T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7011, 2002, CAST(N'2020-09-17T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7012, 2002, CAST(N'2020-09-17T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7013, 2002, CAST(N'2020-09-17T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7014, 2002, CAST(N'2020-09-17T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7015, 2002, CAST(N'2020-09-17T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7016, 2002, CAST(N'2020-09-18T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(7017, 2002, CAST(N'2020-09-18T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(8003, 2002, CAST(N'2020-09-18T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(8004, 2002, CAST(N'2020-09-18T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9003, 2002, CAST(N'2020-09-18T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9004, 2002, CAST(N'2020-09-18T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9005, 2002, CAST(N'2020-09-18T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9006, 2002, CAST(N'2020-09-18T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9007, 2002, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9008, 2002, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9009, 2002, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9010, 2002, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9011, 2002, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9012, 2002, CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9013, 2002, CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9014, 2002, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9015, 2002, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9016, 2002, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9017, 2002, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(9018, 2002, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(10003, 2002, CAST(N'2020-09-29T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(10004, 2002, CAST(N'2020-09-29T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(11003, 4002, CAST(N'2020-09-29T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Bookings] ([Id], [StudentId], [StartDateTime], [EndDateTime]) VALUES(11004, 4002, CAST(N'2020-09-30T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T09:30:00.0000000' AS DateTime2))
//GO
//SET IDENTITY_INSERT [dbo].[Bookings] OFF
//GO
//SET IDENTITY_INSERT [dbo].[Calenders] ON
//GO
//INSERT [dbo].[Calenders] ([Id], [Description]) VALUES(1, N'Den seje kalender')
//GO
//INSERT[dbo].[Calenders] ([Id], [Description]) VALUES(5, N'Mib')
//GO
//SET IDENTITY_INSERT [dbo].[Calenders] OFF
//GO
//SET IDENTITY_INSERT [dbo].[Hold] ON
//GO
//INSERT [dbo].[Hold] ([Id], [Name], [CalenderId]) VALUES(1, N'Dat19', 1)
//GO
//INSERT[dbo].[Hold] ([Id], [Name], [CalenderId]) VALUES(2, N'Dat20', 5)
//GO
//INSERT[dbo].[Hold] ([Id], [Name], [CalenderId]) VALUES(3, N'Dat21', NULL)
//GO
//SET IDENTITY_INSERT [dbo].[Hold] OFF
//GO
//SET IDENTITY_INSERT [dbo].[HoldLinjer] ON
//GO
//INSERT [dbo].[HoldLinjer] ([Id], [PersonId], [HoldId]) VALUES(1, 1002, 1)
//GO
//INSERT[dbo].[HoldLinjer] ([Id], [PersonId], [HoldId]) VALUES(2, 1002, 2)
//GO
//INSERT[dbo].[HoldLinjer] ([Id], [PersonId], [HoldId]) VALUES(1002, 2002, 1)
//GO
//INSERT[dbo].[HoldLinjer] ([Id], [PersonId], [HoldId]) VALUES(1003, 2002, 2)
//GO
//INSERT[dbo].[HoldLinjer] ([Id], [PersonId], [HoldId]) VALUES(2002, 5002, 2)
//GO
//INSERT[dbo].[HoldLinjer] ([Id], [PersonId], [HoldId]) VALUES(2003, 5003, 2)
//GO
//SET IDENTITY_INSERT [dbo].[HoldLinjer] OFF
//GO
//SET IDENTITY_INSERT [dbo].[Persons] ON
//GO
//INSERT [dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(1, N'777', N'88', N'85', N'88', N'Student', NULL)
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(2, N'hej', N'hej', N'hej', N'44', N'Teacher', N'55')
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(1002, N'Nichlas', N'Christensen', N'nillertron', N'123', N'Teacher', N'C#')
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(2002, N'Nichlas', N'Denseje', N'hejhej', N'123', N'Student', NULL)
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(3002, N'555', N'665', N'nillertron5', N'', N'Student', NULL)
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(4002, N'Test student', N'jeg er en test', N'test123', N'123', N'Student', NULL)
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(5002, N'Jens', N'Jensen', N'jens', N'jens', N'Teacher', N'C#')
//GO
//INSERT[dbo].[Persons] ([Id], [FirstName], [LastName], [Username], [Password], [Discriminator], [Speciality]) VALUES(5003, N'per', N'per', N'per', N'per', N'Teacher', N'per')
//GO
//SET IDENTITY_INSERT [dbo].[Persons] OFF
//GO
//SET IDENTITY_INSERT [dbo].[StoredCookies] ON
//GO
//INSERT [dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(1, N'75657890-b016-4eb5-8afc-dc7aad6fca4c', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(2, N'de43f8ea-d757-413a-b56b-73ae379b4172', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(3, N'a994c806-52c7-4930-b873-3c0a9eac8880', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(4, N'd2ff125e-837f-4d91-9b0a-dde466e5df36', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(1002, N'9874f24a-1266-458b-8ad3-69adc3f26b53', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(2002, N'309ea24e-b595-42e4-a47a-93f709c25b46', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(2003, N'5c0b86df-eac3-4873-9495-3fe0b661971c', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(3002, N'be979d3a-9656-4bac-b5f6-fb282b39ee2c', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(3003, N'9b827229-f669-4890-858d-9f0eeea0a5d0', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(4003, N'd39e5fad-33eb-4b7d-9357-e131503b4e0c', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(5003, N'194cea70-379e-481e-b404-581fd334910f', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(6003, N'9891b04c-0fbd-4afc-b541-9f122aa22c65', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(6004, N'365d8a3e-e41a-4016-bd10-e7aadf2c1ab5', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(6005, N'3adee854-f37c-4009-a5f5-7ba38f6c9285', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(7003, N'057e23dc-9895-4c78-8343-8f010d014b9c', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(7004, N'0809c380-311c-4e56-9520-fc06fa394715', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(8003, N'45b39922-9342-4681-9e90-628335f79199', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(8004, N'381b7ffd-db6f-44b3-a33d-4429a5360077', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(9003, N'dbd870aa-b3b4-4b09-83e6-a3e551132e54', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(9004, N'ae33000f-23dc-4e9e-b859-ec07fec90e91', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(10003, N'6d39b5bb-10b8-4889-ba4f-1a86f3757607', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(10004, N'd044a8ee-180a-44f8-b195-5ffc723804ba', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(11003, N'23ed49c9-f8b8-493f-a6df-cc726f854ae2', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(11004, N'447a6c6e-66a6-4c5b-8f22-76d63d993450', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(11005, N'0999fa11-9387-4d60-ac6f-ae46fb129277', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(11006, N'3088e190-bc88-45cb-8fa8-17d1c5c867d3', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(11007, N'79d27ce3-1fc0-4ecc-93bd-c93e03d5af0b', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(12003, N'a2649c76-83fd-4ce5-aa70-225036afd44e', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(12004, N'8788168b-bfae-4aa5-a931-375817c503b0', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13003, N'9559d641-56f3-4996-8495-d06594e8b1ee', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13004, N'2472702c-11ae-42c3-9812-e3d32d48cf29', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13005, N'940ba05f-9eb2-4158-a750-395232fa9dff', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13006, N'1bef84a0-9cb5-4dad-91fe-e1886e7de862', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13007, N'b43afbf8-fc2c-4207-a2c9-f87625907e20', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13008, N'e4141a7a-44b5-4fef-9971-f7c3dc58a0c8', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13009, N'2f3f9aab-9802-427c-b854-7586500a9187', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13010, N'b71daac3-b1ce-47c1-ab96-99b28e356f5a', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13011, N'59526cfa-07f8-41dd-b476-bc0bf5e70bb4', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13012, N'31622d0a-fb27-4c5a-867c-9bbbadc2188d', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13013, N'46468390-8a26-459f-acf3-b2e9cb1e45b2', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13014, N'4c723e0f-396e-4031-9d26-0bed33818266', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(13015, N'13d7cece-4193-4109-bdf8-89e7905253b1', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(14003, N'98675223-4ec4-493b-9866-ec1105b4295e', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(14004, N'c0a1e243-6520-40db-a3da-8483f3369e6c', 4002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(14005, N'9d42a8f2-889b-4bce-87fe-16804320d8de', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(14006, N'8c62a13b-dc3c-4e7c-b738-fa8505e02d96', 4002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(15004, N'44c2e067-d186-4d89-9bc2-6280fd13196b', 5002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(15005, N'9d828485-4eae-4607-98f6-ce9705d0a370', 5003)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(15006, N'7a83a349-6010-497d-bcc0-ec528893e322', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(15007, N'6a26f440-a08f-48dd-8e9d-5cc8f73996b6', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(15008, N'df7f1c65-9e37-4024-8c82-2cdeacf5138f', 2002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(15009, N'6e7530ff-d348-4aad-b57a-b2c0cf964d2a', 1002)
//GO
//INSERT[dbo].[StoredCookies] ([Id], [Value], [PersonId]) VALUES(16004, N'5445f706-7a9a-4dc5-b76c-dcde4b728636', 1002)
//GO
//SET IDENTITY_INSERT [dbo].[StoredCookies] OFF
//GO
//SET IDENTITY_INSERT [dbo].[Timeslots] ON
//GO
//INSERT [dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2, 1002, 1, 1, CAST(N'2020-09-17T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(1002, 1002, 1, 4, CAST(N'2020-09-16T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-16T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2002, 1002, 1, 1005, CAST(N'2020-09-16T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2003, 1002, 1, 1002, CAST(N'2020-09-16T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2004, 1002, 1, 1003, CAST(N'2020-09-16T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2005, 1002, 1, 1004, CAST(N'2020-09-17T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2006, 1002, 1, 1006, CAST(N'2020-09-16T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-16T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2007, 1002, 1, 1008, CAST(N'2020-09-14T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2008, 1002, 1, 1007, CAST(N'2020-09-14T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2009, 1002, 1, 1009, CAST(N'2020-09-14T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2010, 1002, 1, 1010, CAST(N'2020-09-14T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(2011, 1002, 1, 1011, CAST(N'2020-09-14T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-14T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3002, 1002, 1, NULL, CAST(N'2020-09-16T14:00:07.2580000' AS DateTime2), CAST(N'2020-09-16T14:30:07.2580000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3003, 1002, 1, NULL, CAST(N'2020-09-16T14:00:33.9410000' AS DateTime2), CAST(N'2020-09-16T14:30:33.9410000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3004, 1002, 1, NULL, CAST(N'2020-09-16T14:00:33.7450000' AS DateTime2), CAST(N'2020-09-16T14:30:33.7450000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3005, 1002, 1, NULL, CAST(N'2020-09-16T14:30:19.4030000' AS DateTime2), CAST(N'2020-09-16T15:00:19.4030000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3006, 1002, 1, NULL, CAST(N'2020-09-16T14:30:58.6020000' AS DateTime2), CAST(N'2020-09-16T15:00:58.6020000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3007, 1002, 1, 2002, CAST(N'2020-09-16T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-16T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(3008, 1002, 1, 2003, CAST(N'2020-09-17T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(4008, 1002, 1, 4004, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5008, 1002, 1, 3007, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5009, 1002, 1, NULL, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5010, 1002, 1, NULL, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5011, 1002, 1, NULL, CAST(N'2020-09-19T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-19T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5012, 1002, 1, NULL, CAST(N'2020-09-19T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-19T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5013, 1002, 1, NULL, CAST(N'2020-09-19T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-19T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5014, 1002, 1, NULL, CAST(N'2020-09-19T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-19T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5015, 1002, 1, NULL, CAST(N'2020-09-19T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-19T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5016, 1002, 1, NULL, CAST(N'2020-09-19T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-19T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5017, 1002, 1, NULL, CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5018, 1002, 1, NULL, CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5019, 1002, 1, 3006, CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5020, 1002, 1, NULL, CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5021, 1002, 1, NULL, CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T19:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5022, 1002, 1, NULL, CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T19:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5023, 1002, 1, NULL, CAST(N'2020-09-16T19:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T19:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5024, 1002, 1, 3005, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(5025, 1002, 1, NULL, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6008, 1002, 1, NULL, CAST(N'2020-09-16T20:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T20:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6009, 1002, 1, NULL, CAST(N'2020-09-16T20:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T20:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6010, 1002, 1, NULL, CAST(N'2020-09-16T20:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T20:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6011, 1002, 1, NULL, CAST(N'2020-09-16T20:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T20:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6012, 1002, 1, NULL, CAST(N'2020-09-16T20:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T20:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6013, 1002, 1, NULL, CAST(N'2020-09-16T20:00:00.0000000' AS DateTime2), CAST(N'2020-09-16T20:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6014, 1002, 1, 3004, CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6015, 1002, 1, 3009, CAST(N'2020-09-18T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(6016, 1002, 1, 3008, CAST(N'2020-09-18T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(7008, 1002, 1, 5004, CAST(N'2020-09-17T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(7009, 1002, 1, 4006, CAST(N'2020-09-17T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(8008, 1002, 1, 5008, CAST(N'2020-09-17T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(8009, 1002, 1, 5007, CAST(N'2020-09-17T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(8010, 1002, 1, 5006, CAST(N'2020-09-17T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(9008, 1002, 1, 6006, CAST(N'2020-09-17T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(9009, 1002, 1, 6004, CAST(N'2020-09-17T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10008, 1002, 1, 7015, CAST(N'2020-09-17T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10009, 1002, 1, 7013, CAST(N'2020-09-17T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10010, 1002, 1, 7011, CAST(N'2020-09-17T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10011, 1002, 1, 7009, CAST(N'2020-09-17T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10012, 1002, 1, 7005, CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-17T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10013, 1002, 1, 7007, CAST(N'2020-09-17T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-17T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10014, 1002, 1, 7017, CAST(N'2020-09-18T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10015, 1002, 1, 8003, CAST(N'2020-09-18T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10016, 1002, 1, 8004, CAST(N'2020-09-18T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(10017, 1002, 1, 9004, CAST(N'2020-09-18T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(11017, 1002, 1, 9006, CAST(N'2020-09-18T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(11018, 1002, 5, 9009, CAST(N'2020-09-18T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(11019, 1002, 5, 9011, CAST(N'2020-09-18T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(11020, 1002, 5, 9013, CAST(N'2020-09-18T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(11021, 1002, 5, 9018, CAST(N'2020-09-18T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(12015, 1002, 5, NULL, CAST(N'2020-09-18T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(12016, 1002, 5, NULL, CAST(N'2020-09-18T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(12017, 1002, 5, NULL, CAST(N'2020-09-18T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-18T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(12018, 1002, 5, NULL, CAST(N'2020-09-18T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-18T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(13015, 1002, 5, NULL, CAST(N'2020-09-25T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14015, 1002, 5, NULL, CAST(N'2020-10-01T08:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14016, 1002, 5, NULL, CAST(N'2020-10-01T08:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14017, 1002, 5, NULL, CAST(N'2020-10-01T09:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14018, 1002, 5, NULL, CAST(N'2020-10-01T09:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14019, 1002, 5, NULL, CAST(N'2020-10-01T10:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14020, 1002, 5, NULL, CAST(N'2020-10-01T10:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14021, 1002, 5, NULL, CAST(N'2020-10-01T11:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14022, 1002, 5, NULL, CAST(N'2020-10-01T11:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14023, 1002, 5, NULL, CAST(N'2020-10-01T12:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14024, 1002, 5, NULL, CAST(N'2020-10-01T12:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14025, 1002, 5, NULL, CAST(N'2020-10-01T13:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14026, 1002, 5, NULL, CAST(N'2020-10-01T13:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14027, 1002, 5, NULL, CAST(N'2020-10-01T14:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14028, 1002, 5, NULL, CAST(N'2020-10-01T14:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14029, 1002, 5, NULL, CAST(N'2020-10-01T15:00:00.0000000' AS DateTime2), CAST(N'2020-10-01T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14030, 1002, 5, NULL, CAST(N'2020-10-01T15:30:00.0000000' AS DateTime2), CAST(N'2020-10-01T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14031, 1002, 5, NULL, CAST(N'2020-10-02T08:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14032, 1002, 5, NULL, CAST(N'2020-10-02T08:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14033, 1002, 5, NULL, CAST(N'2020-10-02T09:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14034, 1002, 5, NULL, CAST(N'2020-10-02T09:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14035, 1002, 5, NULL, CAST(N'2020-10-02T10:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14036, 1002, 5, NULL, CAST(N'2020-10-02T10:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14037, 1002, 5, NULL, CAST(N'2020-10-02T11:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14038, 1002, 5, NULL, CAST(N'2020-10-02T11:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14039, 1002, 5, NULL, CAST(N'2020-10-02T12:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14040, 1002, 5, NULL, CAST(N'2020-10-02T12:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14041, 1002, 5, NULL, CAST(N'2020-10-02T13:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14042, 1002, 5, NULL, CAST(N'2020-10-02T13:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14043, 1002, 5, NULL, CAST(N'2020-10-02T14:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14044, 1002, 5, NULL, CAST(N'2020-10-02T14:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14045, 1002, 5, NULL, CAST(N'2020-10-02T15:00:00.0000000' AS DateTime2), CAST(N'2020-10-02T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14046, 1002, 5, NULL, CAST(N'2020-10-02T15:30:00.0000000' AS DateTime2), CAST(N'2020-10-02T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14047, 1002, 5, NULL, CAST(N'2020-09-28T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14048, 1002, 5, NULL, CAST(N'2020-09-28T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14049, 1002, 5, NULL, CAST(N'2020-09-28T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14050, 1002, 5, NULL, CAST(N'2020-09-28T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14051, 1002, 5, NULL, CAST(N'2020-09-28T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14052, 1002, 5, NULL, CAST(N'2020-09-28T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14053, 1002, 5, NULL, CAST(N'2020-09-28T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14054, 1002, 5, NULL, CAST(N'2020-09-28T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14055, 1002, 5, NULL, CAST(N'2020-09-28T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14056, 1002, 5, NULL, CAST(N'2020-09-28T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14057, 1002, 5, NULL, CAST(N'2020-09-28T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14058, 1002, 5, NULL, CAST(N'2020-09-28T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14059, 1002, 5, NULL, CAST(N'2020-09-28T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14060, 1002, 5, NULL, CAST(N'2020-09-28T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14061, 1002, 5, NULL, CAST(N'2020-09-28T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-28T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14062, 1002, 5, NULL, CAST(N'2020-09-28T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-28T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14063, 1002, 5, 10003, CAST(N'2020-09-29T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14064, 1002, 5, 10004, CAST(N'2020-09-29T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14065, 1002, 5, 11003, CAST(N'2020-09-29T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14066, 1002, 5, NULL, CAST(N'2020-09-29T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14067, 1002, 5, NULL, CAST(N'2020-09-29T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14068, 1002, 5, NULL, CAST(N'2020-09-29T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14069, 1002, 5, NULL, CAST(N'2020-09-29T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14070, 1002, 5, NULL, CAST(N'2020-09-29T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14071, 1002, 5, NULL, CAST(N'2020-09-29T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14072, 1002, 5, NULL, CAST(N'2020-09-29T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14073, 1002, 5, NULL, CAST(N'2020-09-29T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14074, 1002, 5, NULL, CAST(N'2020-09-29T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14075, 1002, 5, NULL, CAST(N'2020-09-29T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14076, 1002, 5, NULL, CAST(N'2020-09-29T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14077, 1002, 5, NULL, CAST(N'2020-09-29T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-29T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14078, 1002, 5, NULL, CAST(N'2020-09-29T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-29T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14079, 1002, 5, NULL, CAST(N'2020-09-30T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14080, 1002, 5, NULL, CAST(N'2020-09-30T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14081, 1002, 5, 11004, CAST(N'2020-09-30T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14082, 1002, 5, NULL, CAST(N'2020-09-30T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14083, 1002, 5, NULL, CAST(N'2020-09-30T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14084, 1002, 5, NULL, CAST(N'2020-09-30T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14085, 1002, 5, NULL, CAST(N'2020-09-30T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14086, 1002, 5, NULL, CAST(N'2020-09-30T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14087, 1002, 5, NULL, CAST(N'2020-09-30T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14088, 1002, 5, NULL, CAST(N'2020-09-30T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14089, 1002, 5, NULL, CAST(N'2020-09-30T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14090, 1002, 5, NULL, CAST(N'2020-09-30T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14091, 1002, 5, NULL, CAST(N'2020-09-30T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14092, 1002, 5, NULL, CAST(N'2020-09-30T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14093, 1002, 5, NULL, CAST(N'2020-09-30T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-30T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14094, 1002, 5, NULL, CAST(N'2020-09-30T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-30T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14095, 5002, 5, NULL, CAST(N'2020-09-25T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14096, 5002, 5, NULL, CAST(N'2020-09-25T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14337, 1002, 1, NULL, CAST(N'2020-09-21T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14338, 1002, 1, NULL, CAST(N'2020-09-21T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14339, 1002, 1, NULL, CAST(N'2020-09-21T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14340, 1002, 1, NULL, CAST(N'2020-09-21T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14341, 1002, 1, NULL, CAST(N'2020-09-21T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14342, 1002, 1, NULL, CAST(N'2020-09-21T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14343, 1002, 1, NULL, CAST(N'2020-09-21T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14344, 1002, 1, NULL, CAST(N'2020-09-21T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14345, 1002, 1, NULL, CAST(N'2020-09-21T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14346, 1002, 1, NULL, CAST(N'2020-09-21T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14347, 1002, 1, NULL, CAST(N'2020-09-21T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14348, 1002, 1, NULL, CAST(N'2020-09-21T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14349, 1002, 1, NULL, CAST(N'2020-09-21T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14350, 1002, 1, NULL, CAST(N'2020-09-21T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14351, 1002, 1, NULL, CAST(N'2020-09-21T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-21T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14352, 1002, 1, NULL, CAST(N'2020-09-21T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-21T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14353, 1002, 1, NULL, CAST(N'2020-09-22T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14354, 1002, 1, NULL, CAST(N'2020-09-22T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14355, 1002, 1, NULL, CAST(N'2020-09-22T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14356, 1002, 1, NULL, CAST(N'2020-09-22T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14357, 1002, 1, NULL, CAST(N'2020-09-22T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14358, 1002, 1, NULL, CAST(N'2020-09-22T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14359, 1002, 1, NULL, CAST(N'2020-09-22T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14360, 1002, 1, NULL, CAST(N'2020-09-22T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14361, 1002, 1, NULL, CAST(N'2020-09-22T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14362, 1002, 1, NULL, CAST(N'2020-09-22T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14363, 1002, 1, NULL, CAST(N'2020-09-22T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14364, 1002, 1, NULL, CAST(N'2020-09-22T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14365, 1002, 1, NULL, CAST(N'2020-09-22T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14366, 1002, 1, NULL, CAST(N'2020-09-22T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14367, 1002, 1, NULL, CAST(N'2020-09-22T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-22T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14368, 1002, 1, NULL, CAST(N'2020-09-22T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-22T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14369, 1002, 1, NULL, CAST(N'2020-09-23T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14370, 1002, 1, NULL, CAST(N'2020-09-23T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14371, 1002, 1, NULL, CAST(N'2020-09-23T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14372, 1002, 1, NULL, CAST(N'2020-09-23T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14373, 1002, 1, NULL, CAST(N'2020-09-23T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14374, 1002, 1, NULL, CAST(N'2020-09-23T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14375, 1002, 1, NULL, CAST(N'2020-09-23T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14376, 1002, 1, NULL, CAST(N'2020-09-23T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14377, 1002, 1, NULL, CAST(N'2020-09-23T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14378, 1002, 1, NULL, CAST(N'2020-09-23T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14379, 1002, 1, NULL, CAST(N'2020-09-23T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14380, 1002, 1, NULL, CAST(N'2020-09-23T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14381, 1002, 1, NULL, CAST(N'2020-09-23T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14382, 1002, 1, NULL, CAST(N'2020-09-23T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14383, 1002, 1, NULL, CAST(N'2020-09-23T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-23T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14384, 1002, 1, NULL, CAST(N'2020-09-23T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-23T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14385, 1002, 1, NULL, CAST(N'2020-09-24T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14386, 1002, 1, NULL, CAST(N'2020-09-24T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14387, 1002, 1, NULL, CAST(N'2020-09-24T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14388, 1002, 1, NULL, CAST(N'2020-09-24T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14389, 1002, 1, NULL, CAST(N'2020-09-24T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14390, 1002, 1, NULL, CAST(N'2020-09-24T10:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T11:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14391, 1002, 1, NULL, CAST(N'2020-09-24T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14392, 1002, 1, NULL, CAST(N'2020-09-24T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14393, 1002, 1, NULL, CAST(N'2020-09-24T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14394, 1002, 1, NULL, CAST(N'2020-09-24T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14395, 1002, 1, NULL, CAST(N'2020-09-24T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14396, 1002, 1, NULL, CAST(N'2020-09-24T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14397, 1002, 1, NULL, CAST(N'2020-09-24T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14398, 1002, 1, NULL, CAST(N'2020-09-24T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14399, 1002, 1, NULL, CAST(N'2020-09-24T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-24T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14400, 1002, 1, NULL, CAST(N'2020-09-24T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-24T16:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14401, 1002, 1, NULL, CAST(N'2020-09-25T08:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T08:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14402, 1002, 1, NULL, CAST(N'2020-09-25T08:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T09:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14403, 1002, 1, NULL, CAST(N'2020-09-25T09:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T09:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14404, 1002, 1, NULL, CAST(N'2020-09-25T09:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T10:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14405, 1002, 1, NULL, CAST(N'2020-09-25T10:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T10:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14406, 1002, 1, NULL, CAST(N'2020-09-25T11:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T11:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14407, 1002, 1, NULL, CAST(N'2020-09-25T11:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T12:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14408, 1002, 1, NULL, CAST(N'2020-09-25T12:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T12:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14409, 1002, 1, NULL, CAST(N'2020-09-25T12:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T13:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14410, 1002, 1, NULL, CAST(N'2020-09-25T13:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T13:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14411, 1002, 1, NULL, CAST(N'2020-09-25T13:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T14:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14412, 1002, 1, NULL, CAST(N'2020-09-25T14:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T14:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14413, 1002, 1, NULL, CAST(N'2020-09-25T14:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T15:00:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14414, 1002, 1, NULL, CAST(N'2020-09-25T15:00:00.0000000' AS DateTime2), CAST(N'2020-09-25T15:30:00.0000000' AS DateTime2))
//GO
//INSERT[dbo].[Timeslots] ([Id], [TeacherId], [CalendarId], [BookingId], [StartDateTime], [EndDateTime]) VALUES(14415, 1002, 1, NULL, CAST(N'2020-09-25T15:30:00.0000000' AS DateTime2), CAST(N'2020-09-25T16:00:00.0000000' AS DateTime2))
//GO
//SET IDENTITY_INSERT [dbo].[Timeslots] OFF
//GO
///****** Object:  Index [IX_Bookings_StudentId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_Bookings_StudentId] ON[dbo].[Bookings]
//(
//	[StudentId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_Hold_CalenderId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_Hold_CalenderId] ON[dbo].[Hold]
//(
//	[CalenderId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_HoldLinjer_HoldId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_HoldLinjer_HoldId] ON[dbo].[HoldLinjer]
//(
//	[HoldId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_HoldLinjer_PersonId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_HoldLinjer_PersonId] ON[dbo].[HoldLinjer]
//(
//	[PersonId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_StoredCookies_PersonId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_StoredCookies_PersonId] ON[dbo].[StoredCookies]
//(
//	[PersonId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_Timeslots_BookingId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_Timeslots_BookingId] ON[dbo].[Timeslots]
//(
//	[BookingId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_Timeslots_CalendarId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_Timeslots_CalendarId] ON[dbo].[Timeslots]
//(
//	[CalendarId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
///****** Object:  Index [IX_Timeslots_TeacherId]    Script Date: 21-09-2020 15:06:55 ******/
//CREATE NONCLUSTERED INDEX [IX_Timeslots_TeacherId] ON[dbo].[Timeslots]
//(
//	[TeacherId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//GO
//ALTER TABLE [dbo].[Bookings] ADD DEFAULT((0)) FOR[StudentId]
//GO
//ALTER TABLE [dbo].[StoredCookies] ADD DEFAULT((0)) FOR[PersonId]
//GO
//ALTER TABLE [dbo].[Timeslots] ADD DEFAULT((0)) FOR[TeacherId]
//GO
//ALTER TABLE [dbo].[Timeslots] ADD DEFAULT((0)) FOR[CalendarId]
//GO
//ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Persons_StudentId] FOREIGN KEY([StudentId])
//REFERENCES[dbo].[Persons]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT[FK_Bookings_Persons_StudentId]
//GO
//ALTER TABLE [dbo].[Hold]  WITH CHECK ADD  CONSTRAINT [FK_Hold_Calenders_CalenderId] FOREIGN KEY([CalenderId])
//REFERENCES[dbo].[Calenders]([Id])
//GO
//ALTER TABLE [dbo].[Hold] CHECK CONSTRAINT[FK_Hold_Calenders_CalenderId]
//GO
//ALTER TABLE [dbo].[HoldLinjer]  WITH CHECK ADD  CONSTRAINT [FK_HoldLinjer_Hold_HoldId] FOREIGN KEY([HoldId])
//REFERENCES[dbo].[Hold]([Id])
//GO
//ALTER TABLE [dbo].[HoldLinjer] CHECK CONSTRAINT[FK_HoldLinjer_Hold_HoldId]
//GO
//ALTER TABLE [dbo].[HoldLinjer]  WITH CHECK ADD  CONSTRAINT [FK_HoldLinjer_Persons_PersonId] FOREIGN KEY([PersonId])
//REFERENCES[dbo].[Persons]([Id])
//GO
//ALTER TABLE [dbo].[HoldLinjer] CHECK CONSTRAINT[FK_HoldLinjer_Persons_PersonId]
//GO
//ALTER TABLE [dbo].[StoredCookies]  WITH CHECK ADD  CONSTRAINT [FK_StoredCookies_Persons_PersonId] FOREIGN KEY([PersonId])
//REFERENCES[dbo].[Persons]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[StoredCookies] CHECK CONSTRAINT[FK_StoredCookies_Persons_PersonId]
//GO
//ALTER TABLE [dbo].[Timeslots]  WITH CHECK ADD  CONSTRAINT [FK_Timeslots_Bookings_BookingId] FOREIGN KEY([BookingId])
//REFERENCES[dbo].[Bookings]([Id])
//GO
//ALTER TABLE [dbo].[Timeslots] CHECK CONSTRAINT[FK_Timeslots_Bookings_BookingId]
//GO
//ALTER TABLE [dbo].[Timeslots]  WITH CHECK ADD  CONSTRAINT [FK_Timeslots_Calenders_CalendarId] FOREIGN KEY([CalendarId])
//REFERENCES[dbo].[Calenders]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[Timeslots] CHECK CONSTRAINT[FK_Timeslots_Calenders_CalendarId]
//GO
//ALTER TABLE [dbo].[Timeslots]  WITH CHECK ADD  CONSTRAINT [FK_Timeslots_Persons_TeacherId] FOREIGN KEY([TeacherId])
//REFERENCES[dbo].[Persons]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[Timeslots] CHECK CONSTRAINT[FK_Timeslots_Persons_TeacherId]
//GO
//USE [master]
//GO
//ALTER DATABASE [VejledningsBooking] SET READ_WRITE 
//GO
