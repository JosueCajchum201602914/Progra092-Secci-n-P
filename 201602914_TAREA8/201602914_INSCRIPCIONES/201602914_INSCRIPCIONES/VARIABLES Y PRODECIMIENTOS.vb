Module VARIABLES_Y_PRODECIMIENTOS
    Public INSCRIPCIONESM(7, 8) As String

    Public NIVEL As String
    Public ED1, ED2, ED3, ED6, ED0 As String
    Public PAGOINICIAL As Double
    Public Const CIBASIC = 350, CIDIVER = 450, CMBASIC = 250, CMDIVER = 350
    Public FILA As Byte = 0


    Function RECARGO(ByVal PAGO As String, ByVal RECAR As Double) As Double
        If PAGO = "TARJETA DE CRÉDITO" Then
            RECARGO = 0.1 * RECAR
        Else
            RECARGO = 0
        End If
        Return RECARGO
    End Function

    Sub LIMPIAR_ENTRADAS()
        INSCRIPCIONES.TXT_CARNET.Text = ""
        INSCRIPCIONES.TXT_NOMBRE.Text = ""
        INSCRIPCIONES.RBN_BASICO.Checked = False
        INSCRIPCIONES.RBN_DIVERSIFICADO.Checked = False
        INSCRIPCIONES.CMB_CARRERA.Text = ""
        INSCRIPCIONES.CMB_PAGO.Text = ""
    End Sub

    Sub LIMPIAR_MATRIZ()
        Dim i As Byte, j As Byte


        For i = 0 To 6
            For j = 0 To 7
                INSCRIPCIONESM(i, j) = Nothing
            Next j
        Next i

        INSCRIPCIONES.DataGridView1.Rows.Clear()

        FILA = 0

    End Sub

    Sub LIMPIAR_TOTALES()
        TOTALES.TextBox1.Text = ""
        TOTALES.TextBox2.Text = ""
        TOTALES.TextBox3.Text = ""
        TOTALES.TextBox4.Text = ""
        TOTALES.TextBox5.Text = ""
        TOTALES.TextBox6.Text = ""
        TOTALES.TextBox7.Text = ""
        TOTALES.TextBox8.Text = ""
        TOTALES.TextBox9.Text = ""
        TOTALES.TextBox10.Text = ""
        TOTALES.TextBox11.Text = ""
    End Sub
End Module
