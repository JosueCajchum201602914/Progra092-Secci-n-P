Module VARIABLES_Y_PROCEDIMIENTOS
    Public EDADV(6) As Integer
    Public GENEROV(6) As String
    Public CODV(6) As String
    Public MONTOV(6) As Double
    Public TALLERV(6) As String
    Public DEDUCIBLEV(6) As Double

    Public GENERO As String
    Public COD As String
    Public TALLER As String
    Public FILA As Byte = 0


    Sub Limpiar_Entradas()
        PRINCIPAL.TXT_EDAD.Clear()
        PRINCIPAL.TXT_MONTO.Clear()
        PRINCIPAL.CMB_CODIGO.Text = ""
        PRINCIPAL.CMB_GENERO.Text = ""
        PRINCIPAL.CMB_TALLER.Text = ""
        PRINCIPAL.TXT_EDAD.Focus()
    End Sub
    Sub LIMPIAR_ESTADISTICAS()
        ESTADISTICAS.TextBox1.Clear()
        ESTADISTICAS.TextBox2.Clear()
        ESTADISTICAS.TextBox3.Clear()
        ESTADISTICAS.TextBox4.Clear()
        ESTADISTICAS.TextBox5.Clear()
        ESTADISTICAS.TextBox6.Clear()
    End Sub
End Module
