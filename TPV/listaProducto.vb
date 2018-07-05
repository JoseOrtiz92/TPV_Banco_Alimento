Public Class listaProducto
    Dim NombreProducto As String
    Dim categoria As String
    Dim ds As New DataSet
    Public Sub establecerProducto(ByVal e As String)
        categoria = e
    End Sub

    Public Sub rellenar()
        Dim con As New Conexion
        Dim cons As String = "SELECT p.nombre, s.cantidad 'Cantidad Almacen' FROM productos p, stockalmacenes s WHERE s.idProducto=p.id AND p.categoria='" & categoria & "'"
        ds = con.buscar(cons)
        DataGridProductos.DataSource = ds.Tables(0).DefaultView
        DataGridProductos.Show()
    End Sub

    Private Sub DataGridProductos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridProductos.CellMouseDoubleClick
        Try
            NombreProducto = ds.Tables(0).Rows(e.RowIndex).Item(0).ToString
            If NombreProducto <> "" Then
                My.Forms.VentanaEmergenteCantidad.recibirVariables(NombreProducto)
                My.Forms.VentanaEmergenteCantidad.ShowDialog()
            End If
        Catch outRange As System.IndexOutOfRangeException
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Seleccione un cuadro relleno, por favor")
            My.Forms.MsgboxPersonalizado.ShowDialog()
        End Try
    End Sub

    Private Sub btnAgregarCarro_Click(sender As Object, e As EventArgs) Handles btnAgregarCarro.Click
        If DataGridProductos.SelectedCells.Count = 1 Or DataGridProductos.SelectedRows.Count = 1 Then
            NombreProducto = DataGridProductos.Rows(DataGridProductos.CurrentCellAddress.Y).Cells(0).Value
            My.Forms.VentanaEmergenteCantidad.recibirVariables(NombreProducto)
            My.Forms.VentanaEmergenteCantidad.ShowDialog()
        Else

        End If
    End Sub

End Class


