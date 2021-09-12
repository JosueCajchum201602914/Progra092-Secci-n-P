Module VARIABLES__VECTORES__PROCEDIMIENTOS_Y_FUNCIONES
    Public CineV(8)
    Public FuncionV(8)
    Public N_EntradasV(8)
    Public subtotalV(8)
    Public Descuento1V(8)
    Public Descuento2V(8)
    Public TotalV(8)

    'variables para calculo
    Public calculosub As Double
    Public indice As Integer
    'funciones
    Function calcularSubtotal(Cine As String, Funcion As String) As Double
        Select Case cine
            Case "A"
                Select Case Funcion
                    Case "1"
                        calculosub = 30
                    Case "2"
                        calculosub = 35
                    Case "3"
                        calculosub = 40
                    Case Else
                        calculosub = 40
                End Select
            Case "B"
                Select Case Funcion
                    Case "1"
                        calculosub = 24
                    Case "2"
                        calculosub = 34
                    Case "3"
                        calculosub = 44
                    Case Else
                        calculosub = 44
                End Select
            Case "C"
                Select Case Funcion
                    Case "1"
                        calculosub = 35
                    Case "2"
                        calculosub = 40
                    Case "3"
                        calculosub = 50
                    Case Else
                        calculosub = 50
                End Select
        End Select
        Return calculosub
    End Function

    Function CalcDescuento1(Cine As String, funcion As String) As Double
        If (Cine = "C" Or Cine = "B") And (funcion = "3" Or funcion = "4") Then
            CalcDescuento1 = 0.055
        ElseIf (Cine = "C" Or Cine = "B") And funcion = "1" Then
            CalcDescuento1 = 0.03

        ElseIf Cine = "A" And funcion = "2" Then
            CalcDescuento1 = 0.015
        Else
            CalcDescuento1 = 0
        End If

        Return CalcDescuento1
    End Function

    Function CalcDescuento2(Subtotal As Double) As Double
        If (Subtotal >= 100 And Subtotal < 300) Then
            CalcDescuento2 = 0.02
        ElseIf (Subtotal >= 300 And Subtotal < 500) Then
            CalcDescuento2 = 0.04
        ElseIf (Subtotal >= 500 And Subtotal < 1000) Then
            CalcDescuento2 = 0.06
        Else
            CalcDescuento2 = 0
        End If
        Return CalcDescuento2

    End Function

    Sub LIMPIAR_LISTAS()
        CINE_PROGRA092.LST_CINE.Items.Clear()
        CINE_PROGRA092.LST_FUNCIÓN.Items.Clear()
        CINE_PROGRA092.LST_N_ENT.Items.Clear()
        CINE_PROGRA092.LST_SUBTOTAL.Items.Clear()
        CINE_PROGRA092.LST_DESC1.Items.Clear()
        CINE_PROGRA092.LST_DESC2.Items.Clear()
        CINE_PROGRA092.LST_TOTAL.Items.Clear()
    End Sub

    Sub LIMPIAR_ENTRADAS()
        CINE_PROGRA092.CMB_CINE.Text = ""
        CINE_PROGRA092.CMB_FUNCION.Text = ""
        CINE_PROGRA092.TXT_N_ENTRADAS.Clear()
        CINE_PROGRA092.CMB_CINE.Focus()
    End Sub

    Sub LIMPIAR_VECTORES()
        ReDim CineV(8)
        ReDim FuncionV(8)
        ReDim N_EntradasV(8)
        ReDim subtotalV(8)
        ReDim Descuento1V(8)
        ReDim Descuento2V(8)
        ReDim TotalV(8)
        indice = 0
    End Sub
End Module
