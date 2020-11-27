Imports System.Data.SqlClient
Imports System.IO
Public Class Articulos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        AddArticulo.StartPosition = FormStartPosition.CenterScreen
        AddArticulo.Show()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If claveArticuloSeleccionado = vbNullString Then
            MessageBox.Show("Debes seleccionar un artículo de la lista para poder editarlo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            EditArticulo.StartPosition = FormStartPosition.CenterScreen
            EditArticulo.ShowDialog()
        End If
    End Sub

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Amlysoftware_tallerDataSet.showActiveItems' table. You can move, or remove it, as needed.
        Me.ShowActiveItemsTableAdapter.Fill(Me.Amlysoftware_tallerDataSet.showActiveItems)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String

        Dim answer As Integer = MessageBox.Show("Estas seguro de eliminar este artículo?", "CONFIRMACIÓN DE ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            R = "UPDATE articulo
            SET status=" & -1 &
           "WHERE codigo='" & claveArticuloSeleccionado & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()

            'ShowActiveItemsTableAdapter.Fill(Taller_refaccionariaDataSet.showActiveItems)
            '
            'DataGridViewArticulos
            UpdateItems()
            conexion.Close()
            claveArticuloSeleccionado = vbNullString
        End If

        conexion.Close()
    End Sub

    Private Sub DataGridViewArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewArticulos.CellClick
        claveArticuloSeleccionado = DataGridViewArticulos.CurrentRow.Cells(0).Value.ToString

        LblDesc.Text = DataGridViewArticulos.Rows(e.RowIndex).Cells(1).Value
        LblPrecio.Text = "$" & DataGridViewArticulos.Rows(e.RowIndex).Cells(2).Value

        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT img FROM articulo WHERE codigo ='" & DataGridViewArticulos.Rows(e.RowIndex).Cells(0).Value & "'"
        lector = comando.ExecuteReader
        lector.Read()
        Dim img() As Byte
        img = lector(0)
        Dim ms As New MemoryStream(img)
        PictureBoxImg.Image = Image.FromStream(ms)
        conexion.Close()
    End Sub
    Public Function BuscarClave(ByVal key As String) As Integer
        Dim R As String
        conexion.Open()
        comando = conexion.CreateCommand

        R = "SELECT COUNT(codigo)
             FROM articulo
             WHERE codigo = '" & key & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        Dim res = Val(lector(0))
        lector.Close()
        conexion.Close()
        Return res
    End Function
    Public Sub ValidarClaveExistente(ByVal key As String, ByRef form As Form)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String = "SELECT status
             FROM articulo
             WHERE codigo = '" & key & "'"

        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        Dim res = Val(lector(0))
        lector.Close()

        If res = 1 Then
            MessageBox.Show("Ya existe un artículo con el mismo CÓDIGO, debes cambiarla", "CÓDIGO REPETIDO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
            Exit Sub
        ElseIf res = -1 Then
            MessageBox.Show("El artículo que intentas agregar tiene un código de un Artículo eliminado, por lo tanto se recuperará", "CÓDIGO ANTERIORMENTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'lector.Close()
            R = "UPDATE articulo SET status = 1 WHERE codigo='" & key & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            conexion.Close()
            Me.Dispose()
            FrmMenu.AbrirFormInPanel(New Articulos())
            form.Dispose()
        End If
    End Sub
    Public Sub UpdateItems()
        ShowActiveItemsBindingSource.EndEdit()

        SqlDataAdapter1.Update(Amlysoftware_tallerDataSet.showActiveItems)
        Amlysoftware_tallerDataSet.showActiveItems.Clear()
        SqlDataAdapter1.Fill(Amlysoftware_tallerDataSet.showActiveItems)
    End Sub

    Private Sub DataGridViewArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewArticulos.CellContentClick
        'LblDesc.Text = DataGridViewArticulos.Rows(e.RowIndex).Cells(1).Value
        'LblPrecio.Text = "$" & DataGridViewArticulos.Rows(e.RowIndex).Cells(2).Value

        '        conexion.Open()
        '       comando = conexion.CreateCommand
        '      comando.CommandText = "SELECT img FROM articulo WHERE codigo ='" & DataGridViewArticulos.Rows(e.RowIndex).Cells(0).Value & "'"
        '     lector = comando.ExecuteReader
        '    lector.Read()
        '   Dim img() As Byte
        '  img = lector(0)
        ' Dim ms As New MemoryStream(img)
        'PictureBoxImg.Image = Image.FromStream(ms)
        'conexion.Close()

    End Sub



End Class