Public Class ESTADISTICAS


    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        Me.Hide()
        PRINCIPAL.Show()
    End Sub

    Private Sub BTN_LIMPIARE_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIARE.Click
        LIMPIAR_ESTADISTICAS()
    End Sub
End Class