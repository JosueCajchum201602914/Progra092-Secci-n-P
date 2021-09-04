Module VARIABLES_Y_TARIFAS

    Public Const Residencial1 = 0.99, Residencial101 = 1.2, Residencial301 = 3
    Public Const Industrial1 = 1.99, Industrial101 = 22.2, Industrial301 = 4
    Public PrecioServicio, MoraV, Desc, PagoTotal, SaldoAnterior As Decimal

    Public Registro As Integer = 0
    
    Public CONSUMIDOR(11) As String
    Public NIT(11) As String
    Public SERVICIO(11) As String
    Public TARIFA(11) As String
    Public SALDO(11) As Double
    Public INICIAL(11) As Double
    Public MORA(11) As Double
    Public DESCUENTO(11) As Double
    Public TOTAL(11) As Double

    Public Sub mostrar_vectores()
        COBRO_LUZ.LST_CONSUMIDOR.Items.Add(CONSUMIDOR(Registro))
        COBRO_LUZ.LST_NIT.Items.Add(NIT(Registro))
        COBRO_LUZ.LST_SERVICIO.Items.Add(SERVICIO(Registro))
        COBRO_LUZ.LST_TARIFA.Items.Add(TARIFA(Registro))
        COBRO_LUZ.LST_SALDO.Items.Add(SALDO(Registro))
        COBRO_LUZ.LST_P_INICIAL.Items.Add(INICIAL(Registro))
        COBRO_LUZ.LST_MORA.Items.Add(MORA(Registro))
        COBRO_LUZ.LST_DESCUENTO.Items.Add(DESCUENTO(Registro))
        COBRO_LUZ.LST_TOTAL.Items.Add(TOTAL(Registro))
    End Sub

    Public Sub Limpiar_entradas()
        COBRO_LUZ.TXT_CONSUMIDOR.Clear()
        COBRO_LUZ.TXT_NIT.Clear()
        COBRO_LUZ.TXT_SALDOANTERIOR.Clear()
        COBRO_LUZ.TXT_CONSUMO.Clear()
        COBRO_LUZ.CMB_SERVICIO.Text = ""
        COBRO_LUZ.CMB_TARIFA.Text = ""
        COBRO_LUZ.TXT_CONSUMIDOR.Focus()
    End Sub
    Public Sub Limpiar_listas()
        Registro = 0
        COBRO_LUZ.LST_CONSUMIDOR.Items.Clear()
        COBRO_LUZ.LST_NIT.Items.Clear()
        COBRO_LUZ.LST_SERVICIO.Items.Clear()
        COBRO_LUZ.LST_TARIFA.Items.Clear()
        COBRO_LUZ.LST_SALDO.Items.Clear()
        COBRO_LUZ.LST_P_INICIAL.Items.Clear()
        COBRO_LUZ.LST_MORA.Items.Clear()
        COBRO_LUZ.LST_DESCUENTO.Items.Clear()
        COBRO_LUZ.LST_TOTAL.Items.Clear()
    End Sub
End Module
