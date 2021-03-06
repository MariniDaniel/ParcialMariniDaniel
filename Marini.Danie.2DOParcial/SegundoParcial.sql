USE [master]
GO
/****** Object:  Database [SegundoParcial]    Script Date: 24/11/2020 18:36:59 ******/
CREATE DATABASE [SegundoParcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SegundoParcial', FILENAME = N'E:\SQL2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\SegundoParcial.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SegundoParcial_log', FILENAME = N'E:\SQL2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\SegundoParcial_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SegundoParcial] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SegundoParcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SegundoParcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SegundoParcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SegundoParcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SegundoParcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SegundoParcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SegundoParcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SegundoParcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SegundoParcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SegundoParcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SegundoParcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SegundoParcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SegundoParcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SegundoParcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SegundoParcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SegundoParcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SegundoParcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SegundoParcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SegundoParcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SegundoParcial] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SegundoParcial] SET  MULTI_USER 
GO
ALTER DATABASE [SegundoParcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SegundoParcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SegundoParcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SegundoParcial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SegundoParcial] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SegundoParcial] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SegundoParcial] SET QUERY_STORE = OFF
GO
USE [SegundoParcial]
GO
/****** Object:  Table [dbo].[HeladosYa]    Script Date: 24/11/2020 18:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeladosYa](
	[gustoHelado] [nvarchar](50) NOT NULL,
	[numeroPedido] [nvarchar](50) NOT NULL,
	[conEnvio] [nvarchar](50) NOT NULL,
	[domicilioEntrega] [nvarchar](50) NOT NULL,
	[telefonoEntrega] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102925', N'Si', N'Uruguay 2049', N'011 11122323')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'BananaSplit', N'102926', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'102927', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'102928', N'Si', N'Pellegrini 1752', N'4532234')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Frutilla', N'102929', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'102930', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'102931', N'Si', N'Siempre Viva 23', N'43212223')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'102932', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'102933', N'Si', N'Calchaqui 232', N'42645448')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102934', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102935', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Frutilla', N'102936', N'Si', N'Conesa 200', N'20052091')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'102937', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'102938', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'110129', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'BananaSplit', N'110134', N'Si', N'123123', N'31231')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'110139', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'110152', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
GO
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'102933', N'Si', N'Calchaqui 232', N'42645448')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102934', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102935', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Frutilla', N'102936', N'Si', N'Conesa 200', N'20052091')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'102937', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'102938', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102925', N'Si', N'Uruguay 2049', N'011 11122323')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'BananaSplit', N'102926', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'102927', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'102928', N'Si', N'Pellegrini 1752', N'4532234')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Frutilla', N'102929', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'102930', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'102931', N'Si', N'Siempre Viva 23', N'43212223')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'102932', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'113349', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'114026', N'Si', N'123123', N'123123')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'114049', N'Si', N'123123', N'123123')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'114104', N'Si', N'123123', N'123123')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'114352', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
GO
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'BananaSplit', N'102926', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'102927', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'102928', N'Si', N'Pellegrini 1752', N'4532234')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Frutilla', N'102929', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'102930', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'102931', N'Si', N'Siempre Viva 23', N'43212223')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Limon', N'102932', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'102933', N'Si', N'Calchaqui 232', N'42645448')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102934', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102935', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Frutilla', N'102936', N'Si', N'Conesa 200', N'20052091')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Oreo', N'102937', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'CremaDelCielo', N'102938', N'No', N'SIN DIRECCION', N'SIN TELEFONO')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'DulceDeLeche', N'162127', N'Si', N'Pepito juarez 20', N'5002 2323')
INSERT [dbo].[HeladosYa] ([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) VALUES (N'Almendrado', N'102925', N'Si', N'Uruguay 2049', N'011 11122323')
GO
USE [master]
GO
ALTER DATABASE [SegundoParcial] SET  READ_WRITE 
GO
