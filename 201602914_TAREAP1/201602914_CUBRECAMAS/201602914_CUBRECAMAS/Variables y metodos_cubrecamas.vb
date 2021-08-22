Module Variables_y_metodos_cubrecamas

    Public precioImp = 65.5, precioMat = 85.99, precioQuee = 99.99, precioKing = 105.99
    Public precioLino = 15, precioAlg = 23.99, precioSeda = 30.99, precioHilo = 39.99
    Public yardamaxImp = 3, yardamaxMat = 5, yardamaxQuee = 6, yardamaxKing = 7
    Public SumaYardas = 0, PrecioCosto = 0, PrecioVenta = 0


    Sub Limpiar_entradas()
        SumaYardas = 0
        PrecioCosto = 0
        PrecioVenta = 0
        Form1.CBX_LINO.Checked = False
        Form1.CBX_ALGODON.Checked = False
        Form1.CBX_SEDA.Checked = False
        Form1.CBX_HILO.Checked = False
        Form1.RBN_IMPERIAL.Checked = False
        Form1.RBN_MATRIMONIAL.Checked = False
        Form1.RBN_QUEEN.Checked = False
        Form1.RBN_KING.Checked = False
        Form1.TXT_LINO.Clear()
        Form1.TXT_ALGODON.Clear()
        Form1.TXT_SEDA.Clear()
        Form1.TXT_HILO.Clear()
        Form1.TXT_COSTO.Clear()
        Form1.TXT_VENTA.Clear()
        Form1.LBL_LINO.Text = "Total a pagar por lino:"
        Form1.LBL_ALGODON.Text = "Total a pagar por Algodón:"
        Form1.LBL_SEDA.Text = "Total a pagar por Seda:"
        Form1.LBL_HILO.Text = "Total a pagar por Hilo:"
        Form1.TXT_LINO.Focus()
    End Sub

End Module
