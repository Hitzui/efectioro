﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
    Inherits EfectiOro.frmPersonalizado

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCerrarcompra = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumcompra = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grupoCliente = New System.Windows.Forms.GroupBox()
        Me.txtDircliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApecliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grupoItem = New System.Windows.Forms.GroupBox()
        Me.cmbPrecios2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grupoLista = New System.Windows.Forms.GroupBox()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.colLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.btnAdelantos = New System.Windows.Forms.Button()
        Me.txtAdelantos = New System.Windows.Forms.TextBox()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.txtPorpagar = New System.Windows.Forms.TextBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.checAdelantos = New System.Windows.Forms.CheckBox()
        Me.checTransferencias = New System.Windows.Forms.CheckBox()
        Me.checPorpagar = New System.Windows.Forms.CheckBox()
        Me.checCheque = New System.Windows.Forms.CheckBox()
        Me.checEfectivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvFiltrarCliente = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvBuscar_compra = New System.Windows.Forms.DataGridView()
        Me.colNumerocompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigocliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccionCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelBuscar_compra = New System.Windows.Forms.Panel()
        Me.txtFiltrar_compra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.panelHeader.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grupoCliente.SuspendLayout()
        Me.grupoItem.SuspendLayout()
        CType(Me.cmbPrecios2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoLista.SuspendLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvFiltrarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuscar_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBuscar_compra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(850, 25)
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.SystemColors.HotTrack
        Me.panelHeader.Controls.Add(Me.GroupBox3)
        Me.panelHeader.Controls.Add(Me.GroupBox2)
        Me.panelHeader.Controls.Add(Me.GroupBox1)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.ForeColor = System.Drawing.Color.White
        Me.panelHeader.Location = New System.Drawing.Point(0, 25)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(850, 80)
        Me.panelHeader.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCerrarcompra)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnNueva)
        Me.GroupBox3.Location = New System.Drawing.Point(529, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 70)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnCerrarcompra
        '
        Me.btnCerrarcompra.FlatAppearance.BorderSize = 0
        Me.btnCerrarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarcompra.ImageIndex = 2
        Me.btnCerrarcompra.ImageList = Me.ImageList1
        Me.btnCerrarcompra.Location = New System.Drawing.Point(247, 16)
        Me.btnCerrarcompra.Name = "btnCerrarcompra"
        Me.btnCerrarcompra.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarcompra.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.btnCerrarcompra, "Cerrar compras pendientes de pago")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "48.PNG")
        Me.ImageList1.Images.SetKeyName(1, "filesave.png")
        Me.ImageList1.Images.SetKeyName(2, "INSERT_TO_SHOPPING_CART.PNG")
        Me.ImageList1.Images.SetKeyName(3, "printer.png")
        Me.ImageList1.Images.SetKeyName(4, "REMOVE_FROM_SHOPPING_CART.PNG")
        Me.ImageList1.Images.SetKeyName(5, "shopping-48.png")
        Me.ImageList1.Images.SetKeyName(6, "shopping-add-481.png")
        Me.ImageList1.Images.SetKeyName(7, "shopping-cancel-48.png")
        Me.ImageList1.Images.SetKeyName(8, "shopping-edit-48.png")
        Me.ImageList1.Images.SetKeyName(9, "shopping-search-48.png")
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ImageIndex = 0
        Me.btnCancelar.ImageList = Me.ImageList1
        Me.btnCancelar.Location = New System.Drawing.Point(190, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.btnCancelar, "Cancelar compra")
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ImageIndex = 8
        Me.btnEditar.ImageList = Me.ImageList1
        Me.btnEditar.Location = New System.Drawing.Point(133, 16)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.btnEditar, "Editar compra")
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ImageIndex = 1
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(76, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.btnGuardar, "Guardar compra")
        '
        'btnNueva
        '
        Me.btnNueva.FlatAppearance.BorderSize = 0
        Me.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNueva.ImageIndex = 5
        Me.btnNueva.ImageList = Me.ImageList1
        Me.btnNueva.Location = New System.Drawing.Point(19, 16)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(40, 40)
        Me.btnNueva.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.btnNueva, "Nueva compra")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAnular)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnAnular
        '
        Me.btnAnular.Enabled = False
        Me.btnAnular.FlatAppearance.BorderSize = 0
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnular.ImageIndex = 4
        Me.btnAnular.ImageList = Me.ImageList1
        Me.btnAnular.Location = New System.Drawing.Point(151, 16)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(40, 40)
        Me.btnAnular.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.btnAnular, "Anular compra seleccionada")
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ImageIndex = 3
        Me.btnImprimir.ImageList = Me.ImageList1
        Me.btnImprimir.Location = New System.Drawing.Point(23, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(40, 40)
        Me.btnImprimir.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.btnImprimir, "Imprimir compra")
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ImageIndex = 9
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(87, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 40)
        Me.btnBuscar.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.btnBuscar, "Buscar compra segun numero de compra")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumcompra)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNumcompra
        '
        Me.txtNumcompra.Location = New System.Drawing.Point(138, 14)
        Me.txtNumcompra.Name = "txtNumcompra"
        Me.txtNumcompra.ReadOnly = True
        Me.txtNumcompra.Size = New System.Drawing.Size(140, 21)
        Me.txtNumcompra.TabIndex = 3
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(138, 40)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(140, 21)
        Me.txtFecha.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Fecha de Compra:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Número de Compra:"
        '
        'grupoCliente
        '
        Me.grupoCliente.Controls.Add(Me.txtDircliente)
        Me.grupoCliente.Controls.Add(Me.Label4)
        Me.grupoCliente.Controls.Add(Me.txtApecliente)
        Me.grupoCliente.Controls.Add(Me.Label3)
        Me.grupoCliente.Controls.Add(Me.txtNomcliente)
        Me.grupoCliente.Controls.Add(Me.Label2)
        Me.grupoCliente.Controls.Add(Me.txtCodcliente)
        Me.grupoCliente.Controls.Add(Me.Label1)
        Me.grupoCliente.Location = New System.Drawing.Point(12, 111)
        Me.grupoCliente.Name = "grupoCliente"
        Me.grupoCliente.Size = New System.Drawing.Size(826, 70)
        Me.grupoCliente.TabIndex = 2
        Me.grupoCliente.TabStop = False
        '
        'txtDircliente
        '
        Me.txtDircliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDircliente.Location = New System.Drawing.Point(472, 37)
        Me.txtDircliente.Name = "txtDircliente"
        Me.txtDircliente.Size = New System.Drawing.Size(341, 21)
        Me.txtDircliente.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Direccion:"
        '
        'txtApecliente
        '
        Me.txtApecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApecliente.Location = New System.Drawing.Point(314, 37)
        Me.txtApecliente.Name = "txtApecliente"
        Me.txtApecliente.Size = New System.Drawing.Size(152, 21)
        Me.txtApecliente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos:"
        '
        'txtNomcliente
        '
        Me.txtNomcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomcliente.Location = New System.Drawing.Point(156, 37)
        Me.txtNomcliente.Name = "txtNomcliente"
        Me.txtNomcliente.Size = New System.Drawing.Size(152, 21)
        Me.txtNomcliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtCodcliente
        '
        Me.txtCodcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodcliente.Location = New System.Drawing.Point(24, 37)
        Me.txtCodcliente.Name = "txtCodcliente"
        Me.txtCodcliente.Size = New System.Drawing.Size(126, 21)
        Me.txtCodcliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del cliente"
        '
        'grupoItem
        '
        Me.grupoItem.Controls.Add(Me.cmbPrecios2)
        Me.grupoItem.Controls.Add(Me.btnQuitar)
        Me.grupoItem.Controls.Add(Me.btnAgregar)
        Me.grupoItem.Controls.Add(Me.txtImporte)
        Me.grupoItem.Controls.Add(Me.Label8)
        Me.grupoItem.Controls.Add(Me.txtPeso)
        Me.grupoItem.Controls.Add(Me.Label7)
        Me.grupoItem.Controls.Add(Me.txtPrecio)
        Me.grupoItem.Controls.Add(Me.Label6)
        Me.grupoItem.Controls.Add(Me.Label5)
        Me.grupoItem.Location = New System.Drawing.Point(12, 187)
        Me.grupoItem.Name = "grupoItem"
        Me.grupoItem.Size = New System.Drawing.Size(826, 70)
        Me.grupoItem.TabIndex = 3
        Me.grupoItem.TabStop = False
        '
        'cmbPrecios2
        '
        Me.cmbPrecios2.Location = New System.Drawing.Point(24, 37)
        Me.cmbPrecios2.Name = "cmbPrecios2"
        Me.cmbPrecios2.Size = New System.Drawing.Size(170, 22)
        Me.cmbPrecios2.TabIndex = 10
        '
        'btnQuitar
        '
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.ImageIndex = 7
        Me.btnQuitar.ImageList = Me.ImageList1
        Me.btnQuitar.Location = New System.Drawing.Point(757, 19)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(56, 45)
        Me.btnQuitar.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.btnQuitar, "Quitar item de la llista")
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ImageIndex = 6
        Me.btnAgregar.ImageList = Me.ImageList1
        Me.btnAgregar.Location = New System.Drawing.Point(678, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(56, 45)
        Me.btnAgregar.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.btnAgregar, "Agregar item a la lista")
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(525, 36)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(140, 21)
        Me.txtImporte.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(522, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Importe:"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(368, 37)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(140, 21)
        Me.txtPeso.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Peso kilate:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(211, 37)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(140, 21)
        Me.txtPrecio.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Precio kilate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descripcion del kilate"
        '
        'grupoLista
        '
        Me.grupoLista.Controls.Add(Me.dgvCompras)
        Me.grupoLista.Location = New System.Drawing.Point(12, 263)
        Me.grupoLista.Name = "grupoLista"
        Me.grupoLista.Size = New System.Drawing.Size(826, 208)
        Me.grupoLista.TabIndex = 3
        Me.grupoLista.TabStop = False
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        Me.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCompras.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLinea, Me.colDescripcion, Me.colPeso, Me.colPrecio, Me.colImporte})
        Me.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCompras.Location = New System.Drawing.Point(3, 16)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.Size = New System.Drawing.Size(820, 189)
        Me.dgvCompras.TabIndex = 0
        '
        'colLinea
        '
        Me.colLinea.FillWeight = 30.0!
        Me.colLinea.HeaderText = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.FillWeight = 200.0!
        Me.colDescripcion.HeaderText = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'colPeso
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colPeso.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPeso.HeaderText = "Peso"
        Me.colPeso.Name = "colPeso"
        '
        'colPrecio
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colPrecio.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        '
        'colImporte
        '
        Me.colImporte.HeaderText = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.ReadOnly = True
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.btnAdelantos)
        Me.grupoDetalle.Controls.Add(Me.txtAdelantos)
        Me.grupoDetalle.Controls.Add(Me.txtTransferencia)
        Me.grupoDetalle.Controls.Add(Me.txtPorpagar)
        Me.grupoDetalle.Controls.Add(Me.txtCheque)
        Me.grupoDetalle.Controls.Add(Me.txtEfectivo)
        Me.grupoDetalle.Controls.Add(Me.checAdelantos)
        Me.grupoDetalle.Controls.Add(Me.checTransferencias)
        Me.grupoDetalle.Controls.Add(Me.checPorpagar)
        Me.grupoDetalle.Controls.Add(Me.checCheque)
        Me.grupoDetalle.Controls.Add(Me.checEfectivo)
        Me.grupoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDetalle.Location = New System.Drawing.Point(12, 477)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(399, 157)
        Me.grupoDetalle.TabIndex = 4
        Me.grupoDetalle.TabStop = False
        '
        'btnAdelantos
        '
        Me.btnAdelantos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdelantos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdelantos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdelantos.Location = New System.Drawing.Point(276, 118)
        Me.btnAdelantos.Name = "btnAdelantos"
        Me.btnAdelantos.Size = New System.Drawing.Size(110, 23)
        Me.btnAdelantos.TabIndex = 15
        Me.btnAdelantos.Text = "Ver adelantos"
        Me.btnAdelantos.Visible = False
        '
        'txtAdelantos
        '
        Me.txtAdelantos.Location = New System.Drawing.Point(129, 120)
        Me.txtAdelantos.Name = "txtAdelantos"
        Me.txtAdelantos.ReadOnly = True
        Me.txtAdelantos.Size = New System.Drawing.Size(141, 21)
        Me.txtAdelantos.TabIndex = 14
        Me.txtAdelantos.Visible = False
        '
        'txtTransferencia
        '
        Me.txtTransferencia.Location = New System.Drawing.Point(129, 94)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(141, 21)
        Me.txtTransferencia.TabIndex = 13
        Me.txtTransferencia.Visible = False
        '
        'txtPorpagar
        '
        Me.txtPorpagar.Location = New System.Drawing.Point(129, 68)
        Me.txtPorpagar.Name = "txtPorpagar"
        Me.txtPorpagar.Size = New System.Drawing.Size(141, 21)
        Me.txtPorpagar.TabIndex = 12
        Me.txtPorpagar.Visible = False
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(129, 42)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(141, 21)
        Me.txtCheque.TabIndex = 11
        Me.txtCheque.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(129, 16)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(141, 21)
        Me.txtEfectivo.TabIndex = 10
        Me.txtEfectivo.Visible = False
        '
        'checAdelantos
        '
        Me.checAdelantos.AutoSize = True
        Me.checAdelantos.Enabled = False
        Me.checAdelantos.Location = New System.Drawing.Point(16, 122)
        Me.checAdelantos.Name = "checAdelantos"
        Me.checAdelantos.Size = New System.Drawing.Size(80, 19)
        Me.checAdelantos.TabIndex = 4
        Me.checAdelantos.Text = "Adelantos"
        Me.checAdelantos.UseVisualStyleBackColor = True
        '
        'checTransferencias
        '
        Me.checTransferencias.AutoSize = True
        Me.checTransferencias.Location = New System.Drawing.Point(16, 94)
        Me.checTransferencias.Name = "checTransferencias"
        Me.checTransferencias.Size = New System.Drawing.Size(107, 19)
        Me.checTransferencias.TabIndex = 3
        Me.checTransferencias.Text = "Transferencias"
        Me.checTransferencias.UseVisualStyleBackColor = True
        '
        'checPorpagar
        '
        Me.checPorpagar.AutoSize = True
        Me.checPorpagar.Location = New System.Drawing.Point(16, 70)
        Me.checPorpagar.Name = "checPorpagar"
        Me.checPorpagar.Size = New System.Drawing.Size(80, 19)
        Me.checPorpagar.TabIndex = 2
        Me.checPorpagar.Text = "Por pagar"
        Me.checPorpagar.UseVisualStyleBackColor = True
        '
        'checCheque
        '
        Me.checCheque.AutoSize = True
        Me.checCheque.Location = New System.Drawing.Point(16, 42)
        Me.checCheque.Name = "checCheque"
        Me.checCheque.Size = New System.Drawing.Size(69, 19)
        Me.checCheque.TabIndex = 1
        Me.checCheque.Text = "Cheque"
        Me.checCheque.UseVisualStyleBackColor = True
        '
        'checEfectivo
        '
        Me.checEfectivo.AutoSize = True
        Me.checEfectivo.Location = New System.Drawing.Point(16, 16)
        Me.checEfectivo.Name = "checEfectivo"
        Me.checEfectivo.Size = New System.Drawing.Size(68, 19)
        Me.checEfectivo.TabIndex = 0
        Me.checEfectivo.Text = "Efectivo"
        Me.checEfectivo.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.txtTotal)
        Me.GroupBox9.Location = New System.Drawing.Point(550, 584)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(288, 50)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total de la compra:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(142, 16)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(140, 21)
        Me.txtTotal.TabIndex = 4
        '
        'ToolTip
        '
        '
        'dgvFiltrarCliente
        '
        Me.dgvFiltrarCliente.AllowUserToAddRows = False
        Me.dgvFiltrarCliente.AllowUserToDeleteRows = False
        Me.dgvFiltrarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFiltrarCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvFiltrarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltrarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colNombre, Me.colApellidos, Me.colDireccion})
        Me.dgvFiltrarCliente.Location = New System.Drawing.Point(36, 176)
        Me.dgvFiltrarCliente.Name = "dgvFiltrarCliente"
        Me.dgvFiltrarCliente.ReadOnly = True
        Me.dgvFiltrarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFiltrarCliente.Size = New System.Drawing.Size(440, 10)
        Me.dgvFiltrarCliente.TabIndex = 8
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 65
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombres"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 74
        '
        'colApellidos
        '
        Me.colApellidos.HeaderText = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        Me.colApellidos.Width = 74
        '
        'colDireccion
        '
        Me.colDireccion.HeaderText = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.ReadOnly = True
        Me.colDireccion.Width = 77
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'dgvBuscar_compra
        '
        Me.dgvBuscar_compra.AllowUserToAddRows = False
        Me.dgvBuscar_compra.AllowUserToDeleteRows = False
        Me.dgvBuscar_compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBuscar_compra.BackgroundColor = System.Drawing.Color.White
        Me.dgvBuscar_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_compra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumerocompra, Me.colCodigocliente, Me.colNombres, Me.colApellido, Me.colDireccionCli})
        Me.dgvBuscar_compra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBuscar_compra.Location = New System.Drawing.Point(0, 20)
        Me.dgvBuscar_compra.Name = "dgvBuscar_compra"
        Me.dgvBuscar_compra.ReadOnly = True
        Me.dgvBuscar_compra.Size = New System.Drawing.Size(387, 25)
        Me.dgvBuscar_compra.TabIndex = 9
        '
        'colNumerocompra
        '
        Me.colNumerocompra.HeaderText = "Numero compra"
        Me.colNumerocompra.Name = "colNumerocompra"
        Me.colNumerocompra.ReadOnly = True
        Me.colNumerocompra.Width = 98
        '
        'colCodigocliente
        '
        Me.colCodigocliente.HeaderText = "Codigo cliente"
        Me.colCodigocliente.Name = "colCodigocliente"
        Me.colCodigocliente.ReadOnly = True
        Me.colCodigocliente.Width = 91
        '
        'colNombres
        '
        Me.colNombres.HeaderText = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        Me.colNombres.Width = 74
        '
        'colApellido
        '
        Me.colApellido.HeaderText = "Apellidos"
        Me.colApellido.Name = "colApellido"
        Me.colApellido.ReadOnly = True
        Me.colApellido.Width = 74
        '
        'colDireccionCli
        '
        Me.colDireccionCli.HeaderText = "Direccion"
        Me.colDireccionCli.Name = "colDireccionCli"
        Me.colDireccionCli.ReadOnly = True
        Me.colDireccionCli.Width = 77
        '
        'panelBuscar_compra
        '
        Me.panelBuscar_compra.Controls.Add(Me.dgvBuscar_compra)
        Me.panelBuscar_compra.Controls.Add(Me.txtFiltrar_compra)
        Me.panelBuscar_compra.Location = New System.Drawing.Point(11, 70)
        Me.panelBuscar_compra.Name = "panelBuscar_compra"
        Me.panelBuscar_compra.Size = New System.Drawing.Size(387, 45)
        Me.panelBuscar_compra.TabIndex = 10
        Me.panelBuscar_compra.Visible = False
        '
        'txtFiltrar_compra
        '
        Me.txtFiltrar_compra.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFiltrar_compra.Location = New System.Drawing.Point(0, 0)
        Me.txtFiltrar_compra.Name = "txtFiltrar_compra"
        Me.txtFiltrar_compra.Size = New System.Drawing.Size(387, 20)
        Me.txtFiltrar_compra.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(431, 492)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Estado de la compra"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Vigente", "Cerrado"})
        Me.cmbEstado.Location = New System.Drawing.Point(541, 491)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(136, 21)
        Me.cmbEstado.TabIndex = 12
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(850, 646)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.panelBuscar_compra)
        Me.Controls.Add(Me.dgvFiltrarCliente)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Controls.Add(Me.grupoLista)
        Me.Controls.Add(Me.grupoItem)
        Me.Controls.Add(Me.grupoCliente)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "frmCompras"
        Me.Controls.SetChildIndex(Me.panelHeader, 0)
        Me.Controls.SetChildIndex(Me.grupoCliente, 0)
        Me.Controls.SetChildIndex(Me.grupoItem, 0)
        Me.Controls.SetChildIndex(Me.grupoLista, 0)
        Me.Controls.SetChildIndex(Me.grupoDetalle, 0)
        Me.Controls.SetChildIndex(Me.GroupBox9, 0)
        Me.Controls.SetChildIndex(Me.dgvFiltrarCliente, 0)
        Me.Controls.SetChildIndex(Me.panelBuscar_compra, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cmbEstado, 0)
        Me.panelHeader.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupoCliente.ResumeLayout(False)
        Me.grupoCliente.PerformLayout()
        Me.grupoItem.ResumeLayout(False)
        Me.grupoItem.PerformLayout()
        CType(Me.cmbPrecios2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoLista.ResumeLayout(False)
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.dgvFiltrarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuscar_compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBuscar_compra.ResumeLayout(False)
        Me.panelBuscar_compra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grupoCliente As System.Windows.Forms.GroupBox
    Friend WithEvents grupoItem As System.Windows.Forms.GroupBox
    Friend WithEvents grupoLista As System.Windows.Forms.GroupBox
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDircliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApecliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumcompra As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents checAdelantos As System.Windows.Forms.CheckBox
    Friend WithEvents checTransferencias As System.Windows.Forms.CheckBox
    Friend WithEvents checPorpagar As System.Windows.Forms.CheckBox
    Friend WithEvents checCheque As System.Windows.Forms.CheckBox
    Friend WithEvents checEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdelantos As System.Windows.Forms.TextBox
    Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtPorpagar As System.Windows.Forms.TextBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents dgvFiltrarCliente As System.Windows.Forms.DataGridView
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvBuscar_compra As System.Windows.Forms.DataGridView
    Friend WithEvents panelBuscar_compra As System.Windows.Forms.Panel
    Friend WithEvents colNumerocompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigocliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDireccionCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents btnNueva As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnEditar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btnImprimir As Button
    Private WithEvents btnAdelantos As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents btnQuitar As Button
    Private WithEvents txtFiltrar_compra As TextBox
    Private WithEvents btnAnular As Button
    Private WithEvents btnCerrarcompra As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cmbPrecios2 As Infragistics.Win.UltraWinGrid.UltraCombo
End Class