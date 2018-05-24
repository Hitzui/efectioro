﻿Imports EfectiOro.Database

Public Class frmAdelantos

    'Esto me dira si hay suma segun los campos seleccionados
    Private sumaGen As Decimal = 0
    Private nombreCliente As String
    Private saldoActual As Decimal = 0D

    Sub filtrarCliente()
        Try
            If txtcodcliente.TextLength > 0 Then
                erp.SetError(txtcodcliente, "")
            End If
            Dim dao = DataContext.daoCliente
            dgvCliente.Rows.Clear()
            Dim listar As List(Of Cliente) = dao.filtrarPorNombre(txtcodcliente.Text)
            For Each valor In listar
                dgvCliente.Rows.Add(valor.Codcliente, valor.Nombres, valor.Apellidos)
            Next
        Catch ex As Exception
            MsgBox("Error al inentar filtrar el cliene producido por: " & vbCr & ex.Message, _
                   MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    ''' <summary>
    ''' Calculamos la sumas de las respectivas transacciones seleccionadas
    ''' </summary>
    ''' <remarks></remarks>
    Sub calcularSuma()
        Try
            Dim efectivo, cheque, transferencia, suma As Decimal
            If txtefectivo.TextLength > 0 Then
                efectivo = Convert.ToDecimal(txtefectivo.Text)
            Else
                efectivo = Decimal.Zero
            End If
            If txtcheque.TextLength > 0 Then
                cheque = Convert.ToDecimal(txtcheque.Text)
            Else
                cheque = Decimal.Zero
            End If
            If txttransferencia.TextLength > 0 Then
                transferencia = Convert.ToDecimal(txttransferencia.Text)
            Else
                transferencia = Decimal.Zero
            End If
            suma = efectivo + cheque + transferencia
            sumaGen = suma
            lbltotal.Text = suma.ToString("#,###,###.00")
        Catch ex As Exception
            MsgBox("Uno de los formatos de numero no tiene la entrada correcta, revise si ha escrito bien los numeros." & _
                   vbCr & "Informacion basica: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub habilitar(nuevo As Boolean, guardar As Boolean, cancelar As Boolean, grupo As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        grupoRegistrar.Enabled = grupo
    End Sub
    Sub limpiar()
        txtcodcliente.Clear()
        txtreferencia.Clear()
        txtcheque.Clear()
        txtefectivo.Clear()
        txtreferencia.Clear()
    End Sub
    Private Sub frmAdelantos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Registrar Adelantos - EfectiOro"
        lblFecha.Text = Now.ToString("dd/mm/yyyy")
        Me.habilitar(True, False, False, False)
        ServiciosBasicos.colorearGrid(dgvCliente)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        lblHora.Text = Now.ToLongTimeString()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.habilitar(False, True, True, True)
        Me.limpiar()
        txtcodcliente.Focus()
        Me.filtrarCliente()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.habilitar(True, False, False, False)
        Me.dgvCliente.Visible = False
        Me.limpiar()
    End Sub

    Private Sub txtcodcliente_Enter(sender As System.Object, e As System.EventArgs) Handles txtcodcliente.Enter
        ServiciosBasicos.colorDeFondoInfo(txtcodcliente)
        If dgvCliente.Visible = False Then
            dgvCliente.Visible = True
            dgvCliente.Size = New Size(327, 108)
        End If
    End Sub

    Private Sub txtcodcliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtcodcliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                dgvCliente.Focus()
            Case Keys.Enter
                txtreferencia.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtcodcliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtcodcliente.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtcodcliente)
    End Sub

    Private Sub txtcodcliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcodcliente.TextChanged
        Me.filtrarCliente()
    End Sub

    Private Sub txtreferencia_Enter(sender As System.Object, e As System.EventArgs) Handles txtreferencia.Enter
        ServiciosBasicos.colorDeFondoInfo(txtreferencia)
    End Sub

    Private Sub txtreferencia_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtreferencia.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                e.Handled = True
                txtefectivo.Focus()
        End Select
    End Sub

    Private Sub txtreferencia_Leave(sender As System.Object, e As System.EventArgs) Handles txtreferencia.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtreferencia)
    End Sub

    Private Sub txtefectivo_Enter(sender As System.Object, e As System.EventArgs) Handles txtefectivo.Enter
        ServiciosBasicos.colorDeFondoInfo(txtefectivo)
    End Sub

    Private Sub txtefectivo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtefectivo.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                If txtcheque.Visible = True Then
                    txtcheque.Focus()
                    e.Handled = True
                    Return
                End If
                btnGuardar.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtefectivo_Leave(sender As System.Object, e As System.EventArgs) Handles txtefectivo.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtefectivo)
        Me.calcularSuma()
    End Sub

    Private Sub txtefectivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtefectivo.TextChanged
        If txtefectivo.TextLength > 0 Then
            erp.SetError(txtefectivo, String.Empty)
        End If
        Me.calcularSuma()
    End Sub

    Private Sub txtcheque_Enter(sender As System.Object, e As System.EventArgs) Handles txtcheque.Enter
        ServiciosBasicos.colorDeFondoInfo(txtcheque)
    End Sub

    Private Sub txtcheque_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtcheque.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                If txttransferencia.Visible = True Then
                    txttransferencia.Focus()
                    e.Handled = True
                    Return
                End If
                btnGuardar.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtcheque_Leave(sender As System.Object, e As System.EventArgs) Handles txtcheque.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtcheque)
        Me.calcularSuma()
    End Sub

    Private Sub txtcheque_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcheque.TextChanged
        If txtcheque.TextLength > 0 Then
            erp.SetError(txtcheque, String.Empty)
        End If
        Me.calcularSuma()
    End Sub

    Private Sub txttransferencia_Enter(sender As System.Object, e As System.EventArgs) Handles txttransferencia.Enter
        ServiciosBasicos.colorDeFondoInfo(txttransferencia)
    End Sub

    Private Sub txttransferencia_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txttransferencia.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                btnGuardar.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txttransferencia_Leave(sender As System.Object, e As System.EventArgs) Handles txttransferencia.Leave
        ServiciosBasicos.colorDeFondoBlanco(txttransferencia)
        Me.calcularSuma()
    End Sub

    Private Sub txttransferencia_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttransferencia.TextChanged
        If txttransferencia.TextLength > 0 Then
            erp.SetError(txttransferencia, String.Empty)
        End If
        Me.calcularSuma()
    End Sub

    Private Sub dgvCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCliente.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    Dim row As DataGridViewRow = dgvCliente.CurrentRow
                    txtcodcliente.Text = row.Cells(0).Value
                    Me.nombreCliente = row.Cells(1).Value & " " & row.Cells(2).Value
                    Dim dao = DataContext.daoAdelantos
                    Dim tieneAdelanto As New Adelantos
                    'revisamos si el cliente actual tiene adelantos
                    'le mostramos que el cliene tiene un saldo
                    Dim daoAdelanto = DataContext.daoAdelantos
                    Me.saldoActual = 0D
                    Try
                        Dim lisAdelanto As List(Of Adelantos) = daoAdelanto.listarAdelantosPorClientes(txtcodcliente.Text)
                        For Each dato As Adelantos In lisAdelanto
                            saldoActual += dato.Saldo
                        Next
                        tieneAdelanto = dao.findByCodigoCliente(txtcodcliente.Text)
                        Dim result As DialogResult
                        If saldoActual > 0 Then
                            result = MsgBox("El cliente actual tiene pendiente un adelanto con un monto de: " & saldoActual _
                                        & vbCr & "¿Desea aplicar el adelanto al cliente seleccionado?", MsgBoxStyle.YesNo, "Adelanto")
                        End If
                        If result = MsgBoxResult.No Then
                            txtcodcliente.Clear()
                            txtcodcliente.Focus()
                            Return
                        Else
                            dgvCliente.Visible = False
                            txtreferencia.Focus()
                        End If
                    Catch ex As Exception
                        dgvCliente.Visible = False
                        txtreferencia.Focus()
                    End Try
                Case Keys.Escape
                    dgvCliente.Visible = False
                    txtcodcliente.Focus()
            End Select
        Catch ex As Exception
            MsgBox("Error al intentar seleccionar el cliente: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtcodcliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodcliente.KeyPress
        ServiciosBasicos.quitarPitido(e)
    End Sub

    Private Sub txtreferencia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtreferencia.KeyPress
        ServiciosBasicos.quitarPitido(e)
    End Sub

    Private Sub txtefectivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtefectivo.KeyPress
        ServiciosBasicos.quitarPitido(e)
        ServiciosBasicos.NumeroDec(e, txtefectivo)
    End Sub

    Private Sub txtcheque_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcheque.KeyPress
        ServiciosBasicos.quitarPitido(e)
        ServiciosBasicos.NumeroDec(e, txtcheque)
    End Sub

    Private Sub txttransferencia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttransferencia.KeyPress
        ServiciosBasicos.quitarPitido(e)
        ServiciosBasicos.NumeroDec(e, txttransferencia)
    End Sub

    Private Sub chekEfectivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chekEfectivo.CheckedChanged
        If chekEfectivo.CheckState = CheckState.Checked Then
            txtefectivo.Visible = True
            txtefectivo.Focus()
        Else
            txtefectivo.Visible = False
            txtefectivo.Clear()
        End If
    End Sub

    Private Sub chekCheque_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chekCheque.CheckedChanged
        If chekCheque.CheckState = CheckState.Checked Then
            txtcheque.Visible = True
            txtcheque.Focus()
        Else
            txtcheque.Visible = False
            txtcheque.Clear()
        End If
    End Sub

    Private Sub chekTransferencia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chekTransferencia.CheckedChanged
        If chekTransferencia.CheckState = CheckState.Checked Then
            txttransferencia.Visible = True
            txttransferencia.Focus()
        Else
            txttransferencia.Visible = False
            txttransferencia.Clear()
        End If
    End Sub

    Private Sub imprimir(codigoAdelanto As String, nombre As String)
        Using ctx As New Contexto
            Try
                Dim buscar = (From a In ctx.Adelantos Where a.Idsalida = codigoAdelanto Select a).ToList()
                Dim listar As New List(Of Adelantos)
                For Each dato In buscar
                    Dim adelanto As New Adelantos
                    adelanto.Idsalida = dato.Idsalida
                    adelanto.Monto_letras = dato.Monto_letras
                    adelanto.Fecha = dato.Fecha
                    adelanto.Hora = dato.Hora
                    adelanto.Monto = dato.Monto
                    adelanto.nombreCliente = nombre
                    adelanto.Saldo = Me.saldoActual
                    listar.Add(adelanto)
                Next
                Dim report As New rptReciboAdelanto
                report.SetDataSource(listar)
                'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Sub imprimir(codigoAdelanto As String)
        Using ctx As New Contexto
            Try
                Dim buscar = (From a In ctx.Adelantos Where a.Idsalida = codigoAdelanto Select a).ToList()
                Dim report As New rptReciboAdelanto
                report.SetDataSource(buscar)
                'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If sumaGen <= 0 Then
            MsgBox("No se ha especificado un monto para aplicar el adelanto, intente nuevamente", MsgBoxStyle.Information, "Adelantos")
            Return
        End If
        If txtcodcliente.TextLength <= 0 Then
            erp.SetError(txtcodcliente, "No ha especificado un cliente para aplicar el adelanto, intente nuevamente")
            txtcodcliente.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Aplicar el adelanto al cliente seleccionado?", MsgBoxStyle.YesNo, "Adelantos")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim config As New ConfiguracionGeneral
        Dim daoParametros = DataContext.daoParametros
        Dim daoCaja = DataContext.daoMcaja
        Dim daoAdelantos = DataContext.daoAdelantos
        Dim caja As String = config.getCaja
        'por el moento se usa una sola sucursal
        Dim agencia As String = "A001"
        Dim recuperarCaja As Mcaja
        Try
            If daoCaja.validarCajaAbierta(caja) = False Then
                MsgBox("La caja actual quedó abierta, cierre la caja y vuelva a abrirla para realizar la transacción.", _
                       MsgBoxStyle.Information, "Adelantos")
                Return
            End If
            recuperarCaja = daoCaja.recuperarSaldoCaja(caja)
        Catch ex As Exception
            MsgBox("No existe la caja actual, por favor intente nuevamente." & _
                   vbCr & "Se produjo el siguiente error:" & daoCaja.ErrorSms, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        'revisamos si tiene adelanto pendiente el cliente
        'Try
        '    Dim recAdelantoDelCliente As Adelantos = daoAdelantos.findByCodigoCliente(txtcodcliente.Text)
        '    If recAdelantoDelCliente.Saldo > 0 Then

        '    End If
        'Catch ex As Exception
        'End Try
        'creamos las variables que actualizaran tanto la caja como los adelantos
        Dim detaCaja As New Detacaja
        Dim adelanto As New Adelantos
        Dim actCaja As New Mcaja
        adelanto.Codcliente = txtcodcliente.Text
        adelanto.Usuario = DataContext.usuarioLog.Usuario1
        adelanto.Codcaja = caja
        'especificamos los valores
        If txtefectivo.TextLength > 0 Then
            adelanto.Efectivo = Convert.ToDecimal(txtefectivo.Text)
            actCaja.Salida = adelanto.Efectivo
            actCaja.Entrada = 0
            detaCaja.Efectivo = Convert.ToDecimal(txtefectivo.Text)
        Else
            adelanto.Efectivo = 0
            detaCaja.Efectivo = 0
        End If
        If txtcheque.TextLength > 0 Then
            adelanto.Cheque = Convert.ToDecimal(txtcheque.Text)
            detaCaja.Cheque = Convert.ToDecimal(txtcheque.Text)
        Else
            adelanto.Cheque = 0
            detaCaja.Cheque = 0
        End If
        If txttransferencia.TextLength > 0 Then
            adelanto.Transferencia = Convert.ToDecimal(txttransferencia.Text)
            detaCaja.Transferencia = Convert.ToDecimal(txttransferencia.Text)
        Else
            adelanto.Transferencia = 0
            detaCaja.Transferencia = 0
        End If
        'definimos los detalles del mcaja
        actCaja.Fecha = Date.Now
        actCaja.Codcaja = caja
        actCaja.Codagencia = agencia
        'definimos los detalles del adelanto
        adelanto.Idsalida = daoAdelantos.recpuerarCodigoAdelanto()
        adelanto.Monto = sumaGen
        adelanto.Fecha = Now
        adelanto.Saldo = sumaGen
        adelanto.Numcompra = String.Empty
        adelanto.Monto_letras = ConvertirNumeroLetros(Convert.ToDecimal(lbltotal.Text))
        adelanto.Hora = lblHora.Text
        'definimos los detalles del detacaja
        detaCaja.Referencia = txtreferencia.Text
        detaCaja.Idcaja = recuperarCaja.Idcaja
        detaCaja.Idmov = daoParametros.recuperarParametros().Id_adelantos
        detaCaja.fecha = DateTime.Now
        detaCaja.Concepto = "***ADELANTO: " & adelanto.Idsalida & "***"
        detaCaja.Hora = lblHora.Text
        'detaCaja.Fecha = Now
        detaCaja.Codcaja = caja
        'validamos que haya saldo dsiponible para realizar la transacción
        If recuperarCaja.Sfinal < adelanto.Efectivo Then
            MsgBox("No hay saldo suficiente para realizar la transaccion." & _
                             vbCr & "Saldo disponible: " & recuperarCaja.Sfinal, _
                             MsgBoxStyle.Information, "Caja")
            Return
        End If
        Try
            If daoAdelantos.crearAdelanto(adelanto) And daoMcaja.guardarDatosDetaCaja(detaCaja, actCaja) Then
                MsgBox("Se guardó el adelanto del cliente de forma correcta", MsgBoxStyle.Information, "Adelantos")
                If MsgBox("¿Imprimir el recibo de adelanto?", MsgBoxStyle.YesNo, "Imprimir") = MsgBoxResult.Yes Then
                    Me.recuperarSaldoTotal(adelanto.Codcliente)
                    Me.imprimir(adelanto.Idsalida, Me.nombreCliente)
                End If
                btnCancelar_Click(sender, e)
            Else
                MsgBox("Se produjeron los siguientes errores: " & vbCr & "Maestro de caja: " & daoMcaja.ErrorSms & vbCr & "Adelanto: " & daoAdelantos.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub recuperarSaldoTotal(codcliente As String)
        Try
            Dim dao = DataContext.daoAdelantos
            Dim find = dao.listarAdelantosPorClientes(codcliente)
            saldoActual = find.Sum(Function(p) p.Saldo)
        Catch ex As Exception
            MsgBox("No se pudo calcular el saldo total del cliente debido a un error: " & vbCr _
                   & ex.Message, "Error", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub dgvCliente_Leave(sender As Object, e As EventArgs) Handles dgvCliente.Leave
        If txtcodcliente.TextLength > 0 Then
            dgvCliente.Visible = False
        Else
            txtcodcliente.Focus()
        End If
    End Sub

    Private Sub btnAdelantos_Click(sender As Object, e As EventArgs) Handles btnAdelantos.Click
        frmAdelantosAplicados.Show()
    End Sub

End Class