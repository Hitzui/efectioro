﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdelantosAplicados
    Inherits EfectiOro.frmPersonalizado

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdelantosAplicados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAdelantos = New System.Windows.Forms.DataGridView()
        Me.colIdsalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodcaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listCompras = New System.Windows.Forms.ListBox()
        Me.menuDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblSaldoStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSaldoMayor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMenorSaldo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnAdelantoEfectivo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAdelantos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.menuDerecho.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(767, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(742, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFiltrar)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 38)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(8, 12)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(310, 20)
        Me.txtFiltrar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAdelantos)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 256)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgvAdelantos
        '
        Me.dgvAdelantos.AllowUserToAddRows = False
        Me.dgvAdelantos.AllowUserToDeleteRows = False
        Me.dgvAdelantos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAdelantos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAdelantos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdelantos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdsalida, Me.colCodcliente, Me.colNombres, Me.colFecha, Me.colHora, Me.colMonto, Me.colSaldo, Me.colCodcaja, Me.colUsuario})
        Me.dgvAdelantos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAdelantos.Location = New System.Drawing.Point(3, 16)
        Me.dgvAdelantos.Name = "dgvAdelantos"
        Me.dgvAdelantos.ReadOnly = True
        Me.dgvAdelantos.Size = New System.Drawing.Size(583, 237)
        Me.dgvAdelantos.TabIndex = 0
        '
        'colIdsalida
        '
        Me.colIdsalida.HeaderText = "Id Adelanto"
        Me.colIdsalida.Name = "colIdsalida"
        Me.colIdsalida.ReadOnly = True
        Me.colIdsalida.Width = 86
        '
        'colCodcliente
        '
        Me.colCodcliente.HeaderText = "Codigo cliente"
        Me.colCodcliente.Name = "colCodcliente"
        Me.colCodcliente.ReadOnly = True
        Me.colCodcliente.Width = 99
        '
        'colNombres
        '
        Me.colNombres.HeaderText = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        Me.colNombres.Width = 74
        '
        'colFecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 62
        '
        'colHora
        '
        Me.colHora.HeaderText = "Hora"
        Me.colHora.Name = "colHora"
        Me.colHora.ReadOnly = True
        Me.colHora.Width = 55
        '
        'colMonto
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colMonto.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        Me.colMonto.Width = 62
        '
        'colSaldo
        '
        DataGridViewCellStyle3.Format = "N2"
        Me.colSaldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.ReadOnly = True
        Me.colSaldo.Width = 59
        '
        'colCodcaja
        '
        Me.colCodcaja.HeaderText = "Codigo caja"
        Me.colCodcaja.Name = "colCodcaja"
        Me.colCodcaja.ReadOnly = True
        Me.colCodcaja.Width = 88
        '
        'colUsuario
        '
        Me.colUsuario.HeaderText = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Width = 68
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listCompras)
        Me.GroupBox3.Location = New System.Drawing.Point(599, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 300)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aplicado a compras"
        '
        'listCompras
        '
        Me.listCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listCompras.FormattingEnabled = True
        Me.listCompras.Location = New System.Drawing.Point(3, 16)
        Me.listCompras.Name = "listCompras"
        Me.listCompras.Size = New System.Drawing.Size(150, 281)
        Me.listCompras.TabIndex = 0
        '
        'menuDerecho
        '
        Me.menuDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerCompraToolStripMenuItem, Me.CopiarToolStripMenuItem})
        Me.menuDerecho.Name = "menuDerecho"
        Me.menuDerecho.Size = New System.Drawing.Size(136, 48)
        '
        'VerCompraToolStripMenuItem
        '
        Me.VerCompraToolStripMenuItem.Name = "VerCompraToolStripMenuItem"
        Me.VerCompraToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VerCompraToolStripMenuItem.Text = "Ver compra"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "9.PNG")
        Me.ImageList1.Images.SetKeyName(1, "analysis.png")
        Me.ImageList1.Images.SetKeyName(2, "finance51.png")
        Me.ImageList1.Images.SetKeyName(3, "printer.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSaldoStatus, Me.lblSaldoMayor, Me.lblMenorSaldo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 347)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(767, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblSaldoStatus
        '
        Me.lblSaldoStatus.ForeColor = System.Drawing.Color.White
        Me.lblSaldoStatus.Name = "lblSaldoStatus"
        Me.lblSaldoStatus.Size = New System.Drawing.Size(111, 17)
        Me.lblSaldoStatus.Text = "(Cantidad de Saldo)"
        '
        'lblSaldoMayor
        '
        Me.lblSaldoMayor.ForeColor = System.Drawing.Color.White
        Me.lblSaldoMayor.Name = "lblSaldoMayor"
        Me.lblSaldoMayor.Size = New System.Drawing.Size(121, 17)
        Me.lblSaldoMayor.Text = "ToolStripStatusLabel1"
        '
        'lblMenorSaldo
        '
        Me.lblMenorSaldo.ForeColor = System.Drawing.Color.White
        Me.lblMenorSaldo.Name = "lblMenorSaldo"
        Me.lblMenorSaldo.Size = New System.Drawing.Size(121, 17)
        Me.lblMenorSaldo.Text = "ToolStripStatusLabel1"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ImageIndex = 3
        Me.btnImprimir.ImageList = Me.ImageList1
        Me.btnImprimir.Location = New System.Drawing.Point(339, 31)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(57, 38)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.FlatAppearance.BorderSize = 0
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnular.ImageIndex = 0
        Me.btnAnular.ImageList = Me.ImageList1
        Me.btnAnular.Location = New System.Drawing.Point(402, 31)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(57, 38)
        Me.btnAnular.TabIndex = 9
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnAdelantoEfectivo
        '
        Me.btnAdelantoEfectivo.FlatAppearance.BorderSize = 0
        Me.btnAdelantoEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdelantoEfectivo.ImageIndex = 2
        Me.btnAdelantoEfectivo.ImageList = Me.ImageList1
        Me.btnAdelantoEfectivo.Location = New System.Drawing.Point(465, 31)
        Me.btnAdelantoEfectivo.Name = "btnAdelantoEfectivo"
        Me.btnAdelantoEfectivo.Size = New System.Drawing.Size(57, 38)
        Me.btnAdelantoEfectivo.TabIndex = 10
        Me.btnAdelantoEfectivo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(528, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAdelantosAplicados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(767, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdelantoEfectivo)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmAdelantosAplicados"
        Me.Controls.SetChildIndex(Me.StatusStrip1, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAnular, 0)
        Me.Controls.SetChildIndex(Me.btnAdelantoEfectivo, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAdelantos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.menuDerecho.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAdelantos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents menuDerecho As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblSaldoStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents colIdsalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodcaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSaldoMayor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMenorSaldo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnAnular As Button
    Friend WithEvents btnAdelantoEfectivo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents listCompras As ListBox
End Class
