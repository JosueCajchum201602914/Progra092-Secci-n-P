Imports System.Math
Public Class INSCRIPCIONES


    Private Sub RBN_DIVERSIFICADO_CheckedChanged(sender As Object, e As EventArgs) Handles RBN_DIVERSIFICADO.CheckedChanged
        If RBN_DIVERSIFICADO.Checked = True Then
            CMB_CARRERA.Enabled = True
        Else
            CMB_CARRERA.Text = ""
            CMB_CARRERA.Enabled = False
        End If
    End Sub


    Private Sub BTN_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR.Click

        If (FILA <= 6) Then
            If TXT_NOMBRE.Text = "" Or TXT_CARNET.Text = "" Then
                MsgBox("POR FAVOR, LLENE TODOS LOS CAMPOS", , "ADVERTENCIA DE ENTRADA DE DATOS INSCRIPCIONES")
                Exit Sub
            End If
            If IsNumeric(TXT_CARNET.Text) = 0 Or Val(TXT_CARNET.Text) < 0 Or ((Val(TXT_CARNET.Text) Mod 1) = 0) = False Then
                MsgBox("Ingrese un número de carnet válido", , "ADVERTENCIA CARNET INSCRIPCIONES")
                Exit Sub
                TXT_CARNET.Focus()
            End If
            If (RBN_DIVERSIFICADO.Checked = False And RBN_BASICO.Checked = False) Then
                MsgBox("SELECCIONE UN NIVEL DE ESTUDIO", , "ADVERTENCIA DE NIVEL DE ESTUDIO INSCRIPCIONES")
                Exit Sub
            End If

            If (RBN_DIVERSIFICADO.Checked = True And CMB_CARRERA.Text = "") Then
                MsgBox("SELECCIONE UNA CARRERA", , "ADVERTENCIA DE CARRERA INSCRIPCIONES")
                Exit Sub
            End If
            If CMB_PAGO.Text = "" Then
                MsgBox("POR FAVOR, SELECCIONE UN MÉTODO DE PAGO", , "ADVERTENCIA DE PAGO INSCRIPCIONES")
                Exit Sub
            End If



            INSCRIPCIONESM(FILA, 0) = TXT_NOMBRE.Text
            INSCRIPCIONESM(FILA, 1) = TXT_CARNET.Text
            If (RBN_BASICO.Checked) Then
                INSCRIPCIONESM(FILA, 2) = RBN_BASICO.Text
            ElseIf (RBN_DIVERSIFICADO.Checked) Then
                INSCRIPCIONESM(FILA, 2) = RBN_DIVERSIFICADO.Text
            End If

            INSCRIPCIONESM(FILA, 3) = CMB_CARRERA.Text

            If (RBN_BASICO.Checked) Then
                INSCRIPCIONESM(FILA, 4) = Str(Round(CIBASIC))
                INSCRIPCIONESM(FILA, 5) = Str(Round(CMBASIC))
            Else
                INSCRIPCIONESM(FILA, 4) = Str(Round(CIDIVER))
                INSCRIPCIONESM(FILA, 5) = Str(Round(CMDIVER))
            End If

            PAGOINICIAL = Val(INSCRIPCIONESM(FILA, 4)) + Val(INSCRIPCIONESM(FILA, 5))

            INSCRIPCIONESM(FILA, 6) = CMB_PAGO.Text

            INSCRIPCIONESM(FILA, 7) = PAGOINICIAL + RECARGO(CMB_PAGO.Text, PAGOINICIAL)

            FILA = FILA + 1
        End If
        If (FILA = 7) Then
            MsgBox("Matriz llena", , "INSCRIPCIONES")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub BTN_RMOSTRAR_Click(sender As Object, e As EventArgs) Handles BTN_RMOSTRAR.Click
        DataGridView1.Rows.Clear()
        Dim i As Byte


        For i = 0 To 6

            If INSCRIPCIONESM(i, 0) <> Nothing Then
                DataGridView1.Rows.Add(INSCRIPCIONESM(i, 0), INSCRIPCIONESM(i, 1), INSCRIPCIONESM(i, 2), INSCRIPCIONESM(i, 3), INSCRIPCIONESM(i, 4), INSCRIPCIONESM(i, 5), INSCRIPCIONESM(i, 6), INSCRIPCIONESM(i, 7))
            Else

                Exit For
            End If
        Next i
    End Sub

    Private Sub BTN_LIMPIARM_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIARM.Click
        LIMPIAR_MATRIZ()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ED0 = DataGridView1.Item(0, e.RowIndex).Value.ToString()
        ED1 = DataGridView1.Item(1, e.RowIndex).Value.ToString()
        ED2 = DataGridView1.Item(2, e.RowIndex).Value.ToString()
        ED3 = DataGridView1.Item(3, e.RowIndex).Value.ToString()
        ED6 = DataGridView1.Item(6, e.RowIndex).Value.ToString()

        TXT_NOMBRE.Text = ED0
        TXT_CARNET.Text = ED1
        If ED2 = "BÁSICO" Then
            RBN_BASICO.Checked = True
        Else
            RBN_DIVERSIFICADO.Checked = True
        End If
        CMB_CARRERA.Text = ED3
        CMB_PAGO.Text = ED6

    End Sub

  
    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        If (MsgBox("¿DESEA SALIR DE LA VENTANA DE INSCRIPCIONES?", vbQuestion + vbYesNo, "INSCRIPCIONES") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub BTN_TOTALES_Click(sender As Object, e As EventArgs) Handles BTN_TOTALES.Click
        Dim C1 As Double = 0
        Dim C2 As Double = 0
        Dim C3 As Double = 0
        Dim C4 As Double = 0
        Dim C5 As Double = 0
        Dim C6 As Double = 0
        Dim C7 As Double = 0
        Dim C8 As Integer = 0
        Dim C9 As Integer = 0
        Dim C10 As Integer = 0
        Dim C11 As Integer = 0




        For K = 0 To 6
            If ((INSCRIPCIONESM(K, 4) And INSCRIPCIONESM(K, 5)) <> 0) Then
                C1 = C1 + Val(INSCRIPCIONESM(K, 4)) + Val(INSCRIPCIONESM(K, 5))
            End If
            If (INSCRIPCIONESM(K, 6) = "EFECTIVO") Then
                C2 = C2 + Val(INSCRIPCIONESM(K, 7))
            End If
            If (INSCRIPCIONESM(K, 6) = "TARJETA DE CRÉDITO") Then
                C3 = C3 + Val(INSCRIPCIONESM(K, 7))
            End If
            If (INSCRIPCIONESM(K, 6) = "TRANSFERENCIA ACH") Then
                C4 = C4 + Val(INSCRIPCIONESM(K, 7))
            End If
            If (INSCRIPCIONESM(K, 6) = "DÉPOSITO BANCARIO") Then
                C5 = C5 + Val(INSCRIPCIONESM(K, 7))
            End If
            If (INSCRIPCIONESM(K, 2) = "BÁSICO") Then
                C6 = C6 + Val(INSCRIPCIONESM(K, 7))
            End If
            If (INSCRIPCIONESM(K, 2) = "DIVERSIFICADO") Then
                C7 = C7 + Val(INSCRIPCIONESM(K, 7))
            End If
            If (INSCRIPCIONESM(K, 3) = "PERITO CONTADOR") Then
                C8 = C8 + 1
            End If
            If (INSCRIPCIONESM(K, 3) = "BACHILLERATO") Then
                C9 = C9 + 1
            End If
            If (INSCRIPCIONESM(K, 3) = "ELECTRÓNICA") Then
                C10 = C10 + 1
            End If
            If (INSCRIPCIONESM(K, 3) = "DISEÑO GRÁFICO") Then
                C11 = C11 + 1
            End If


            TOTALES.TextBox1.Text = Str(Round(C1, 2))
            TOTALES.TextBox2.Text = Str(Round(C2, 2))
            TOTALES.TextBox3.Text = Str(Round(C3, 2))
            TOTALES.TextBox4.Text = Str(Round(C4, 2))
            TOTALES.TextBox5.Text = Str(Round(C5, 2))
            TOTALES.TextBox6.Text = Str(Round(C6, 2))
            TOTALES.TextBox7.Text = Str(Round(C7, 2))
            TOTALES.TextBox8.Text = C8
            TOTALES.TextBox9.Text = C9
            TOTALES.TextBox10.Text = C10
            TOTALES.TextBox11.Text = C11

        Next K
        Me.Hide()
        TOTALES.Show()
    End Sub
End Class
