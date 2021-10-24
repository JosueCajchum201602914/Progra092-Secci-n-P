Module VARIABLES_Y_PROCEDIMIENTOS_HOSPITAL
    Public HOSPITAL(6, 9) As String
    Public INDICE As Byte = 0
    Public ID As String

    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub

    Sub LIMPIAR_ESTADISTICAS()
        Form1.TextBox5.Text = ""
        Form1.TextBox6.Text = ""
        Form1.TextBox7.Text = ""
    End Sub
End Module
