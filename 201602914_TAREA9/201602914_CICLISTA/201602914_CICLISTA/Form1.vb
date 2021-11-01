Imports System.Math
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("SKY")
        ComboBox1.Items.Add("MOVISTAR")
        ComboBox1.Items.Add("PRO CYCLING")
        ComboBox1.Items.Add("PRO TEAM")
        ComboBox2.Items.Add("GUATEMALTECO")
        ComboBox2.Items.Add("EXTRANJERO")
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("FALTAN CAMPOS POR LLENAR, POR FAVOR LLENE TODOS LOS CAMPOS DE LA ETAPA")
            Exit Sub
        End If

        If (ComboBox1.Text = "") Then
            MsgBox("POR FAVOR SELECCIONE UN EQUIPO")
            Exit Sub
        End If
        If (ComboBox2.Text = "") Then
            MsgBox("POR FAVOR SELECCIONE UNA NACIONALIDAD")
            Exit Sub
        End If

        If Not IsNumeric(TextBox2.Text) Then
            MsgBox("INGRESE UN NÚMERO DE ETAPA VÁLIDA")
            TextBox2.Focus()
            Exit Sub
        ElseIf Val(TextBox2.Text) < 0 Then
            MsgBox("INGRESE UN NÚMERO DE ETAPA VÁLIDA")
            TextBox2.Focus()
            Exit Sub
        ElseIf Val((TextBox2.Text Mod 1) = 0) = False Then
            MsgBox("INGRESE UN NÚMERO DE ETAPA VÁLIDA")
            TextBox2.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox3.Text) Then
            MsgBox("INGRESE UNA CANTIDAD DE KILÓMETROS VÁLIDA")
            TextBox3.Focus()
            Exit Sub
        ElseIf Val(TextBox3.Text) < 0 Then
            MsgBox("INGRESE UNA CANTIDAD DE KILÓMETROS VÁLIDA")
            TextBox3.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("INGRESE UNA CANTIDAD DE MINUTOS VÁLIDA")
            TextBox4.Focus()
            Exit Sub
        ElseIf Val(TextBox4.Text) < 0 Then
            MsgBox("INGRESE CANTIDAD DE CANTIDAD DE MINUTOS VÁLIDA")
            TextBox4.Focus()
            Exit Sub
        End If
        'FIN DE VERIFICACIÓN DE DATOS DE ENTRADA

        'VERIFICACIÓN DE ETAPA REPETIDA
        For FILA As Integer = 0 To 11
            If (ETAPAV(FILA) <> Nothing) Then
                If (ETAPAV(FILA) = TextBox2.Text) Then
                    MsgBox("YA EXISTE ESTE NÚMERO DE ETAPA ALMACENADO", , "ADVERTENCIA DE ETAPA")
                    TextBox2.Focus()
                    Exit Sub
                End If
            End If
        Next
        'INGRESO DE DATOS EN LOS VECTORES Y OPERACIONES DE VENTAS
        If INDICE < 12 Then
            ETAPAV(INDICE) = Val(TextBox2.Text)
            EQUIPOV(INDICE) = ComboBox1.Text
            KMV(INDICE) = Round(Val(TextBox3.Text), 2)
            TIEMPOV(INDICE) = Round(Val(TextBox4.Text), 2)
            NACIONALIDADV(INDICE) = ComboBox2.Text
            PENAV(INDICE) = Round(CALCULOPENA(TIEMPOV(INDICE), EQUIPOV(INDICE)), 2)
            TOTALV(INDICE) = Round(TIEMPOV(INDICE) + PENAV(INDICE), 2)

            INDICE = INDICE + 1
            LIMPIAR_ENTRADAS()
        End If

        If INDICE = 12 Then
            MsgBox("LOS VECTORES DE ALMACENAMIENTO DE DATOS SE HAN LLENADO")
        End If
    End Sub


    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        Dim FILA As Integer = 0
        While FILA < 12
            If (ETAPAV(FILA) <> Nothing) Then
                DataGridView1.Rows.Add(ETAPAV(FILA), EQUIPOV(FILA), KMV(FILA), TIEMPOV(FILA), NACIONALIDADV(FILA), PENAV(FILA), TOTALV(FILA))
            End If
            FILA = FILA + 1
        End While
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        If TextBox5.Text = "" Then
            MsgBox("NO INGRESÓ UN NÚMERO DE ETAPA PARA CONSULTAR")
            Exit Sub
        End If
        'CONSULTA POR MEDIO DE ETAPA
        Dim ENCONTRO = False
        Dim P = 0
        For FILA As Integer = 0 To 11
            If (ETAPAV(FILA) <> Nothing) Then
                If (ETAPAV(FILA) = TextBox5.Text) Then
                    TextBox2.Text = ETAPAV(FILA)
                    ComboBox1.Text = EQUIPOV(FILA)
                    TextBox3.Text = KMV(FILA)
                    TextBox4.Text = TIEMPOV(FILA)
                    ComboBox2.Text = NACIONALIDADV(FILA)
                    ENCONTRO = True
                    ID = ETAPAV(FILA)
                    P = FILA
                    DataGridView1.Rows.Clear()
                    DataGridView1.Rows.Add(ETAPAV(FILA), EQUIPOV(FILA), KMV(FILA), TIEMPOV(FILA), NACIONALIDADV(FILA), PENAV(FILA), TOTALV(FILA))
                End If
            End If
        Next
        If ENCONTRO = False Then
            MsgBox("NO SE ENCONTRÓ EL REGISTRO CON ESE NÚMERO DE ETAPA")
            TextBox5.Focus()
        ElseIf ENCONTRO = True Then
            MsgBox("SE ENCONTRÓ LA ETAPA NÚMERO: " + "" + ID)
        End If

        INDICE = P
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        LIMPIAR_VECTORES()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub BTN_LIMPIARTABLA_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIARTABLA.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click

        Dim ESTA1 As Byte = 0
        Dim EQU1 As Double = 0
        Dim EQU2 As Double = 0
        Dim EQU3 As Double = 0
        Dim EQU4 As Double = 0
        Dim T1 As Double = 0
        Dim T2 As Double = 0
        Dim T3 As Double = 0
        Dim T4 As Double = 0
        Dim R1, R2, R3, R4 As Double
        Dim HR1, HR2, HR3, HR4 As Double
        For F = 0 To 11
            If (ETAPAV(F) <> Nothing) Then

                Select Case NACIONALIDADV(F)
                    Case "GUATEMALTECO"
                        Select Case KMV(F)
                            Case Is > 45
                                ESTA1 = ESTA1 + 1
                            Case Else
                                ESTA1 = ESTA1
                        End Select
                    Case Else
                        ESTA1 = ESTA1
                End Select

                Select Case EQUIPOV(F)
                    Case "SKY"
                        EQU1 = EQU1 + KMV(F)
                    Case "MOVISTAR"
                        EQU2 = EQU2 + KMV(F)
                    Case "PRO CYCLING"
                        EQU3 = EQU3 + KMV(F)
                    Case "PRO TEAM"
                        EQU4 = EQU4 + KMV(F)
                End Select

                Select Case EQUIPOV(F)
                    Case "SKY"
                        T1 = T1 + TIEMPOV(F)
                    Case "MOVISTAR"
                        T2 = T2 + TIEMPOV(F)
                    Case "PRO CYCLING"
                        T3 = T3 + TIEMPOV(F)
                    Case "PRO TEAM"
                        T4 = T4 + TIEMPOV(F)
                End Select
            End If
        Next F

        HR1 = Round(T1 / 60, 0)
        HR2 = Round(T2 / 60, 0)
        HR3 = Round(T3 / 60, 0)
        HR4 = Round(T4 / 60, 0)
        R1 = T1 Mod 60
        R2 = T2 Mod 60
        R3 = T3 Mod 60
        R4 = T4 Mod 60

        TextBox14.Text = ESTA1
        TextBox6.Text = Round(EQU1, 2)
        TextBox7.Text = Round(EQU2, 2)
        TextBox8.Text = Round(EQU3, 2)
        TextBox9.Text = Round(EQU4, 2)
        TextBox10.Text = (Round(HR1, 2) & " " & " hr " & Round(R1, 2) & " " & " Min")
        TextBox11.Text = (Round(HR2, 2) & " " & " hr " & Round(R2, 2) & " " & " Min")
        TextBox12.Text = (Round(HR3, 2) & " " & " hr " & Round(R3, 2) & " " & " Min")
        TextBox13.Text = (Round(HR4, 2) & " " & " hr " & Round(R4, 2) & " " & " Min")
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE VUELTA CICLÍSTICA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click

        ETAPAV(INDICE) = Val(TextBox2.Text)
        EQUIPOV(INDICE) = ComboBox1.Text
        KMV(INDICE) = Round(Val(TextBox3.Text), 2)
        TIEMPOV(INDICE) = Round(Val(TextBox4.Text), 2)
        NACIONALIDADV(INDICE) = ComboBox2.Text
        PENAV(INDICE) = Round(CALCULOPENA(TIEMPOV(INDICE), EQUIPOV(INDICE)), 2)
        TOTALV(INDICE) = Round(TIEMPOV(INDICE) + PENAV(INDICE), 2)

        MsgBox("REGISTRO ACTUALIZADO EXITOSAMENTE EN LOS VECTORES")
        INDICE = 12
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim I = 0
        ETAPAV(INDICE) = Nothing
        EQUIPOV(INDICE) = Nothing
        KMV(INDICE) = Nothing
        TIEMPOV(INDICE) = Nothing
        NACIONALIDADV(INDICE) = Nothing
        PENAV(INDICE) = Nothing
        TOTALV(INDICE) = Nothing
        I = INDICE

        While (I <= 10)

            ETAPAV(I) = ETAPAV(I + 1)
            EQUIPOV(I) = EQUIPOV(I + 1)
            KMV(I) = KMV(I + 1)
            TIEMPOV(I) = TIEMPOV(I + 1)
            NACIONALIDADV(I) = NACIONALIDADV(I + 1)
            PENAV(I) = PENAV(I + 1)
            TOTALV(I) = TOTALV(I + 1)
            I = I + 1
        End While
        MsgBox("Registro Eliminado exitosamente")
        'al salir de este ciclo while la variable FILA se queda con valor 4 y la última fila quedará igual que la penúltima fila,
        'para evitar eso se procede a eliminar la última fila de la siguiente forma       
        ETAPAV(I) = Nothing
        EQUIPOV(I) = Nothing
        KMV(I) = Nothing
        TIEMPOV(I) = Nothing
        NACIONALIDADV(I) = Nothing
        PENAV(I) = Nothing
        TOTALV(I) = Nothing

        INDICE = I

        LIMPIAR_ENTRADAS()
        DataGridView1.Rows.Clear()
    End Sub
End Class
