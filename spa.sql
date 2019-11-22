USE [master]
GO
/****** Object:  Database [Spa]    Script Date: 22/11/2019 00:16:09 ******/
CREATE DATABASE [Spa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Spa', FILENAME = N'C:\Users\Diego\Spa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Spa_log', FILENAME = N'C:\Users\Diego\Spa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Spa] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Spa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Spa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Spa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Spa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Spa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Spa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Spa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Spa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Spa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Spa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Spa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Spa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Spa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Spa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Spa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Spa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Spa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Spa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Spa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Spa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Spa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Spa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Spa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Spa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Spa] SET  MULTI_USER 
GO
ALTER DATABASE [Spa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Spa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Spa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Spa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Spa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Spa] SET QUERY_STORE = OFF
GO
USE [Spa]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Spa]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [bigint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Telefono] [bigint] NULL,
	[Email] [varchar](70) NULL,
	[Direccion] [varchar](100) NULL,
	[Localidad] [varchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tratamiento]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tratamiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Tratamiento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdTratamiento] [int] NOT NULL,
	[HoraInicio] [datetime] NOT NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Turno]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Turno]
AS
SELECT dbo.Turno.Id AS Nro, FORMAT(dbo.Turno.HoraInicio, 'dd/MM/yy') AS Fecha, FORMAT(dbo.Turno.HoraInicio, 'hh:mm') AS Hora, dbo.Tratamiento.Nombre AS Tratamiento, dbo.Cliente.Apellido + ', ' + dbo.Cliente.Nombre AS Cliente, dbo.Cliente.DNI
FROM   dbo.Turno INNER JOIN
             dbo.Tratamiento ON dbo.Turno.IdTratamiento = dbo.Tratamiento.Id INNER JOIN
             dbo.Cliente ON dbo.Turno.IdCliente = dbo.Cliente.Id
GO
/****** Object:  View [dbo].[View_Cliente]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Cliente]
AS
SELECT Apellido + ', ' + Nombre + ' - DNI: ' + LTRIM(STR(DNI)) AS Cliente, Id
FROM   dbo.Cliente
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([Id], [DNI], [Nombre], [Apellido], [Telefono], [Email], [Direccion], [Localidad]) VALUES (1, 379913714, N'Diego', N'Balderrama', 1168073232, N'diego-balderrama93@gmail.com', N'Calle Falsa 123', N'Ituzaingo')
GO
INSERT [dbo].[Cliente] ([Id], [DNI], [Nombre], [Apellido], [Telefono], [Email], [Direccion], [Localidad]) VALUES (2, 30212211, N'Maria', N'Pérez', 1165654565, N'm.perez@live.com', N'Av. Rivadavia 300', N'CABA')
GO
INSERT [dbo].[Cliente] ([Id], [DNI], [Nombre], [Apellido], [Telefono], [Email], [Direccion], [Localidad]) VALUES (3, 25654222, N'Lucas', N'Gutierrez', 1165453320, N'lucas.gu@gmail.com', N'Florida 200', N'Morón')
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Tratamiento] ON 
GO
INSERT [dbo].[Tratamiento] ([Id], [Nombre]) VALUES (1, N'Criolipolisis')
GO
INSERT [dbo].[Tratamiento] ([Id], [Nombre]) VALUES (2, N'Masaje deportivo')
GO
INSERT [dbo].[Tratamiento] ([Id], [Nombre]) VALUES (3, N'Depilación')
GO
SET IDENTITY_INSERT [dbo].[Tratamiento] OFF
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 
GO
INSERT [dbo].[Turno] ([Id], [IdCliente], [IdTratamiento], [HoraInicio]) VALUES (1, 1, 1, CAST(N'2019-09-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Turno] ([Id], [IdCliente], [IdTratamiento], [HoraInicio]) VALUES (2, 3, 1, CAST(N'2019-11-28T23:20:17.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Cliente]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Tratamiento] FOREIGN KEY([IdTratamiento])
REFERENCES [dbo].[Tratamiento] ([Id])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Tratamiento]
GO
/****** Object:  StoredProcedure [dbo].[SP_Cliente_Agregar]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SP_Cliente_Agregar] 
	-- Add the parameters for the stored procedure here
	@nombre varchar(50) = '', 
	@apellido varchar(50) = '',
	@dni varchar(50) = '', 
	@email varchar(50) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Cliente(Nombre,Apellido,DNI,Email) values (@nombre, @apellido,@dni,@email)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Cliente_Borrar]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SP_Cliente_Borrar] 
	-- Add the parameters for the stored procedure here
	@idCliente int = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Cliente WHERE Id=@idCliente

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Cliente_Editar]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SP_Cliente_Editar] 
	-- Add the parameters for the stored procedure here
	@idCliente int,
	@nombre varchar(50), 
	@apellido varchar(50),
	@DNI varchar(50),
	@email varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Cliente SET Nombre = @nombre, 
	Apellido=@apellido, 
	DNI=@DNI,
	Email=@email
	where Id = @idCliente;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Turno_Agregar]    Script Date: 22/11/2019 00:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SP_Turno_Agregar] 
	-- Add the parameters for the stored procedure here
	@idCliente int = 0, 
	@idTratamiento int = 0,
	@hora datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Turno(IdCliente,IdTratamiento,HoraInicio) values (@idCliente, @idTratamiento,@hora)

END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[22] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 3300
         Width = 1640
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2480
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Turno"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tratamiento"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 152
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Turno'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Turno'
GO
USE [master]
GO
ALTER DATABASE [Spa] SET  READ_WRITE 
GO
