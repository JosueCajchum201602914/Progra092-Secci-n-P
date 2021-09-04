Imports System.Math
Public Class COBRO_LUZ



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMB_SERVICIO.Items.Add("RESIDENCIAL")
        CMB_SERVICIO.Items.Add("INDUSTRIAL")
        CMB_TARIFA.Items.Add("SOCIAL")
        CMB_TARIFA.Items.Add("NO SOCIAL")
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (Registro <= 10) Then
            If TXT_CONSUMIDOR.Text = "" Then
                MsgBox("No ingresó nombre del consumidor", MsgBoxStyle.Exclamation, "ADVERTENCIA NOMBRE DEL CONSUMIDOR") : Exit Sub
                TXT_CONSUMIDOR.Focus()
            End If
            If TXT_NIT.Text = "" Then
                TXT_NIT.Text = "C/F"
            ElseIf IsNumeric(TXT_NIT.Text) = False And TXT_NIT.Text <> "C/F" Then
                MsgBox("No ingresó un número válido de NIT", MsgBoxStyle.Exclamation, "ADVERTENCIA NÚMERO DE NIT") : Exit Sub
                TXT_NIT.Focus()
            End If
            If TXT_SALDOANTERIOR.Text = "" Then
                TXT_SALDOANTERIOR.Text = 0
            ElseIf IsNumeric(TXT_SALDOANTERIOR.Text) = False Then
                MsgBox("No ingresó un número válido de SALDO ANTERIOR", MsgBoxStyle.Exclamation, "ADVERTENCIA SALDO ANTERIOR") : Exit Sub
                TXT_SALDOANTERIOR.Focus()
            End If
            If TXT_CONSUMO.Text = "" Then
                TXT_CONSUMO.Text = 0
            ElseIf IsNumeric(TXT_CONSUMO.Text) = False Then
                MsgBox("No ingresó un número válido de CONSUMO DEL MES", MsgBoxStyle.Exclamation, "ADVERTENCIA CONSUMO DEL MES") : Exit Sub
                TXT_CONSUMO.Focus()
            End If
            Select Case (CMB_SERVICIO.Text)
                Case "RESIDENCIAL"
                    Select Case (Val(TXT_CONSUMO.Text))
                        Case 1 To 100.99
                            PrecioServicio = Val(TXT_CONSUMO.Text) * Residencial1
                        Case 101 To 300.99
                            PrecioServicio = Val(TXT_CONSUMO.Text) * Residencial101
                        Case Is > 301
                            PrecioServicio = Val(TXT_CONSUMO.Text) * Residencial301
                        Case Else
                            MsgBox("No ingresó una cantidad de KW De consumo Válido") : Exit Sub
                    End Select

                Case "INDUSTRIAL"
                    Select Case (Val(TXT_CONSUMO.Text))
                        Case 1 To 100.99
                            PrecioServicio = Val(TXT_CONSUMO.Text) * Industrial1
                        Case 101 To 300.99
                            PrecioServicio = Val(TXT_CONSUMO.Text) * Industrial101
                        Case Is > 301
                            PrecioServicio = Val(TXT_CONSUMO.Text) * Industrial301
                        Case Else
                            MsgBox("No ingresó una cantidad de KWh De consumo Válido", MsgBoxStyle.Exclamation, "ADVERTENCIA CONSUMO DEL MES") : Exit Sub
                    End Select
                Case Else
                    MsgBox("Por favor seleccione un tipo de servicio", MsgBoxStyle.Exclamation, "ADVERTENCIA DE SELECCIÓN DE SERVICIO") : Exit Sub
            End Select
            Select Case (CMB_TARIFA.Text)
                Case "SOCIAL"
                    Desc = PrecioServicio * 0.2

                Case "NO SOCIAL"
                    Desc = PrecioServicio * 0.1
                Case Else
                    MsgBox("Por favor seleccione un tipo de tarifa", MsgBoxStyle.Exclamation, "ADVERTENCIA DE SELECCIÓN DE TARIFA") : Exit Sub
            End Select

            If Val(TXT_SALDOANTERIOR.Text) > 0 Then
                MoraV = Val(TXT_SALDOANTERIOR.Text) * 0.02
            ElseIf Val(TXT_SALDOANTERIOR.Text) = 0 Then
                MoraV = 0
            End If
            SaldoAnterior = Val(TXT_SALDOANTERIOR.Text)



            CONSUMIDOR(Registro) = TXT_CONSUMIDOR.Text
            NIT(Registro) = TXT_NIT.Text
            SERVICIO(Registro) = CMB_SERVICIO.Text
            TARIFA(Registro) = CMB_TARIFA.Text
            SALDO(Registro) = Round(Val(TXT_SALDOANTERIOR.Text), 2)
            INICIAL(Registro) = Round(PrecioServicio, 2)
            MORA(Registro) = Round(MoraV, 2)
            DESCUENTO(Registro) = Round(Desc, 2)
            TOTAL(Registro) = Round(INICIAL(Registro) + SALDO(Registro) - DESCUENTO(Registro) + MORA(Registro), 2)


            mostrar_vectores()

            Registro = Registro + 1
        End If

        If (Registro = 11) Then
            MsgBox("VECTORES LLENOS")
        End If
        Limpiar_entradas()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Limpiar_listas()
    End Sub

   



    Private Sub SALIRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE VENTANA DE CÁLCULO DE TARIFAS POR CONSUMO ELÉCTRICO") = vbYes) Then
            End
        Else
            Limpiar_entradas()
        End If
    End Sub
End Class
