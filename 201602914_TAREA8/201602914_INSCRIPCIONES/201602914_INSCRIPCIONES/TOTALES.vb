Public Class TOTALES

   

   
    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        Me.Hide()
        INSCRIPCIONES.Show()
    End Sub

    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        LIMPIAR_TOTALES()
    End Sub
End Class