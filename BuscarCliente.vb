Imports System.ComponentModel
Public Class BuscarCliente
    Dim nombre As String
    Dim idCliente As Integer
    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Amlysoftware_tallerDataSet.showActiveClients' table. You can move, or remove it, as needed.
        Me.ShowActiveClientsTableAdapter.Fill(Me.Amlysoftware_tallerDataSet.showActiveClients)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        nombre = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        idCliente = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Me.Close()
    End Sub

    Private Sub BuscarCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim frm As FormCotizacion = FrmMenu.fm
        frm.TxtCliente.Text = nombre
        frm.TxtIdCliente.Text = idCliente
        Me.Dispose()
    End Sub
End Class