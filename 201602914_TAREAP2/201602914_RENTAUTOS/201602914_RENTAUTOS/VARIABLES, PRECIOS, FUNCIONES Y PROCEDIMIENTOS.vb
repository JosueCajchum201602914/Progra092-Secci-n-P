Module VARIABLES__PRECIOS__FUNCIONES_Y_PROCEDIMIENTOS
    Public Const PHONDA = 250, PMERCEDEZ = 450, PTOYOTA = 325, PMAZDA = 300, PORCENTAJE = 100
    Public SUMAPORCENTAJE As Double
    Public INDICE As Integer


    Public NITV(5) As String
    Public PLACAV(5) As String
    Public MARCAV(5) As String
    Public DIASV(5) As Double
    Public PARCIALV(5) As Double
    Public DESCUENTOV(5) As Double
    Public FINALV(5) As Double

    Function CALCULOPARCIAL(ByVal MARCA As String, ByRef DIAS As Double) As Double
        Select Case MARCA
            Case "Honda"
                CALCULOPARCIAL = PHONDA * DIAS
            Case "Mercedez Benz"
                CALCULOPARCIAL = PMERCEDEZ * DIAS
            Case "Toyota"
                CALCULOPARCIAL = PTOYOTA * DIAS
            Case "Mazda"
                CALCULOPARCIAL = PMAZDA * DIAS
        End Select
        Return CALCULOPARCIAL
    End Function

    Function DESCUENTORECARGO(ByVal EFECTIVO As Double, ByVal TARJETA As Double, ByRef PARCIAL As Double) As Double

        If EFECTIVO = 100 Then
            DESCUENTORECARGO = -(PARCIAL * 5 / 100)
        ElseIf TARJETA = 100 Then
            DESCUENTORECARGO = PARCIAL * 2.5 / 100
        Else
            DESCUENTORECARGO = 0
        End If

        Return DESCUENTORECARGO
    End Function

    Sub LIMPIAR_ENTRADAS()
        RENTAUTOS.TXT_NIT.Text = ""
        RENTAUTOS.TXT_PLACA.Text = ""
        RENTAUTOS.TXT_DIAS.Text = ""
        RENTAUTOS.CMBX_MARCA.Text = ""
        RENTAUTOS.CHBX_EFECTIVO.Checked = False
        RENTAUTOS.CHBX_TARJETA.Checked = False
        RENTAUTOS.TXT_EFECTIVO.Text = ""
        RENTAUTOS.TXT_TARJETA.Text = ""
        RENTAUTOS.TXT_NIT.Focus()
    End Sub

    Sub LIMPIAR_VECTORES()
        RENTAUTOS.LST_NIT.Items.Clear()
        RENTAUTOS.LST_PLACA.Items.Clear()
        RENTAUTOS.LST_MARCA.Items.Clear()
        RENTAUTOS.LST_DIAS.Items.Clear()
        RENTAUTOS.LST_PARCIAL.Items.Clear()
        RENTAUTOS.LST_DESCUENTO.Items.Clear()
        RENTAUTOS.LST_FINAL.Items.Clear()

        INDICE = 0
    End Sub

End Module
