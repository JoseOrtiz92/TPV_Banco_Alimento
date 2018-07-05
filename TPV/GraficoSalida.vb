Public Class GraficoSalida
    Private Sub GraficoSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsGraficoSalida.graficosalida' Puede moverla o quitarla según sea necesario.
        Me.GraficosalidaTableAdapter.Fill(Me.DsGraficoSalida.graficosalida)

        Dim rpt As New CRGraficoSalida
        rpt.SetDataSource(DsGraficoSalida)
        CRViewerGraficoSalida.ReportSource = rpt

    End Sub
End Class