Imports System.ComponentModel

Public Class FrmDescuento
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmDescuento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim frm As FormCotizacion = FrmMenu.fm
        frm.aplicarDescuento(Val(TxtDescuento.Text))
    End Sub
End Class