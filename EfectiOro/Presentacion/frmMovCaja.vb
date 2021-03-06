﻿Imports EfectiOro.Database

Public Class frmMovCaja
    Dim FORMATO_DECIMAL As String = "#,###,#00.00"
    Dim cajaActual As String
    Dim agenciaActual As String
    Dim idmovimiento As Integer
    Dim recIdmov As Integer
    Private revMovcaja As Movcaja
    Private Function validarMovmientoCaja(movimiento As Integer) As Boolean
        Try
            Dim daoIds = DataContext.daoParametros
            Dim recIds = daoIds.recuperarParametros()
            Select Case movimiento
                Case recIds.Id_adelantos
                    MsgBox("No pude realizar adelantos en el moduo de caja", MsgBoxStyle.Exclamation, "Caja")
                    Return False
                Case recIds.Idcompras
                    MsgBox("No pude realizar compras en el moduo de caja", MsgBoxStyle.Exclamation, "Caja")
                    Return False
                Case recIds.Cierre_compra
                    MsgBox("No pude realizar abonos a compras en el moduo de caja", MsgBoxStyle.Exclamation, "Caja")
                    Return False
            End Select
            Return True
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Sub cargarSaldosCaja()
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        Dim xcaja As Mcaja = dao.recuperarSaldoCaja(cajaActual)
        lblSaldo.Text = xcaja.Sfinal.ToString(Me.FORMATO_DECIMAL)
        lblInicial.Text = xcaja.Sinicial.ToString(Me.FORMATO_DECIMAL)
        lblEntrada.Text = xcaja.Entrada.ToString(Me.FORMATO_DECIMAL)
        lblSalida.Text = xcaja.Salida.ToString(Me.FORMATO_DECIMAL)
        Try
            If dao.ErrorSms.Length > 0 Then
                MsgBox("Se produjo un error al intentar recuper el saldo de la caja. Revise la siguiente información: " &
                       vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub revisarEstadoCaja()
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        If dao.estadoCaja(cajaActual) = True Then
            btnAbrirCaja.Enabled = False
            btnCerrarCaja.Enabled = True
            cargarSaldosCaja()
        Else
            btnCerrarCaja.Enabled = False
            btnAbrirCaja.Enabled = True
        End If
    End Sub

    Sub cargarCaja()
        Dim config As New ConfiguracionGeneral()
        Me.cajaActual = config.getCaja()
        Me.agenciaActual = config.getAgencia()
        'MsgBox("Caja: " & cajaActual)
    End Sub
    Private Sub frmMovCaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnClose.Visible = False
        Me.cargarCaja()
        lblTitulo.Text = "Movimientos del Día - " & cajaActual
        lblFecha.Text = Now.ToShortDateString()
        llenarCombo()
        Me.revisarEstadoCaja()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        lblHora.Text = Now.ToLongTimeString()
    End Sub

#Region "KeyChar y TextChange"
    Private Sub txtReferencias_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReferencias.KeyPress
        ServiciosBasicos.keyCharEnter(txtMonto, e)
    End Sub

    Private Sub txtMonto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                cmbRubro.Focus()
                e.Handled = True
        End Select
        ServiciosBasicos.TextBoxNumeric_KeyPress(sender, e)
    End Sub

    Private Sub cmbRubro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRubro.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                e.Handled = True
                'aqui el boton de guardar
        End Select
    End Sub

    Private Sub txtReferencias_Enter(sender As System.Object, e As System.EventArgs) Handles txtReferencias.Enter
        ServiciosBasicos.colorDeFondoInfo(txtReferencias)
    End Sub

    Private Sub txtMonto_Enter(sender As System.Object, e As System.EventArgs) Handles txtMonto.Enter
        ServiciosBasicos.colorDeFondoInfo(txtMonto)
    End Sub

    Private Sub txtReferencias_Leave(sender As System.Object, e As System.EventArgs) Handles txtReferencias.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtReferencias)
    End Sub

    Private Sub txtMonto_Leave(sender As System.Object, e As System.EventArgs) Handles txtMonto.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtMonto)
    End Sub

    Private Sub txtReferencias_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReferencias.TextChanged
        If txtReferencias.TextLength > 0 Then
            erp.SetError(txtReferencias, "")
        End If
    End Sub

    Private Sub txtMonto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMonto.TextChanged
        If txtMonto.TextLength > 0 Then
            erp.SetError(txtMonto, "")
        End If
    End Sub
