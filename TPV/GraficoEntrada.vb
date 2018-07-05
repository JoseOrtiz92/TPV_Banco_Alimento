Public Class GraficoEntrada
    Private Sub GraficoEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsGraficoEntrada.graficoentrada' Puede moverla o quitarla según sea necesario.
        Me.GraficoentradaTableAdapter.Fill(Me.DsGraficoEntrada.graficoentrada)

        Dim rpt As New CRGraficoEntrada
        rpt.SetDataSource(DsGraficoEntrada)
        CRViewerGraficoEntrada.ReportSource = rpt

    End Sub
End Class