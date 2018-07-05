Public Class ventanaInformes
    Private Sub Line1_Click(sender As Object, e As EventArgs) Handles Line1.Click

    End Sub

    Private Sub btnInfEntradaFecha_Click(sender As Object, e As EventArgs) Handles btnInfEntradaFecha.Click
        If dtpFechaInicio.Value <= dtpFechaFin.Value Then
            My.Forms.InformeEntradaxFecha.agregarFechas(dtpFechaInicio.Value.ToString, dtpFechaFin.Value.ToString)
            My.Forms.InformeEntradaxFecha.ShowDialog()
        Else
            My.Forms.MsgboxPersonalizado.mensajeError("Fecha final no puede ser menor a la de inicio")
            My.Forms.MsgboxPersonalizado.ShowDialog()
        End If
    End Sub

    Private Sub btnInformeStock_Click(sender As Object, e As EventArgs) Handles btnInformeStock.Click
        My.Forms.InformeStock.ShowDialog()
    End Sub

    Private Sub btnGraficoEntrada_Click(sender As Object, e As EventArgs) Handles btnGraficoEntrada.Click
        My.Forms.GraficoEntrada.ShowDialog()
    End Sub

    Private Sub btnGraficoSalida_Click(sender As Object, e As EventArgs) Handles btnGraficoSalida.Click
        My.Forms.GraficoSalida.ShowDialog()
    End Sub
End Class