#End Region

    Sub limpiar()
        txtReferencias.Clear()
        txtMonto.Clear()
    End Sub

    Sub llenarCombo()
        Dim dao = DataContext.daoMovimientosCaja
        cmbRubro.DataSource = dao.findAll()
        cmbRubro.DisplayMember = "Descripcion"
        cmbRubro.ValueMember = "Idmov"
    End Sub
    Sub habilitarCajas(opcion As Boolean)
        txtReferencias.Enabled = opcion
        txtMonto.Enabled = opcion
        cmbRubro.Enabled = opcion
        grupoTransacciones.Enabled = opcion
    End Sub
    Private Sub UltraButton3_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        btnGuardar.Visible = True
        btnNuevo.Visible = False
        btnCancelar.Visible = True
        Me.habilitarCajas(True)
        Me.txtReferencias.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        btnNuevo.Visible = True
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        Me.habilitarCajas(False)
        Me.limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Me.validarMovmientoCaja(recIdmov) = False Then
            Return
        End If
        If btnAbrirCaja.Enabled = True Then
            MsgBox("Abra la caja antes de realizar alguna transacción", MsgBoxStyle.Information, "Movimientos de caja")
            Return
        End If
        'Dim result As DialogResult = MsgBox("¿Aplicar el movimiento a la caja actual?", MsgBoxStyle.YesNo, "Guardar")
        'If result = Windows.Forms.DialogResult.No Then
        '    Return
        'End If
        If txtMonto.TextLength <= 0 Then
            erp.SetError(txtMonto, ServiciosBasicos.campoVacio)
            txtMonto.Focus()
            Return
        End If
        Me.cargarCaja()
        Dim idmov As Integer
        Dim dao As IDaoMaestroCaja = DataContext.daoMcaja
        If dao.validarCajaAbierta(Me.cajaActual) = False Then
            MsgBox("Para realizar movimientos de caja debe cerrar la caja y volverla a abrir, ya que esta quedó abierta del dia anterior", MsgBoxStyle.Information, "Caja")
            Return
        End If
        Try
            idmov = cmbRubro.SelectedValue
        Catch ex As Exception
        End Try
        If dao.validarMovimiento(idmov) Then
            idmovimiento = 1
        Else
            idmovimiento = 0
        End If
        Dim dcaja As New Detacaja
        Dim xcaja As Mcaja = dao.recuperarSaldoCaja(cajaActual)
        Dim ycaja As New Mcaja()
        dcaja.Referencia = txtReferencias.Text
        dcaja.Concepto = cmbRubro.Text
        dcaja.Idmov = cmbRubro.SelectedValue
        'especificamos el tipo de transaccion a realizar
        If radCheque.Checked Then
            dcaja.Cheque = Convert.ToDecimal(txtMonto.Text)
            dcaja.Efectivo = Decimal.Zero
            dcaja.Transferencia = Decimal.Zero
        End If
        If radEfectivo.Checked Then
            dcaja.Efectivo = Convert.ToDecimal(txtMonto.Text)
            dcaja.Transferencia = Decimal.Zero
            dcaja.Cheque = Decimal.Zero
        End If
        If radTransferencia.Checked Then
            dcaja.Transferencia = Convert.ToDecimal(txtMonto.Text)
            dcaja.Cheque = Decimal.Zero
            dcaja.Efectivo = Decimal.Zero
        End If
        dcaja.Fecha = Now.Date
        dcaja.Hora = lblHora.Text
        dcaja.Idcaja = xcaja.Idcaja
        dcaja.Codcaja = cajaActual
        If idmovimiento = 1 Then
            'entrada de movimiento
            If radCheque.Checked Then
                ycaja.Entrada = Decimal.Zero
            End If
            If radTransferencia.Checked Then
                ycaja.Entrada = 0D
            End If
            If radEfectivo.Checked Then
                ycaja.Entrada = Convert.ToDecimal(txtMonto.Text)
            End If
            ycaja.Salida = 0
        End If
        If idmovimiento = 0 Then
            'salida de movmiento
            If radCheque.Checked Then
                ycaja.Salida = Decimal.Zero
            End If
            If radTransferencia.Checked Then
                ycaja.Salida = 0D
            End If
            If radEfectivo.Checked Then
                ycaja.Salida = Convert.ToDecimal(txtMonto.Text)
            End If
            ycaja.Entrada = 0
        End If
        ycaja.Idcaja = xcaja.Idcaja
        ycaja.Codcaja = cajaActual
        ycaja.Codagencia = xcaja.Codagencia
        If xcaja.Sfinal < ycaja.Salida Then
            MsgBox("No hay saldo suficiente para realizar la transaccion, intente nuevamente." & _
                              vbCr & "Saldo disponible: " & xcaja.Sfinal, _
                              MsgBoxStyle.Information, "Caja")
            Return
        End If
        'actualizamos el maestro de caja
        'ingresamos el detalle en detacaja
        If MsgBox("¿Aplicar el movimiento a la caja actual caja?" & vbCr & "Valor a ingresar: " & txtMonto.Text, MsgBoxStyle.YesNo, "Guardar") = MsgBoxResult.No Then
            Return
        End If
        If dao.guardarDatosDetaCaja(dcaja, ycaja) Then
            MsgBox("Se ingresó el movimiento", MsgBoxStyle.Information, "Movimientos de caja")
            Me.cargarSaldosCaja()
            Me.btnCancelar_Click(sender, e)
        Else
            MsgBox(dao.ErrorSms)
        End If
    End Sub

    Private Sub btnCerrarCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrarCaja.Click
        Dim result As DialogResult = MsgBox("¿Cerrar la caja actual?", MsgBoxStyle.YesNo, "Cerrar caja")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        If dao.cerrarCaja(cajaActual) Then
            lblSaldo.Text = "0.0"
            lblInicial.Text = "0.0"
            lblEntrada.Text = "0.0"
            lblSalida.Text = "0.0"
            MsgBox("Caja cerrada de forma correcta", MsgBoxStyle.Information, "Cerrar caja")
            Me.revisarEstadoCaja()
        Else
            MsgBox("Se produjo un error al intentar cerrar la caja. Revise la siguiente información: " &
                       vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnAbrirCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnAbrirCaja.Click
        Dim result As DialogResult = MsgBox("¿Abrir la caja actual?", MsgBoxStyle.YesNo, "Cerrar caja")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        If dao.abrirCaja(cajaActual, agenciaActual) Then
            MsgBox("Apertura de caja de forma correcta", MsgBoxStyle.Information, "Abrir caja")
            Me.revisarEstadoCaja()
        Else
            MsgBox("Se produjo un error al intentar abrir la caja. Revise la siguiente información: " &
                       vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
        End If
    End Sub


    Private Sub cmbRubro_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbRubro.SelectedValueChanged
        Dim dao = DataContext.daoMcaja
        Dim idmov As Integer
        Try
            idmov = cmbRubro.SelectedValue
        Catch ex As Exception
        End Try
        If dao.validarMovimiento(idmov) Then
            idmovimiento = 1
        Else
            idmovimiento = 0
        End If
    End Sub

    Private Sub cmbRubro_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbRubro.SelectionChangeCommitted
        Try
            Dim idmov As Integer = cmbRubro.SelectedValue
            Me.recIdmov = idmov
            Me.validarMovmientoCaja(idmov)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnMovimientosDelDia_Click(sender As System.Object, e As System.EventArgs) Handles btnMovimientosDelDia.Click
        Try
            Dim ctx As New Contexto
            Me.cargarCaja()
            'Dim query = (From v In ctx.Vdetacaja
            '             Where v.Fecha = Now And v.Codcaja = cajaActual
            '             Order By v.Fecha Descending Select v).ToList()
            Dim query = ctx.ExecuteQuery(Of Vdetacaja)("select * from vdetacaja where fecha = '" & Now.ToShortDateString & _
                                                       "' and codcaja = '" & cajaActual & "' order by CAST(hora as timestamp) asc").ToList()
            Dim report As New rptCaja
            report.SetDataSource(query)
            'ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value)
            frmReportes.viewer.ReportSource = report
            frmReportes.Show()
            ctx.Dispose()
        Catch ex As Exception

        End Try
    End Sub

End Class
