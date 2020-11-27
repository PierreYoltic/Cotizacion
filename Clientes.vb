Imports System.Data.SqlClient
Imports System.IO
Public Class Clientes
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If claveClienteSeleccionado = vbNullString Then
            MessageBox.Show("Debes seleccionar un artículo de la lista para poder editarlo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            EditCliente.StartPosition = FormStartPosition.CenterScreen
            EditCliente.ShowDialog()
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        AddCliente.StartPosition = FormStartPosition.CenterScreen
        AddCliente.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Amlysoftware_tallerDataSet.showActiveClients' table. You can move, or remove it, as needed.
        Me.ShowActiveClientsTableAdapter.Fill(Me.Amlysoftware_tallerDataSet.showActiveClients)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String

        Dim answer As Integer = MessageBox.Show("Estas seguro de eliminar este ciliente?", "CONFIRMACIÓN DE ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            R = "UPDATE cliente
            SET status=" & -1 &
           "WHERE cli_id=" & claveClienteSeleccionado
            comando.CommandText = R
            comando.ExecuteNonQuery()

            'ShowActiveItemsTableAdapter.Fill(Taller_refaccionariaDataSet.showActiveItems)

            UpdateItems()
            conexion.Close()
            claveArticuloSeleccionado = vbNullString
        End If

        conexion.Close()
    End Sub

    Private Sub DataGridViewClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellClick
        claveClienteSeleccionado = DataGridViewClientes.CurrentRow.Cells(0).Value.ToString
    End Sub
    Public Function BuscarClave(ByVal key As String) As Integer
        Dim R As String
        conexion.Open()
        comando = conexion.CreateCommand

        R = "SELECT COUNT(cli_id)
             FROM cliente
             WHERE cli_id = " & key
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        Dim res = Val(lector(0))
        lector.Close()
        conexion.Close()
        Return res
    End Function
    Public Sub UpdateItems()
        ShowActiveClientsBindingSource.EndEdit()
        SqlDataAdapter1.Update(Amlysoftware_tallerDataSet.showActiveClients)
        Amlysoftware_tallerDataSet.showActiveItems.Clear()
        SqlDataAdapter1.Fill(Amlysoftware_tallerDataSet.showActiveClients)
    End Sub
End Class