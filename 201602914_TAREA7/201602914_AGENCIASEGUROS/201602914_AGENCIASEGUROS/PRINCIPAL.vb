Imports System.Math
Public Class PRINCIPAL

    Private Sub BTN_LIMPIARV_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIARV.Click
        Dim J As Byte

        For J = 0 To 6
            EDADV(J) = Nothing
            GENEROV(J) = Nothing
            CODV(J) = Nothing
            MONTOV(J) = Nothing
            TALLERV(J) = Nothing
            DEDUCIBLEV(J) = Nothing
        Next J
        DataGridView1.Rows.Clear()
        FILA = 0
    End Sub

    Private Sub BTN_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR.Click
        If (FILA <= 6) Then
            If TXT_EDAD.Text = "" Or TXT_MONTO.Text = "" Or CMB_CODIGO.Text = "" Or CMB_GENERO.Text = "" Or CMB_TALLER.Text = "" Then
                MsgBox("POR FAVOR, LLENE TODOS LOS CAMPOS", , "ADVERTENCIA DE ENTRADA DE DATOS AGENCIA SEGUROS")
                Exit Sub
            End If
            If IsNumeric(TXT_EDAD.Text) = 0 Or Val(TXT_EDAD.Text) < 0 Or ((TXT_EDAD.Text Mod 1) = 0) = False Then
                MsgBox("Ingrese una edad válida", , "ADVERTENCIA EDAD AGENCIA SEGUROS")
                Exit Sub
                TXT_EDAD.Focus()
            End If
            If IsNumeric(TXT_MONTO.Text) = 0 Or Val(TXT_MONTO.Text) < 0 Then
                MsgBox("Ingrese un monto válido", , "ADVERTENCIA MONTO AGENCIA SEGUROS")
                Exit Sub
                TXT_MONTO.Focus()
            End If

            If CMB_GENERO.Text = "MASCULINO" Then
                GENERO = "M"
            End If
            If CMB_GENERO.Text = "FEMENINO" Then
                GENERO = "F"
            End If
            If Val(CMB_CODIGO.Text) = 1 Then
                COD = "Guatemalteco"
            End If
            If Val(CMB_CODIGO.Text) = 0 Then
                COD = "Extranjero"
            End If
            If CMB_TALLER.Text = "TALLER DE CONFIANZA" Then
                TALLER = "DE CONFIANZA"
            End If
            If CMB_TALLER.Text = "PROPORCIONADO POR ASEGURADORA" Then
                TALLER = "ASEGURADORA"
            End If
            EDADV(FILA) = Val(TXT_EDAD.Text)
            GENEROV(FILA) = GENERO
            CODV(FILA) = COD
            MONTOV(FILA) = Round(Val(TXT_MONTO.Text), 2)
            TALLERV(FILA) = TALLER
            DEDUCIBLEV(FILA) = Round(Val(TXT_MONTO.Text) * 6 / 100, 2)

            FILA = FILA + 1
        End If
        Limpiar_Entradas()
        If (FILA = 7) Then
            MsgBox("VECTORES LLENOS", , "AGENCIA SEGUROS")
        End If
    End Sub

    Private Sub BTN_RMOSTRAR_Click(sender As Object, e As EventArgs) Handles BTN_RMOSTRAR.Click
        Dim X As Byte

        DataGridView1.Rows.Clear()
        For X = 0 To 6
            If EDADV(X) <> Nothing Then
                DataGridView1.Rows.Add(Str(EDADV(X)), GENEROV(X), CODV(X), MONTOV(X), TALLERV(X), DEDUCIBLEV(X))
            Else
                Exit For
            End If
        Next X
    End Sub

    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        Limpiar_Entradas()
    End Sub

    Private Sub BTN_ESTADÍSTICAS_Click(sender As Object, e As EventArgs) Handles BTN_ESTADÍSTICAS.Click
        Dim E1 As Byte = 0
        Dim E2 As Byte = 0
        Dim E3 As Byte = 0, E4 As Byte = 0
        Dim E5 As Byte = 0, E6 As Double = 0

        For K = 0 To 6
            If (EDADV(K) < 25 And EDADV(K) <> 0) Then
                E1 = E1 + 1
            End If
            If (GENEROV(K) = "F") Then
                E2 = E2 + 1
            End If
            If (GENEROV(K) = "M") And (EDADV(K) >= 18 And EDADV(K) <= 25) Then
                E3 = E3 + 1
            End If
            If (CODV(K) = "Extranjero") Then
                E4 = E4 + 1
            End If
            If EDADV(K) <> Nothing Then
                E5 = E5 + 1
            End If
            If MONTOV(K) <> Nothing Then
                E6 = E6 + MONTOV(K)
            End If
            ESTADISTICAS.TextBox1.Text = Str(Round(E1 / E5 * 100, 2))
            ESTADISTICAS.TextBox2.Text = Str(Round(E2 / E5 * 100, 2))
            ESTADISTICAS.TextBox3.Text = Str(Round(E3 / E5 * 100, 2))
            ESTADISTICAS.TextBox4.Text = Str(Round(E4 / E5 * 100, 2))
            ESTADISTICAS.TextBox5.Text = Str(E5)
            ESTADISTICAS.TextBox6.Text = Str(E6)
        Next K
        Me.Hide()
        ESTADISTICAS.Show()

    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE AGENCIA SEGUROS") = vbYes) Then
            End
        Else
            Limpiar_Entradas()
        End If
    End Sub


End Class
