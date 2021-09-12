Imports System.Math
Public Class CINE_PROGRA092

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click


        If indice <= 8 Then

            If CMB_CINE.Text = "" Then
                MsgBox("Por favor seleccione un CINE", MsgBoxStyle.Exclamation, "ADVERTENCIA DE SELECCIÓN DE CINE") : Exit Sub
                ' ElseIf ComboBox1.Text = vbNull Then
                'MsgBox("Por favor seleccione un CINE dentro de las opciones", MsgBoxStyle.Exclamation, "ADVERTENCIA DE SELECCIÓN DE CINE") : Exit Sub
            End If

            If CMB_FUNCION.Text = "" Then
                'MsgBox("Por favor seleccione una FUNCIÓN", MsgBoxStyle.Exclamation, "ADVERTENCIA DE SELECCIÓN DE FUNCIÓN") : Exit Sub
                'ElseIf ComboBox2.Text = vbNull Then
                MsgBox("Por favor seleccione una FUNCIÓN dentro de las opciones", MsgBoxStyle.Exclamation, "ADVERTENCIA DE SELECCIÓN DE FUNCIÓN") : Exit Sub
            End If
            If TXT_N_ENTRADAS.Text = "" Then
                MsgBox("No ingresó cantidad de boletos a comprar", MsgBoxStyle.Exclamation, "ADVERTENCIA CANTIDAD DE BOLETOS") : Exit Sub
                TXT_N_ENTRADAS.Focus()
            ElseIf IsNumeric(TXT_N_ENTRADAS.Text) = False Or Val(TXT_N_ENTRADAS.Text) < 0 Then
                MsgBox("No ingresó cantidad válida de boletos a comprar, por favor ingrese una cantidad válida", MsgBoxStyle.Exclamation, "ADVERTENCIA CANTIDAD DE BOLETOS") : Exit Sub
                TXT_N_ENTRADAS.Focus()
            End If
            FuncionV(indice) = CMB_FUNCION.SelectedItem
            CineV(indice) = CMB_CINE.SelectedItem
            N_EntradasV(indice) = Val(TXT_N_ENTRADAS.Text)
            subtotalV(indice) = N_EntradasV(indice) * calcularSubtotal(CineV(indice), FuncionV(indice))
            Descuento1V(indice) = subtotalV(indice) * CalcDescuento1(CineV(indice), FuncionV(indice))
            Descuento2V(indice) = subtotalV(indice) * CalcDescuento2(subtotalV(indice))
            TotalV(indice) = subtotalV(indice) - Descuento1V(indice) - Descuento2V(indice)

            LST_CINE.Items.Add(CineV(indice))
            LST_FUNCIÓN.Items.Add(FuncionV(indice))
            LST_N_ENT.Items.Add(N_EntradasV(indice))
            LST_SUBTOTAL.Items.Add(Round(subtotalV(indice), 2))
            LST_DESC1.Items.Add(Round(Descuento1V(indice), 2))
            LST_DESC2.Items.Add(Round(Descuento2V(indice), 2))
            LST_TOTAL.Items.Add(Round(TotalV(indice), 2))

            indice = indice + 1
        End If
        If indice = 9 Then
            LIMPIAR_LISTAS()
            MsgBox("VECTORES LLENOS, PRESIONAR ''LIMPIAR VECTORES PARA VOLVER A LLENAR DATOS''")
            For j = 0 To 8 Step 1
                indice = j
                LST_CINE.Items.Add(CineV(indice))
                LST_FUNCIÓN.Items.Add(FuncionV(indice))
                LST_N_ENT.Items.Add(N_EntradasV(indice))
                LST_SUBTOTAL.Items.Add(Round(subtotalV(indice), 2))
                LST_DESC1.Items.Add(Round(Descuento1V(indice), 2))
                LST_DESC2.Items.Add(Round(Descuento2V(indice), 2))
                LST_TOTAL.Items.Add(Round(TotalV(indice), 2))
            Next
        End If
        LIMPIAR_ENTRADAS()

    End Sub


    Private Sub ToolStripLIMPIAR_LISTAS_Click(sender As Object, e As EventArgs) Handles ToolStripLIMPIAR_LISTAS.Click
        LIMPIAR_LISTAS()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
        LIMPIAR_LISTAS()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE VENTANA DE COMPRA DE BOLETOS DE CINE") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

   
End Class
