Public Class Form1

   
    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("POR FAVOR LLENE TODOS LOS CAMPOS")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("EL NÚMERO DE DPI INGRESADO NO ES VÁLIDO, DEBE SER DE TIPO NÚMERICO")
            TextBox1.Focus()
            Exit Sub
        ElseIf Val(TextBox1.Text) < 0 Then
            MsgBox("EL NÚMERO DE DPI INGRESADO NO ES VÁLIDO")
            TextBox1.Focus()
            Exit Sub
        ElseIf Val((TextBox1.Text Mod 1) = 0) = False Then
            MsgBox("EL NÚMERO DE DPI INGRESADO NO ES VÁLIDO")
            TextBox1.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("EL NÚMERO DE MESES INGRESADO NO ES VÁLIDO, DEBE SER DE TIPO NÚMERICO")
            TextBox4.Focus()
            Exit Sub
        ElseIf Val(TextBox4.Text) < 0 Then
            MsgBox("LA CANTIDAD DE MESES INGRESADA NO ES VÁLIDA")
            TextBox4.Focus()
            Exit Sub
        ElseIf Val((TextBox4.Text Mod 1) = 0) = False Then
            MsgBox("LA CANTIDAD DE MESES INGRESADA NO ES VÁLIDA")
            TextBox4.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBox3.Text) Then
            MsgBox("EL VALOR INGRESADO DEBE SER NÚMERICO")
            TextBox3.Focus()
            Exit Sub
        ElseIf Val(TextBox3.Text) < 0 Then
            MsgBox("INGRESE UN VALOR VÁLIDO")
            TextBox3.Focus()
            Exit Sub
        End If


        'FIN DE VERIFICACIÓN DE DATOS DE ENTRADA

        'VERIFICACIÓN DE ETAPA REPETIDA
        For FILA As Integer = 0 To 6
            If (DPIV(FILA) <> Nothing) Then
                If (DPIV(FILA) = TextBox1.Text) Then
                    MsgBox("YA EXISTE ESTE NÚMERO DE DPI ALMACENADO, NO PUEDE REGISTRARSE DE NUEVO", , "ADVERTENCIA DE DPI")
                    TextBox1.Focus()
                    Exit Sub
                End If
            End If
        Next

        If INDICE <= 6 Then
            DPIV(INDICE) = TextBox1.Text
            NOMBREV(INDICE) = TextBox2.Text
            VALORV(INDICE) = TextBox3.Text
            MESESV(INDICE) = TextBox4.Text

            'CALCULOS
            TASAV(INDICE) = CALCULO_TASA(MESESV(INDICE), VALORV(INDICE))
            FINALV(INDICE) = (VALORV(INDICE) + TASAV(INDICE) * MESESV(INDICE) * VALORV(INDICE))

            INDICE = INDICE + 1
            LIMPIAR_ENTRADAS()
        End If
        If INDICE = 7 Then
            MsgBox("LOS VECTORES SE ENCUENTRAN LLENOS")
        End If
    End Sub

    Private Sub ORDENARDESCENDENTEMENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDESCENDENTEMENTEToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6

        For i = 0 To 5
            For j = i + 1 To 6
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (DPIV(j) <> Nothing) Then
                    If (DPIV(i) < DPIV(j)) Then
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR DPI
                        temp1 = DPIV(i)
                        DPIV(i) = DPIV(j)
                        DPIV(j) = temp1
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR NOMBRE
                        temp2 = NOMBREV(i)
                        NOMBREV(i) = NOMBREV(j)
                        NOMBREV(j) = temp2
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR VALOR
                        temp3 = VALORV(i)
                        VALORV(i) = VALORV(j)
                        VALORV(j) = temp3
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR MESES
                        temp4 = MESESV(i)
                        MESESV(i) = MESESV(j)
                        MESESV(j) = temp4
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR TASA
                        temp5 = TASAV(i)
                        TASAV(i) = TASAV(j)
                        TASAV(j) = temp5
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR FINAL
                        temp6 = FINALV(i)
                        FINALV(i) = FINALV(j)
                        FINALV(j) = temp6
                    End If
                Else
                    Exit For
                End If
            Next j
        Next i
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        Dim FILA As Integer = 0
        While FILA < 7
            If (DPIV(FILA) <> Nothing) Then
                DataGridView1.Rows.Add(DPIV(FILA), NOMBREV(FILA), VALORV(FILA), MESESV(FILA), TASAV(FILA), FINALV(FILA))
            End If
            FILA = FILA + 1
        End While
    End Sub

    Private Sub ORDENARASCENDENTEMENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARASCENDENTEMENTEToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6

        For i = 0 To 5
            For j = i + 1 To 6
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (DPIV(j) <> Nothing) Then
                    If (DPIV(i) > DPIV(j)) Then
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR DPI
                        temp1 = DPIV(i)
                        DPIV(i) = DPIV(j)
                        DPIV(j) = temp1
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR NOMBRE
                        temp2 = NOMBREV(i)
                        NOMBREV(i) = NOMBREV(j)
                        NOMBREV(j) = temp2
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR VALOR
                        temp3 = VALORV(i)
                        VALORV(i) = VALORV(j)
                        VALORV(j) = temp3
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR MESES
                        temp4 = MESESV(i)
                        MESESV(i) = MESESV(j)
                        MESESV(j) = temp4
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR TASA
                        temp5 = TASAV(i)
                        TASAV(i) = TASAV(j)
                        TASAV(j) = temp5
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR FINAL
                        temp6 = FINALV(i)
                        FINALV(i) = FINALV(j)
                        FINALV(j) = temp6
                    End If
                Else
                    Exit For
                End If
            Next j
        Next i
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE ELECTRODOMÉSTICOS LOGIC") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub BTN_LIMPIARTABLA_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIARTABLA.Click
        DataGridView1.Rows.Clear()
    End Sub
End Class
