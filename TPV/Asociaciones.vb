Imports MySql.Data.MySqlClient
Public Class Asociaciones
    Dim ds As New DataSet()
    Private Sub Asociaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizardatagrid()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        My.Forms.AgregarAsociacion.limpiar()
        principal.añadirPanel(AgregarAsociacion)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cmp As New Comprobaciones
        If cmp.comprobarComillas(txtBuscar.Text) = False Then
            My.Forms.MsgboxPersonalizado.mensajeError("Caracteres incorrectos")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If
        Dim conexion As New Conexion
        Dim consulta As String = "SELECT nombre,telefono, direccion FROM asociaciones WHERE (nombre LIKE '%" & txtBuscar.Text & "%') OR (direccion LIKE '%" & txtBuscar.Text & "%')"
        ds = conexion.buscar(consulta)
        gridAsociaciones.DataSource = ds.Tables(0).DefaultView
        gridAsociaciones.Show()
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As DataGridViewRow = gridAsociaciones.CurrentRow
        Dim nombre As String = row.Cells(0).Value.ToString()
        Dim telefono As String = row.Cells(1).Value.ToString()
        Dim direccion As String = row.Cells(2).Value.ToString()
        My.Forms.modificarAsociacion.recibirVariables(nombre, direccion, telefono)
        principal.añadirPanel(modificarAsociacion)
    End Sub

    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        Dim con As New Conexion
        Dim consulta As String = "SELECT nombre, telefono, direccion FROM asociaciones"

        ds = con.buscar(consulta)
        gridAsociaciones.DataSource = ds.Tables(0).DefaultView
        gridAsociaciones.Show()
    End Sub

    Public Sub actualizardatagrid()
        Dim con As New Conexion
        Dim consulta As String = "SELECT nombre, telefono, direccion FROM asociaciones"

        ds = con.buscar(consulta)
        gridAsociaciones.DataSource = ds.Tables(0).DefaultView
        gridAsociaciones.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As DataGridViewRow = gridAsociaciones.CurrentRow
        Dim nombre As String = row.Cells(0).Value.ToString()
        Dim dr As MySqlDataReader
        Dim con As New Conexion
        Dim consu As String = "SELECT count(idAsociacion) from salidas WHERE idAsociacion in (SELECT id FROM asociaciones WHERE nombre='" & nombre & "')"
        dr = con.buscar2(consu)
        If dr.HasRows Then
            While dr.Read()
                If dr.Item(0) = 0 Then
                    If MessageBox.Show("¿Estas seguro de eliminar esta asocicacion?", "Eliminar asociacion", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                        Dim conexion As New Conexion
                        Dim consulta As String = "DELETE FROM asociaciones WHERE nombre='" & nombre & "'"
                        conexion.Eliminar(consulta)
                        actualizardatagrid()
                        My.Forms.MsgboxPersonalizado.mensajeConfirmacion("Asociacion eliminada correctamente")
                        My.Forms.MsgboxPersonalizado.ShowDialog()
                    End If
                Else
                    My.Forms.MsgboxPersonalizado.mensajeError("No puedes eliminar una asociacion a la que ya se ha donado")
                    My.Forms.MsgboxPersonalizado.ShowDialog()
                End If
            End While
        End If
    End Sub

End Class