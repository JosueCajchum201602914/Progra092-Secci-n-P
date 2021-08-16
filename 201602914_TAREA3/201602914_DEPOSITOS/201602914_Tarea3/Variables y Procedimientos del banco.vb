Module Variables_y_Procedimientos_del_banco
    Public Interes, InteresCalculado, Saldo_nuevo, Saldo_Anterior As Double

    Sub LIMPIAR_ENTRADAS()
        'darse cuenta que en cada instrucción se invoca el nombre de la clase a la que pertenece el objeto respectivo
        Form1.TBX_CHEQUEO.Clear()
        Form1.TBX_CHEQUEP.Clear()
        Form1.TBX_EFECTIVO.Clear()
        Saldofinal_Deposito.TBX_INTERÉS.Clear()
        Form1.TBX_SALDOANTERIOR.Clear()
        Saldofinal_Deposito.TBX_SALDOFINAL.Clear()
        Saldofinal_Deposito.TBX_SALDONUEVO.Clear()
        Form1.CBX_CHEQUEO.Checked = False
        Form1.CBX_CHEQUEP.Checked = False
        Form1.CBX_EFECTIVO.Checked = False
        Form1.RBN_AHORRO.Checked = False
        Form1.RBN_MONETARIO.Checked = False
        Form1.RBN_MONETARIO.Checked = False
        Interes = 0
        InteresCalculado = 0
        Saldo_Anterior = 0
        Saldo_nuevo = 0
        Form1.TBX_CHEQUEO.Focus()
        

    End Sub

End Module
