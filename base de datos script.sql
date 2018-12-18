USE [master]
GO
/****** Object:  Database [EfectiOro]    Script Date: 20/04/2015 14:07:07 ******/
CREATE DATABASE [EfectiOro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EfectiOro', FILENAME = N'C:\Nueva carpeta\EfectiOro.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EfectiOro_log', FILENAME = N'C:\Nueva carpeta\EfectiOro_log.ldf' , SIZE = 8384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EfectiOro] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EfectiOro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EfectiOro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EfectiOro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EfectiOro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EfectiOro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EfectiOro] SET ARITHABORT OFF 
GO
ALTER DATABASE [EfectiOro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EfectiOro] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EfectiOro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EfectiOro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EfectiOro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EfectiOro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EfectiOro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EfectiOro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EfectiOro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EfectiOro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EfectiOro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EfectiOro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EfectiOro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EfectiOro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EfectiOro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EfectiOro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EfectiOro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EfectiOro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EfectiOro] SET RECOVERY FULL 
GO
ALTER DATABASE [EfectiOro] SET  MULTI_USER 
GO
ALTER DATABASE [EfectiOro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EfectiOro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EfectiOro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EfectiOro] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EfectiOro', N'ON'
GO
USE [EfectiOro]
GO
/****** Object:  Table [dbo].[adelantos]    Script Date: 20/04/2015 14:07:07 ******/
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
 CONSTRAINT [PK_adelantos] PRIMARY KEY CLUSTERED 
(
	[idsalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Agencia]    Script Date: 20/04/2015 14:07:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Agencia](
	[codagencia] [varchar](10) NOT NULL,
	[nomagencia] [varchar](60) NOT NULL,
	[diragencia] [varchar](100) NOT NULL,
	[disagencia] [varchar](10) NOT NULL,
	[telagencia] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Agencia] PRIMARY KEY CLUSTERED 
(
	[codagencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[caja]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[compras]    Script Date: 20/04/2015 14:07:07 ******/
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
	[total] [decimal](15, 2) NULL,
	[fecha] [date] NOT NULL,
	[codestado] [int] NOT NULL,
	[usuario] [char](10) NOT NULL,
	[hora] [char](12) NOT NULL,
	[forma_pago] [varchar](50) NULL,
	[dgnumdes] [int] NULL,
	[efectivo] [numeric](18, 2) NULL,
	[cheque] [numeric](18, 2) NULL,
	[transferencia] [numeric](18, 2) NULL,
	[por_cobrar] [numeric](18, 2) NULL,
	[por_pagar] [numeric](18, 2) NULL,
	[adelantos] [numeric](18, 2) NULL,
 CONSTRAINT [PK_compras] PRIMARY KEY CLUSTERED 
(
	[numcompra] ASC,
	[codcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[descargues]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[det_compra]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[detacaja]    Script Date: 20/04/2015 14:07:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detacaja](
	[idcaja] [numeric](18, 0) NULL,
	[fecha] [date] NULL,
	[concepto] [varchar](250) NULL,
	[efectivo] [numeric](18, 2) NULL,
	[idmov] [int] NULL,
	[referencia] [varchar](250) NULL,
	[cheque] [numeric](18, 2) NULL,
	[transferencia] [numeric](18, 2) NULL,
	[hora] [varchar](50) NOT NULL,
 CONSTRAINT [PK_detacaja] PRIMARY KEY CLUSTERED 
(
	[hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[forma_pago]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[Ids]    Script Date: 20/04/2015 14:07:07 ******/
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
 CONSTRAINT [PK_Ids] PRIMARY KEY CLUSTERED 
(
	[codcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mcaja]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[movcaja]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[pagos_adelantados]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[Pica]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[PrecioKilate]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[Precios]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[ReporteCaja]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[Rubro]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[rubros_caja]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[TipoCambio]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[TipoPreciosPagados]    Script Date: 20/04/2015 14:07:07 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 20/04/2015 14:07:07 ******/
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
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_usuario]    Script Date: 20/04/2015 14:07:07 ******/
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
USE [master]
GO
ALTER DATABASE [EfectiOro] SET  READ_WRITE 
GO
