Public Class Form1

    
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("FALTAN CAMPOS POR LLENAR")
            Exit Sub
        End If

        If (ComboBox1.Text = "") Then
            MsgBox("POR FAVOR SELECCIONE UN TIPO DE HABITACIÓN")
            Exit Sub
        End If
        If (ComboBox2.Text = "") Then
            MsgBox("POR FAVOR SELECCIONE UN TIPO DE PAGO")
            Exit Sub
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("INGRESE UN NÚMERO DE NIT VÁLIDO")
            Exit Sub
        End If
        If Not IsNumeric(TextBox3.Text) Or Val(TextBox3.Text) < 0 Or Val((TextBox3.Text Mod 1) = 0) = False Then
            MsgBox("INGRESE UN NÚMERO DE DÍAS VÁLIDO")
            TextBox3.Focus()
            Exit Sub
        End If

        For FILA As Integer = 0 To 5
            If (HOSPITAL(FILA, 0) <> Nothing) Then
                If (HOSPITAL(FILA, 0) = TextBox1.Text) Then
                    MsgBox("YA EXISTE ESTE REGISTRO")
                    Exit Sub
                End If
            End If
        Next

        If INDICE < 6 Then
            HOSPITAL(INDICE, 0) = TextBox1.Text
            HOSPITAL(INDICE, 1) = TextBox2.Text
            HOSPITAL(INDICE, 2) = TextBox3.Text
            HOSPITAL(INDICE, 3) = TextBox4.Text
            HOSPITAL(INDICE, 4) = ComboBox1.Text
            HOSPITAL(INDICE, 5) = ComboBox2.Text

            Select Case ComboBox1.Text
                Case "PRIVADA"
                    HOSPITAL(INDICE, 6) = Val(TextBox3.Text) * 350
                Case "SEMIPRIVADA"
                    HOSPITAL(INDICE, 6) = Val(TextBox3.Text) * 250
                Case "NO PRIVADA"
                    HOSPITAL(INDICE, 6) = Val(TextBox3.Text) * 150
            End Select

            Select Case ComboBox2.Text
                Case "EFECTIVO"
                    HOSPITAL(INDICE, 7) = Val(HOSPITAL(INDICE, 6) * 0.1 * -1)
                Case "DEPÓSITO"
                    HOSPITAL(INDICE, 7) = Val(HOSPITAL(INDICE, 6) * 0.1 * -1)
                Case "TRANSFERENCIA"
                    HOSPITAL(INDICE, 7) = Val(HOSPITAL(INDICE, 6) * 0.08 * -1)
                Case "TARJETA"
                    HOSPITAL(INDICE, 7) = Val(HOSPITAL(INDICE, 6) * 0.015 * 1)
            End Select

            HOSPITAL(INDICE, 8) = Val(HOSPITAL(INDICE, 6)) + Val(HOSPITAL(INDICE, 7))
            INDICE = INDICE + 1
            LIMPIAR_ENTRADAS()
        End If

        If INDICE = 6 Then
            MsgBox("LA MATRIZ DE DATOS SE HA LLENADO")
        End If

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Dim FILA As Integer = 0
        While FILA < 6
            If (HOSPITAL(FILA, 0) <> Nothing) Then
                DataGridView1.Rows.Add(HOSPITAL(FILA, 0), HOSPITAL(FILA, 1), HOSPITAL(FILA, 2), HOSPITAL(FILA, 3), HOSPITAL(FILA, 4), HOSPITAL(FILA, 5), HOSPITAL(FILA, 6), HOSPITAL(FILA, 7), HOSPITAL(FILA, 8))
            End If
            FILA = FILA + 1
        End While
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For FILA As Integer = 0 To 5
            For COLUMNA As Integer = 0 To 8
                HOSPITAL(FILA, COLUMNA) = Nothing
            Next
        Next
    End Sub

    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click
        Dim FILA As Integer = 0
        Dim ESTA1 = 0
        Dim ESTA2 = 0
        Dim ESTA3 = 0

        While FILA < 6
            If (HOSPITAL(FILA, 0) <> Nothing) Then
                If HOSPITAL(FILA, 4) = "PRIVADA" Then
                    ESTA1 = ESTA1 + 1
                End If
                If HOSPITAL(FILA, 5) = "TRANSFERENCIA" Then
                    ESTA2 = ESTA2 + Val(HOSPITAL(FILA, 8))
                End If
                If HOSPITAL(FILA, 4) = "NO PRIVADA" Then
                    ESTA3 = ESTA3 + Val(HOSPITAL(FILA, 2))
                End If
            End If
            FILA = FILA + 1
        End While

        TextBox5.Text = ESTA1
        TextBox6.Text = ESTA2
        TextBox7.Text = ESTA3

    End Sub

    Private Sub LIMPIARESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADÍSTICASToolStripMenuItem.Click
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE REGISTRO DE HOSPITAL") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARTABLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARTABLAToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("NO INGRESÓ UN NIT PARA CONSULTAR, POR FAVOR INGRESE UN NIT")
            Exit Sub
        End If

        Dim ENCONTRO = False
        For FILA As Integer = 0 To 5
            If (HOSPITAL(FILA, 0) <> Nothing) Then
                If (HOSPITAL(FILA, 0) = TextBox1.Text) Then
                    TextBox2.Text = HOSPITAL(FILA, 1)
                    TextBox2.Text = HOSPITAL(FILA, 2)
                    TextBox4.Text = HOSPITAL(FILA, 3)
                    ComboBox1.Text = HOSPITAL(FILA, 4)
                    ComboBox2.Text = HOSPITAL(FILA, 5)
                    ENCONTRO = True
                    ID = HOSPITAL(FILA, 0)

                    DataGridView1.Rows.Clear()
                    DataGridView1.Rows.Add(HOSPITAL(FILA, 0), HOSPITAL(FILA, 1), HOSPITAL(FILA, 2), HOSPITAL(FILA, 3), HOSPITAL(FILA, 4), HOSPITAL(FILA, 5), HOSPITAL(FILA, 6), HOSPITAL(FILA, 7), HOSPITAL(FILA, 8))
                End If
            End If
        Next
        If ENCONTRO = False Then
            MsgBox("NO SE ENCONTRÓ AL PACIENTE CON ESE NÚMERO DE NIT")

        ElseIf ENCONTRO = True Then
            MsgBox("SE ENCONTRÓ AL PACIENTE CON NÚMERO DE NIT: " + "" + ID)
        End If
    End Sub

    
End Class
