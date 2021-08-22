Imports System.Math
Public Class Form1

    Private Sub CBX_LINO_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_LINO.CheckedChanged
        If CBX_LINO.Checked = True Then
            TXT_LINO.Visible = True
            TXT_LINO.Text = 0
        Else
            TXT_LINO.Visible = False
            TXT_LINO.Text = 0
        End If
    End Sub

    Private Sub CBX_ALGODON_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_ALGODON.CheckedChanged
        If CBX_ALGODON.Checked = True Then
            TXT_ALGODON.Visible = True
            TXT_ALGODON.Text = 0
        Else
            TXT_ALGODON.Visible = False
            TXT_ALGODON.Text = 0
        End If
    End Sub

    Private Sub CBX_SEDA_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_SEDA.CheckedChanged
        If CBX_SEDA.Checked = True Then
            TXT_SEDA.Visible = True
            TXT_SEDA.Text = 0
        Else
            TXT_SEDA.Visible = False
            TXT_SEDA.Text = 0
        End If
    End Sub

    Private Sub CBX_HILO_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_HILO.CheckedChanged
        If CBX_HILO.Checked = True Then
            TXT_HILO.Visible = True
            TXT_HILO.Text = 0
        Else
            TXT_HILO.Visible = False
            TXT_HILO.Text = 0
        End If
    End Sub


    Private Sub BTN_CALCULAR_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR.Click



        If RBN_IMPERIAL.Checked = 0 And RBN_MATRIMONIAL.Checked = 0 And RBN_QUEEN.Checked = 0 And RBN_KING.Checked = 0 Then
            MsgBox("No seleccionó ningún tamaño de cubrecamas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")
        Else

            If CBX_LINO.Checked = 0 And CBX_ALGODON.Checked = 0 And CBX_SEDA.Checked = 0 And CBX_HILO.Checked = 0 Then
                MsgBox("no seleccionó tipo de material para su cubrecamas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")

            Else
                SumaYardas = Val(TXT_LINO.Text) + Val(TXT_ALGODON.Text) + Val(TXT_SEDA.Text) + Val(TXT_HILO.Text)

                If RBN_IMPERIAL.Checked Then
                    If SumaYardas = yardamaxImp Then
                        PrecioCosto = precioImp + Val(TXT_LINO.Text) * precioLino + Val(TXT_ALGODON.Text) * precioAlg + Val(TXT_SEDA.Text) * precioSeda + Val(TXT_HILO.Text) * precioHilo
                    ElseIf SumaYardas > yardamaxImp Then
                        MsgBox("La cantidad seleccionada de yardas sobrepasa el límite requerido para el cubrecamas imperial, RESTE:" & " " & SumaYardas - yardamaxImp & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")
                    ElseIf SumaYardas < yardamaxImp Then
                        MsgBox("La cantidad seleccionada de yardas NO alcanza la cantidad requerida para el cubrecamas imperial, SUME:" & " " & yardamaxImp - SumaYardas & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")

                    End If
                End If

                If RBN_MATRIMONIAL.Checked Then
                    If SumaYardas = yardamaxMat Then
                        PrecioCosto = precioMat + Val(TXT_LINO.Text) * precioLino + Val(TXT_ALGODON.Text) * precioAlg + Val(TXT_SEDA.Text) * precioSeda + Val(TXT_HILO.Text) * precioHilo
                    ElseIf SumaYardas > yardamaxMat Then
                        MsgBox("La cantidad seleccionada de yardas sobrepasa el límite requerido para el cubrecamas Matrimonial, RESTE:" & " " & SumaYardas - yardamaxMat & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")
                    ElseIf SumaYardas < yardamaxMat Then
                        MsgBox("La cantidad seleccionada de yardas NO alcanza la cantidad  requerida para el cubrecamas Matrimonial, SUME:" & " " & yardamaxMat - SumaYardas & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")

                    End If
                End If

                If RBN_QUEEN.Checked Then
                    If SumaYardas = yardamaxQuee Then
                        PrecioCosto = precioQuee + Val(TXT_LINO.Text) * precioLino + Val(TXT_ALGODON.Text) * precioAlg + Val(TXT_SEDA.Text) * precioSeda + Val(TXT_HILO.Text) * precioHilo
                    ElseIf SumaYardas > yardamaxQuee Then
                        MsgBox("La cantidad seleccionada de yardas sobrepasa el límite requerido para el cubrecamas Queen, RESTE:" & " " & SumaYardas - yardamaxQuee & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")
                    ElseIf SumaYardas < yardamaxQuee Then
                        MsgBox("La cantidad seleccionada de yardas NO alcanza la cantidad  requerida para el cubrecamas Queen, SUME:" & " " & yardamaxQuee - SumaYardas & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")
                    End If
                End If

                If RBN_KING.Checked Then
                    If SumaYardas = yardamaxKing Then
                        PrecioCosto = precioKing + Val(TXT_LINO.Text) * precioLino + Val(TXT_ALGODON.Text) * precioAlg + Val(TXT_SEDA.Text) * precioSeda + Val(TXT_HILO.Text) * precioHilo
                    ElseIf SumaYardas > yardamaxKing Then
                        MsgBox("La cantidad seleccionada de yardas sobrepasa el límite requerido para el cubrecamas King, RESTE:" & " " & SumaYardas - yardamaxKing & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")
                    ElseIf SumaYardas < yardamaxKing Then
                        MsgBox("La cantidad seleccionada de yardas NO alcanza la cantidad  requerida para el cubrecamas King, SUME:" & " " & yardamaxKing - SumaYardas & " yardas a la cantidad de yardas seleccionadas", MsgBoxStyle.DefaultButton1, "CUBRECAMAS ADVERTENCIA")

                    End If
                End If
            End If
        End If

        TXT_COSTO.Text = Str(Round(PrecioCosto, 2))
        TXT_VENTA.Text = Str(Round(PrecioCosto + PrecioCosto * 0.65, 2))
        LBL_LINO.Text = "Total a pagar por lino:"
        LBL_ALGODON.Text = "Total a pagar por Algodón:"
        LBL_SEDA.Text = "Total a pagar por Seda:"
        LBL_HILO.Text = "Total a pagar por Hilo:"


        If SumaYardas = yardamaxImp Or SumaYardas = yardamaxMat Or SumaYardas = yardamaxQuee Or SumaYardas = yardamaxKing Then
            LBL_LINO.Text = LBL_LINO.Text & Str(Val(TXT_LINO.Text) * precioLino)
            LBL_ALGODON.Text = LBL_ALGODON.Text & Str(Val(TXT_ALGODON.Text) * precioAlg)
            LBL_SEDA.Text = LBL_SEDA.Text & Str(Val(TXT_SEDA.Text) * precioSeda)
            LBL_HILO.Text = LBL_HILO.Text & Str(Val(TXT_HILO.Text) * precioHilo)
        End If


    End Sub


    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        Limpiar_entradas()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE ELECCIÓN DE CUBRECAMAS") = vbYes) Then
            Me.Close()
        Else
            Limpiar_entradas()

        End If
    End Sub
End Class
