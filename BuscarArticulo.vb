Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class BuscarArticulo
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Public row As Integer

    Private Sub BuscarArticulo_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT * FROM showActiveItems ORDER BY Descripción"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewArticulos.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Public Function CargarArticulo(i As Integer) As String()
        Return {
            DataGridViewArticulos.Rows(i).Cells(0).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(1).Value.ToString,
            DataGridViewArticulos.Rows(i).Cells(2).Value.ToString}
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddArticulo.StartPosition = FormStartPosition.CenterScreen
        AddArticulo.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If claveArticuloSeleccionado = vbNullString Then
            MessageBox.Show("Debes seleccionar un artículo de la lista para poder editarlo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            EditArticulo.StartPosition = FormStartPosition.CenterScreen
            EditArticulo.ShowDialog()
        End If
    End Sub

    Private Sub BuscarArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Frm As FormCotizacion = FrmMenu.fm
        Try
            Frm.AgregarArticulo(CargarArticulo(row))
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
        Me.Dispose()
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged
        DataGridViewArticulos.Rows.Clear()
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT * FROM showActiveItems WHERE Descripción LIKE '%" & TxtCodigo.Text & "%' ORDER BY Descripción"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewArticulos.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub DataGridViewArticulos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewArticulos.CellMouseDoubleClick
        Me.Close()

    End Sub

    Private Sub DataGridViewArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewArticulos.CellClick
        row = e.RowIndex
    End Sub
End Class