Imports MySql.Data.MySqlClient

Public Class modificarAsociacion
    Dim nombre As String
    Dim direccion As String
    Dim telefono As String

    Public Sub recibirVariables(ByVal Anombre, ByVal Adireccion, ByVal Atelefono)
        nombre = Anombre
        direccion = Adireccion
        telefono = Atelefono
        txtNombre.Text = nombre
        txtTelefono.Text = telefono
        txtDireccion.Text = direccion
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cmp As New Comprobaciones
        If comprobarNombre(txtNombre.Text) = False Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Nombre existente en la base de datos")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If

        If cmp.comprobarComillas(txtNombre.Text) = False Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("El nombre no puede contener comillas")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If

        If cmp.comprobarDireccion(txtDireccion.Text) = False Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Direccion: Mínimo 5 caracteres máximo 50")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If

        If cmp.comprobarComillas(txtDireccion.Text) = False Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("La direccion no puede contener comillas")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If

        If cmp.comprobarTelefono(txtTelefono.Text) = False Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("El numero de telefono debe tener 9 números")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If


        Dim con As New Conexion
        Dim consulta As String = "UPDATE asociaciones SET nombre='" & txtNombre.Text & "', direccion='" & txtDireccion.Text & "', telefono='" & txtTelefono.Text & "' WHERE nombre='" & nombre & "'"
        con.Modificar(consulta)



        'Actualizamos el datagrid de nuievo realizando la consulta para que se nos meustren los nuevos datos
        My.Forms.Asociaciones.actualizardatagrid()
        principal.añadirPanel(Asociaciones)

        My.Forms.MsgboxPersonalizado.mensajeConfirmacion("Datos actualizados correctamente")
        My.Forms.MsgboxPersonalizado.ShowDialog()
    End Sub

    Public Function comprobarNombre(ByVal nombreAsoc)
        Dim conexion As New Conexion
        Dim dr As MySqlDataReader
        Dim consulta As String = "SELECT nombre FROM asociaciones WHERE nombre<>'" & nombre & "'"
        dr = conexion.buscar2(consulta)

        If dr.HasRows Then
            While dr.Read()
                If dr.Item(0) = nombreAsoc And nombreAsoc <> "" Then
                    Return False
                End If
            End While
        End If

        Return True
    End Function

    Private Sub modificarAsociacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class