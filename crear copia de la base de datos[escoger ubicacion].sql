USE [master]
GO
/****** Object:  Database [EfectiOroCopia]    Script Date: 19/06/2015 01:24:49 p.m. ******/
CREATE DATABASE [EfectiOroCopia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EfectiOroCopia', FILENAME = N'E:\OneDrive\EfectiOroCopia.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EfectiOroCopia_log', FILENAME = N'E:\OneDrive\EfectiOroCopia_log.ldf' , SIZE = 8384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EfectiOroCopia] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EfectiOroCopia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EfectiOroCopia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET ARITHABORT OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EfectiOroCopia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EfectiOroCopia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EfectiOroCopia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EfectiOroCopia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EfectiOroCopia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET RECOVERY FULL 
GO
ALTER DATABASE [EfectiOroCopia] SET  MULTI_USER 
GO
ALTER DATABASE [EfectiOroCopia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EfectiOroCopia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EfectiOroCopia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EfectiOroCopia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EfectiOro', N'ON'
GO
USE [EfectiOroCopia]
GO
/****** Object:  Table [dbo].[adelantos]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[adelantos](
	[idsalida] [varchar](20) NOT NULL,
	[codcliente] [varchar](20) NOT NULL,
	[numcompra] [varchar](max) NOT NULL,
	[fecha] [date] NOT NULL,
	[monto] [numeric](18, 2) NULL,
	[saldo] [numeric](18, 2) NOT NULL,
	[efectivo] [numeric](18, 2) NULL,
	[cheque] [numeric](18, 2) NULL,
	[transferencia] [numeric](18, 2) NULL,
	[codcaja] [varchar](10) NULL,
	[usuario] [varchar](50) NULL,
 CONSTRAINT [PK_adelantos] PRIMARY KEY CLUSTERED 
(
	[idsalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Agencia]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Agencia](
	[codagencia] [varchar](10) NOT NULL,
	[nomagencia] [varchar](150) NOT NULL,
	[diragencia] [varchar](max) NOT NULL,
	[disagencia] [varchar](100) NOT NULL,
	[telagencia] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Agencia] PRIMARY KEY CLUSTERED 
(
	[codagencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[caja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[caja](
	[codcaja] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_caja] PRIMARY KEY CLUSTERED 
(
	[codcaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[codcliente] [varchar](20) NOT NULL,
	[nombres] [varchar](35) NOT NULL,
	[apellidos] [varchar](50) NULL,
	[numcedula] [varchar](50) NOT NULL,
	[f_emision] [date] NULL,
	[f_vencimiento] [date] NULL,
	[direccion] [text] NOT NULL,
	[f_nacimiento] [date] NULL,
	[estadocivil] [varchar](20) NULL,
	[ciudad] [varchar](50) NULL,
	[telefono] [varchar](50) NOT NULL,
	[celular] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[f_ingreso] [date] NULL,
	[ocupacion] [varchar](50) NULL,
	[direccion_negocio] [text] NULL,
	[tiempo_neg] [varchar](50) NULL,
	[otra_ae] [varchar](50) NULL,
	[desc_otra] [text] NULL,
	[nom_cuenta] [varchar](50) NULL,
	[num_cuenta] [varchar](50) NULL,
	[nom_banco] [varchar](50) NULL,
	[monto_mensual] [money] NULL,
	[total_operaciones] [numeric](12, 3) NULL,
	[actua_por] [varchar](50) NULL,
	[nombre_tercero] [varchar](100) NULL,
	[direccion_tercero] [text] NULL,
	[pica] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[compras]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[compras](
	[codagencia] [varchar](10) NOT NULL,
	[numcompra] [varchar](20) NOT NULL,
	[codcliente] [varchar](20) NOT NULL,
	[codcaja] [varchar](10) NOT NULL,
	[peso] [decimal](11, 2) NOT NULL,
	[codmoneda] [varchar](10) NOT NULL,
	[total] [decimal](15, 2) NOT NULL,
	[fecha] [date] NOT NULL,
	[codestado] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[hora] [varchar](50) NOT NULL,
	[forma_pago] [varchar](50) NOT NULL,
	[dgnumdes] [int] NOT NULL,
	[efectivo] [numeric](18, 2) NOT NULL,
	[cheque] [numeric](18, 2) NOT NULL,
	[transferencia] [numeric](18, 2) NOT NULL,
	[por_cobrar] [numeric](18, 2) NOT NULL,
	[por_pagar] [numeric](18, 2) NOT NULL,
	[adelantos] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_compras] PRIMARY KEY CLUSTERED 
(
	[numcompra] ASC,
	[codcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[descargues]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[descargues](
	[dgcodage] [char](4) NOT NULL,
	[dgcodcaj] [char](7) NOT NULL,
	[dgusuari] [char](10) NOT NULL,
	[dgnumdes] [int] NOT NULL,
	[dgcancom] [int] NOT NULL,
	[dgpesbrt] [decimal](11, 2) NOT NULL,
	[dgpesntt] [decimal](11, 2) NOT NULL,
	[dgimptcom] [decimal](11, 2) NOT NULL,
	[dgfecdes] [date] NOT NULL,
	[dgfecgen] [date] NOT NULL,
 CONSTRAINT [PK_descargues] PRIMARY KEY CLUSTERED 
(
	[dgnumdes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[det_compra]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[det_compra](
	[numcompra] [varchar](20) NOT NULL,
	[descripcion] [varchar](30) NOT NULL,
	[kilate] [varchar](20) NOT NULL,
	[preciok] [numeric](18, 2) NOT NULL,
	[peso] [numeric](18, 2) NOT NULL,
	[importe] [numeric](18, 2) NULL,
	[linea] [int] NOT NULL,
	[kilshowdoc] [varchar](20) NULL,
 CONSTRAINT [PK_det_compra] PRIMARY KEY CLUSTERED 
(
	[kilate] ASC,
	[numcompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detacaja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detacaja](
	[idcaja] [numeric](18, 0) NOT NULL,
	[idmov] [int] NOT NULL,
	[hora] [varchar](50) NOT NULL,
	[fecha] [date] NULL,
	[concepto] [varchar](250) NULL,
	[efectivo] [numeric](18, 2) NULL,
	[referencia] [varchar](250) NULL,
	[cheque] [numeric](18, 2) NULL,
	[transferencia] [numeric](18, 2) NULL,
	[codcaja] [varchar](10) NULL,
 CONSTRAINT [PK_detacaja] PRIMARY KEY CLUSTERED 
(
	[idcaja] ASC,
	[idmov] ASC,
	[hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[codestado] [int] NOT NULL,
	[desc_estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[codestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[forma_pago]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[forma_pago](
	[idmov] [varchar](20) NOT NULL,
	[descripcion] [numeric](12, 2) NULL,
	[naturaleza] [numeric](12, 2) NULL,
 CONSTRAINT [PK_forma_pago] PRIMARY KEY CLUSTERED 
(
	[idmov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ids]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ids](
	[codcliente] [int] NOT NULL,
	[codagencia] [int] NULL,
	[numcompra] [int] NULL,
	[idadelanto] [int] NULL,
	[idcompras] [int] NULL,
	[id_adelantos] [int] NULL,
	[saldo_anterior] [int] NULL,
 CONSTRAINT [PK_Ids] PRIMARY KEY CLUSTERED 
(
	[codcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mcaja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mcaja](
	[idcaja] [numeric](18, 0) NOT NULL,
	[codcaja] [varchar](10) NOT NULL,
	[codagencia] [varchar](10) NULL,
	[fecha] [date] NULL,
	[sinicial] [numeric](18, 2) NULL,
	[entrada] [numeric](18, 2) NULL,
	[salida] [numeric](18, 2) NULL,
	[sfinal] [numeric](18, 2) NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_mcaja] PRIMARY KEY CLUSTERED 
(
	[idcaja] ASC,
	[codcaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[movcaja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movcaja](
	[idmov] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
	[codrubro] [int] NULL,
 CONSTRAINT [PK_movcaja] PRIMARY KEY CLUSTERED 
(
	[idmov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pagos_adelantados]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pagos_adelantados](
	[IdPagoefec] [int] NOT NULL,
	[Idingreso] [char](14) NOT NULL,
	[codagencia] [char](4) NULL,
	[fechaop_parcial] [date] NOT NULL,
	[valor_parcialpagado] [decimal](11, 2) NOT NULL,
	[usuario] [char](10) NOT NULL,
	[hora_op] [date] NOT NULL,
	[estado_op] [char](3) NOT NULL,
	[caja_regadel] [varchar](8) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pica]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pica](
	[codcliente] [varchar](20) NOT NULL,
	[nombre_entidad] [varchar](50) NOT NULL,
	[tipo_relacion] [varchar](50) NULL,
	[tiempo_mantener] [varchar](50) NULL,
	[ingreso_mensual] [money] NULL,
 CONSTRAINT [PK_Pica] PRIMARY KEY CLUSTERED 
(
	[codcliente] ASC,
	[nombre_entidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PrecioKilate]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PrecioKilate](
	[desc_kilate] [varchar](50) NOT NULL,
	[kilate_peso] [numeric](18, 2) NOT NULL,
	[precio_kilate] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_PrecioKilate] PRIMARY KEY CLUSTERED 
(
	[desc_kilate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Precios]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Precios](
	[descripcion] [varchar](50) NOT NULL,
	[kilate] [numeric](12, 3) NOT NULL,
	[precio] [numeric](12, 3) NOT NULL,
 CONSTRAINT [PK_Precios] PRIMARY KEY CLUSTERED 
(
	[kilate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReporteCaja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReporteCaja](
	[codagencia] [varchar](10) NOT NULL,
	[codrubro] [varchar](10) NOT NULL,
	[codoperador] [varchar](10) NOT NULL,
	[monto] [money] NOT NULL,
	[fecha] [date] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rubro]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rubro](
	[descrubro] [varchar](250) NOT NULL,
	[naturaleza] [int] NULL,
	[codrubro] [int] IDENTITY(10,10) NOT NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[codrubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rubros_caja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rubros_caja](
	[rucodrub] [char](2) NOT NULL,
	[rucodope] [char](2) NOT NULL,
	[rudescri] [char](60) NOT NULL,
	[rudeha] [char](1) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoCambio]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCambio](
	[fecha] [date] NOT NULL,
	[tipocambio] [numeric](12, 4) NOT NULL,
	[hora] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipoCambio] PRIMARY KEY CLUSTERED 
(
	[tipocambio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoPreciosPagados]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoPreciosPagados](
	[codprecio] [varchar](10) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[pesoinicial] [varchar](20) NOT NULL,
	[pesofinal] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TipoPreciosPagados] PRIMARY KEY CLUSTERED 
(
	[codprecio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[codoperador] [varchar](20) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[pregunta] [varchar](50) NOT NULL,
	[respuesta] [varchar](50) NOT NULL,
	[fcreau] [date] NOT NULL,
	[nivel] [int] NOT NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[codoperador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ClientePica]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ClientePica]
AS
SELECT        dbo.Cliente.codcliente, dbo.Cliente.nombres, dbo.Cliente.apellidos, dbo.Cliente.numcedula, dbo.Cliente.f_emision, dbo.Cliente.f_vencimiento, dbo.Cliente.direccion, 
                         dbo.Cliente.f_nacimiento, dbo.Cliente.estadocivil, dbo.Cliente.ciudad, dbo.Cliente.telefono, dbo.Cliente.celular, dbo.Cliente.email, dbo.Cliente.f_ingreso, 
                         dbo.Cliente.ocupacion, dbo.Cliente.direccion_negocio, dbo.Cliente.tiempo_neg, dbo.Cliente.otra_ae, dbo.Cliente.desc_otra, dbo.Cliente.nom_cuenta, 
                         dbo.Cliente.num_cuenta, dbo.Cliente.nom_banco, dbo.Cliente.monto_mensual, dbo.Cliente.total_operaciones, dbo.Cliente.actua_por, dbo.Cliente.nombre_tercero, 
                         dbo.Cliente.direccion_tercero, dbo.Cliente.pica, dbo.Pica.nombre_entidad, dbo.Pica.tipo_relacion, dbo.Pica.tiempo_mantener, dbo.Pica.ingreso_mensual
FROM            dbo.Cliente INNER JOIN
                         dbo.Pica ON dbo.Cliente.codcliente = dbo.Pica.codcliente

GO
/****** Object:  View [dbo].[compras_operador]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[compras_operador]
as
select u.nombre,c.numcompra,c.fecha,c.peso as peso_total,c.total,c.codcaja,
c.hora,dt.kilate,dt.peso,dt.importe,dt.preciok,c.codcliente
from compras c
join det_compra dt on c.numcompra = dt.numcompra
join usuario u on c.usuario = u.usuario
where c.codestado<>3
GO
/****** Object:  View [dbo].[descargueByCompra]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[descargueByCompra]
AS
SELECT        d.dgnumdes, d.dgfecdes, c.numcompra, c.fecha, c.codcliente, cli.nombres, cli.apellidos, c.peso, c.total, d.dgcancom AS Cantcompra
FROM            dbo.descargues AS d INNER JOIN
                         dbo.compras AS c ON d.dgnumdes = c.dgnumdes INNER JOIN
                         dbo.Cliente AS cli ON c.codcliente = cli.codcliente

GO
/****** Object:  View [dbo].[MovimientosCajaSelect]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[MovimientosCajaSelect]
as
select mc.estado,mc.codcaja,dc.hora,dc.fecha,dc.concepto,dc.efectivo,dc.cheque,dc.transferencia
 from detacaja dc join mcaja mc on dc.idcaja = mc.idcaja 


GO
/****** Object:  View [dbo].[rptMovimientosCaja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[rptMovimientosCaja]
as
select r.descrubro,m.descripcion,sum(dc.efectivo) as Efectivo,sum(dc.cheque) as cheque,
sum(dc.transferencia) as transferencia,dc.fecha 
from detacaja dc
join movcaja m on dc.idmov = m.idmov
join Rubro r on m.codrubro = r.codrubro
group by m.descripcion,dc.fecha,r.descrubro
GO
/****** Object:  View [dbo].[TransaccionEfectivo]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TransaccionEfectivo]
AS
select c.numcompra,cli.codcliente, cli.nombres,cli.apellidos,c.fecha,
iif(c.efectivo>0,'Efectivo',iif(c.cheque>0,'Cheque','Transferencia')) as FormaPago,c.total
from compras c join Cliente cli on c.codcliente = cli.codcliente
where c.efectivo >0 and c.transferencia=0 and c.adelantos=0 and c.cheque=0

GO
/****** Object:  View [dbo].[vdetacaja]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vdetacaja]
as
select dc.idcaja,dc.idmov,dc.hora,dc.fecha,dc.concepto,
iif(r.naturaleza=1,dc.efectivo,-1*dc.efectivo) as efectivo,IIF(r.naturaleza=1,dc.cheque,-1*dc.cheque) as cheque,
iif(r.naturaleza=1,dc.transferencia,-1*dc.transferencia) as transferencia, dc.codcaja,dc.referencia,
mc.sinicial,mc.sfinal
from detacaja dc
join mcaja mc on dc.idcaja = mc.idcaja
join movcaja m on dc.idmov = m.idmov
join rubro r on m.codrubro = r.codrubro
where dc.codcaja = mc.codcaja and mc.estado = 1


GO
/****** Object:  View [dbo].[vVariacionesCliente]    Script Date: 19/06/2015 01:24:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vVariacionesCliente]
AS
select cli.codcliente,cli.nombres, cli.apellidos, DATENAME(MONTH,c.fecha) as mes,
(cli.monto_mensual *tc.tipocambio) as Monto,SUM(c.total) as 'Monto Mensual',
(SUM(c.total)/(cli.monto_mensual *tc.tipocambio))*100 as Variacion,c.fecha
from compras c join det_compra dt on c.numcompra = dt.numcompra
join Cliente cli on c.codcliente = cli.codcliente join TipoCambio tc on c.fecha = tc.fecha
group by cli.codcliente, cli.nombres,cli.apellidos, DATENAME(month,c.fecha),cli.monto_mensual,tc.tipocambio,c.fecha



GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_usuario]    Script Date: 19/06/2015 01:24:49 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_usuario] ON [dbo].[usuario]
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[compras] ADD  CONSTRAINT [DF_compras_por_pagar]  DEFAULT ((0)) FOR [por_pagar]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'estado de la compra, en 1=inventario,2=descargado,0=anulado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'compras', @level2type=N'COLUMN',@level2name=N'codestado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'el usuario debe ser unico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'INDEX',@level2name=N'IX_usuario'
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
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pica"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
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
      Begin ColumnWidths = 34
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClientePica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClientePica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ClientePica'
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
         Begin Table = "d"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 259
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 0
               Left = 276
               Bottom = 313
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "cli"
            Begin Extent = 
               Top = 1
               Left = 585
               Bottom = 130
               Right = 794
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
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'descargueByCompra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'descargueByCompra'
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
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
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
      Begin ColumnWidths = 29
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TransaccionEfectivo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TransaccionEfectivo'
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
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dt"
            Begin Extent = 
               Top = 6
               Left = 301
               Bottom = 135
               Right = 526
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cli"
            Begin Extent = 
               Top = 6
               Left = 564
               Bottom = 135
               Right = 789
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tc"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 250
               Right = 263
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2370
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vVariacionesCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vVariacionesCliente'
GO
USE [master]
GO
ALTER DATABASE [EfectiOroCopia] SET  READ_WRITE 
GO
