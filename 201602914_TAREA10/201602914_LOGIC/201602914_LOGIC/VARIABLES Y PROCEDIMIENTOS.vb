Module VARIABLES_Y_PROCEDIMIENTOS
    Public DPIV(6) As Integer
    Public NOMBREV(6)
    Public VALORV(6)
    Public MESESV(6)
    Public TASAV(6)
    Public FINALV(6)

    Public INDICE As Integer = 0

    Function CALCULO_TASA(ByVal MESES As Integer, ByVal VALOR As Double) As Double
        If MESES = 12 And VALOR > 8000 Then
            CALCULO_TASA = 0.02
        ElseIf MESES >= 12 And MESES <= 24 Then
            CALCULO_TASA = 0.045
        ElseIf MESES > 24 And MESES <= 36 Then
            CALCULO_TASA = 0.055
        ElseIf MESES > 36 Then
            CALCULO_TASA = 0.062
        ElseIf MESES < 12 Then
            CALCULO_TASA = 0.03
        End If
        Return CALCULO_TASA
    End Function

    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.TextBox1.Focus()
    End Sub
    Sub LIMPIAR_VECTORES()
        For FILA As Integer = 0 To 6
            DPIV(FILA) = Nothing
            NOMBREV(FILA) = Nothing
            VALORV(FILA) = Nothing
            MESESV(FILA) = Nothing
            TASAV(FILA) = Nothing
            FINALV(FILA) = Nothing
        Next
        INDICE = 0
    End Sub
End Module
