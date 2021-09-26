Imports System.Math
Public Class RENTAUTOS


    Private Sub CHBX_EFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CHBX_EFECTIVO.CheckedChanged

        If CHBX_EFECTIVO.Checked = True Then
            TXT_EFECTIVO.Enabled = True
            TXT_EFECTIVO.Text = 0
        Else
            TXT_EFECTIVO.Enabled = False
            TXT_EFECTIVO.Text = 0
        End If
    End Sub

    Private Sub CHBX_TARJETA_CheckedChanged(sender As Object, e As EventArgs) Handles CHBX_TARJETA.CheckedChanged
        If CHBX_TARJETA.Checked = True Then
            TXT_TARJETA.Enabled = True
            TXT_TARJETA.Text = 0
        Else
            TXT_TARJETA.Enabled = False
            TXT_TARJETA.Text = 0
        End If
    End Sub


    Private Sub PROCESOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESOSToolStripMenuItem.Click

        If TXT_NIT.Text = "" Then
            MsgBox("NO INGRESÓ NIT, POR FAVOR INGRESE EL NIT DEL CLIENTE") : Exit Sub
        ElseIf Not IsNumeric(TXT_NIT.Text) Then
            MsgBox("NO INGRESÓ UN NÚMERO DE NIT VÁLIDO") : Exit Sub
        End If

        If TXT_PLACA.Text = "" Then
            MsgBox("NO INGRESÓ PLACA DEL AUTO, POR FAVOR INGRESE LA PLACA") : Exit Sub
        End If

        If CMBX_MARCA.Text = "" Then
            MsgBox("NO SELECCIONÓ UNA MARCA DE AUTO") : Exit Sub
        End If

        If TXT_DIAS.Text = "" Then
            MsgBox("NO INGRESÓ NÚMERO DE DÍAS, POR FAVOR INGRESE DÍAS QUE VA A ALQUILAR EL AUTO") : Exit Sub
        ElseIf IsNumeric(TXT_DIAS.Text) = False Then
            MsgBox("NO INGRESÓ UN NÚMERO DE DÍAS VÁLIDO") : Exit Sub
        ElseIf IsNumeric(TXT_DIAS.Text) = True And Val(TXT_DIAS.Text) <= 0 Then
            MsgBox("NO INGRESÓ UN NÚMERO DE DÍAS VÁLIDO") : Exit Sub
        End If
        If CHBX_EFECTIVO.Checked = False And CHBX_TARJETA.Checked = False Then
            MsgBox("NO SELECCIONÓ NINGÚN PORCENTAJE PARA LA FORMA DE PAGO") : Exit Sub
        End If


        SUMAPORCENTAJE = Val(TXT_EFECTIVO.Text) + Val(TXT_TARJETA.Text)

        If SUMAPORCENTAJE < PORCENTAJE Then
            MsgBox("LA SUMA DE LOS PORCENTAJES NO ES IGUAL A 100%, SUME PARA LLEGAR A 100%") : Exit Sub
            TXT_EFECTIVO.Focus()

        ElseIf SUMAPORCENTAJE > PORCENTAJE Then
            MsgBox("LA SUMA DE LOS PORCENTAJES NO ES IGUAL A 100%, RESTE PARA LLEGAR A 100%") : Exit Sub
            TXT_EFECTIVO.Focus()
        End If

        If SUMAPORCENTAJE = PORCENTAJE Then


            If INDICE <= 5 Then

                NITV(INDICE) = TXT_NIT.Text
                PLACAV(INDICE) = TXT_PLACA.Text
                MARCAV(INDICE) = CMBX_MARCA.SelectedItem
                DIASV(INDICE) = Val(TXT_DIAS.Text)
                PARCIALV(INDICE) = CALCULOPARCIAL(MARCAV(INDICE), DIASV(INDICE))
                DESCUENTOV(INDICE) = DESCUENTORECARGO(Val(TXT_EFECTIVO.Text), Val(TXT_TARJETA.Text), PARCIALV(INDICE))
                FINALV(INDICE) = PARCIALV(INDICE) + DESCUENTOV(INDICE)
                LST_NIT.Items.Add(NITV(INDICE))
                LST_PLACA.Items.Add(PLACAV(INDICE))
                LST_MARCA.Items.Add(MARCAV(INDICE))
                LST_DIAS.Items.Add(DIASV(INDICE))
                LST_PARCIAL.Items.Add(Round(PARCIALV(INDICE), 2))
                LST_DESCUENTO.Items.Add(Round(DESCUENTOV(INDICE), 2))
                LST_FINAL.Items.Add(Round(FINALV(INDICE), 2))

                INDICE = INDICE + 1

            End If
            LIMPIAR_ENTRADAS()

            If INDICE = 6 Then

                MsgBox("VECTORES LLENOS, PRESIONAR LIMPIAR VECTORES PARA VOLVER A LLENAR DATOS")
            End If
        End If

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR DE PROGRAMA DE RENTAUTOS") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()

        End If
    End Sub

   
    
End Class
