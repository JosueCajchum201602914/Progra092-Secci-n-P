Module VARIABLES_Y_PROCEDIMIENTOS
    Public ETAPAV(12) As Integer
    Public EQUIPOV(12) As String
    Public KMV(12) As Double
    Public TIEMPOV(12) As Double
    Public NACIONALIDADV(12) As String
    Public PENAV(12) As Double
    Public TOTALV(12) As Double


    Public INDICE As Byte = 0
    Public ID As String

    Function CALCULOPENA(ByVal tiempo As Double, ByVal equipo As String) As Double
        Select Case tiempo
            Case 120.0001 To 140
                CALCULOPENA = 30
            Case 140.0001 To 160
                CALCULOPENA = 40
            Case Is > 160
                CALCULOPENA = 50
            Case Is < 85
                Select Case equipo
                    Case "MOVISTAR"
                        CALCULOPENA = -15
                    Case "PRO TEAM"
                        CALCULOPENA = -10
                    Case Else
                        CALCULOPENA = 0
                End Select
            Case Else
                CALCULOPENA = 0
        End Select
        Return CALCULOPENA
    End Function

    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox2.Focus()
    End Sub
    Sub LIMPIAR_VECTORES()
        For FILA As Integer = 0 To 11
            ETAPAV(FILA) = Nothing
            EQUIPOV(FILA) = Nothing
            KMV(FILA) = Nothing
            TIEMPOV(FILA) = Nothing
            NACIONALIDADV(FILA) = Nothing
            PENAV(FILA) = Nothing
            TOTALV(FILA) = Nothing
        Next
        INDICE = 0
    End Sub
    Sub LIMPIAR_ESTADISTICAS()
        Form1.TextBox6.Text = ""
        Form1.TextBox7.Text = ""
        Form1.TextBox8.Text = ""
        Form1.TextBox9.Text = ""
        Form1.TextBox10.Text = ""
        Form1.TextBox11.Text = ""
        Form1.TextBox12.Text = ""
        Form1.TextBox13.Text = ""
        Form1.TextBox14.Text = ""
    End Sub
End Module
