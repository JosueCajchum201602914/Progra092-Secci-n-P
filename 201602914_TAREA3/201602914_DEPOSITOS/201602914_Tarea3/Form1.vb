Imports System.Math
Public Class Form1




    Private Sub CBX_CHEQUEP_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_CHEQUEP.CheckedChanged
        If (CBX_CHEQUEP.Checked) Then
            TBX_CHEQUEP.Visible = True
            TBX_SALDOANTERIOR.Visible = True
            TBX_CHEQUEP.Focus()
        Else
            TBX_CHEQUEP.Clear()
            TBX_CHEQUEP.Visible = False
        End If

        If (CBX_EFECTIVO.Checked Or CBX_CHEQUEO.Checked Or CBX_CHEQUEP.Checked) Then
            TBX_SALDOANTERIOR.Visible = True
        Else
            TBX_SALDOANTERIOR.Clear()
            TBX_SALDOANTERIOR.Visible = False
        End If
    End Sub

    Private Sub CBX_CHEQUEO_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_CHEQUEO.CheckedChanged
        If (CBX_CHEQUEO.Checked) Then
            TBX_CHEQUEO.Visible = True
            TBX_CHEQUEO.Focus()
        Else
            TBX_CHEQUEO.Clear()
            TBX_CHEQUEO.Visible = False

        End If
        If (CBX_EFECTIVO.Checked Or CBX_CHEQUEO.Checked Or CBX_CHEQUEP.Checked) Then
            TBX_SALDOANTERIOR.Visible = True
        Else
            TBX_SALDOANTERIOR.Clear()
            TBX_SALDOANTERIOR.Visible = False
        End If
    End Sub

    Private Sub CBX_EFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_EFECTIVO.CheckedChanged
        If (CBX_EFECTIVO.Checked) Then
            TBX_EFECTIVO.Visible = True
            TBX_EFECTIVO.Focus()
        Else
            TBX_EFECTIVO.Clear()
            TBX_EFECTIVO.Visible = False
        End If

        If (CBX_EFECTIVO.Checked Or CBX_CHEQUEO.Checked Or CBX_CHEQUEP.Checked) Then
            TBX_SALDOANTERIOR.Visible = True
        Else
            TBX_SALDOANTERIOR.Clear()
            TBX_SALDOANTERIOR.Visible = False
        End If
    End Sub





    Private Sub BTN_CALCULAR_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR.Click
        Saldo_nuevo = Val(TBX_CHEQUEO.Text) + Val(TBX_CHEQUEP.Text) + Val(TBX_EFECTIVO.Text) + Val(TBX_SALDOANTERIOR.Text)
        Saldofinal_Deposito.TBX_SALDONUEVO.Text = Str(Round(Saldo_nuevo, 2))

        Saldo_Anterior = Val(TBX_SALDOANTERIOR.Text)

        If (RBN_AHORRO.Checked) Then
            Select Case Saldo_nuevo
                Case 1.01 To 1000.99
                    Interes = 1.5 / 100
                Case 1001 To 5000.99
                    Interes = 2.5 / 100
                Case 5001 To 15000.99
                    Interes = 7.5 / 100
                Case Is >= 15001
                    Interes = 10 / 100
            End Select
            InteresCalculado = Saldo_nuevo * Interes

        End If
        If (RBN_MPREMIER.Checked) Then

            Select Case Saldo_Anterior
                Case 1.01 To 10000.99
                    Interes = 2.5 / 100
                Case 10001 To 15000.99
                    Interes = 3 / 100
                Case Is >= 15001
                    Interes = 4.5 / 100
            End Select
            InteresCalculado = Saldo_Anterior * Interes
        End If
        If (RBN_MONETARIO.Checked) Then

            InteresCalculado = 0
        End If

        Saldofinal_Deposito.TBX_INTERÉS.Text = Str(Round(InteresCalculado, 2))
        Saldofinal_Deposito.TBX_SALDOFINAL.Text = Str(Round(InteresCalculado + Saldo_nuevo, 2))
        Saldofinal_Deposito.TBX_SALDOANTERIOR.Text = TBX_SALDOANTERIOR.Text
        Me.Hide()
        Saldofinal_Deposito.Show()
    End Sub




    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click

        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Salir de herramienta de depositos") = vbYes Then

            End
        Else

            LIMPIAR_ENTRADAS()
        End If
    End Sub
End Class
