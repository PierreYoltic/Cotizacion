Imports System.ComponentModel

Public Class CambiarImporte
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Close()
    End Sub

    Private Sub CambiarImporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As FormCotizacion = FrmMenu.fm
        TxtImporte.Text = frm.DataGridView1.Rows(frm.Row).Cells(4).Value
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub CambiarImporte_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim frm As FormCotizacion = FrmMenu.fm
        frm.ActualizarImporte(Val(TxtImporte.Text))
    End Sub
End Class