Imports System.ComponentModel

Public Class CantidadArticulo
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Close()
    End Sub

    Private Sub CantidadArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim frm As FormCotizacion = FrmMenu.fm
        frm.SetCantidad(Val(TxtCantidad.Text), frm.Row)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtCantidad.Text = Val(TxtCantidad.Text) + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtCantidad.Text = Val(TxtCantidad.Text) - 1
    End Sub

    Private Sub CantidadArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As FormCotizacion = FrmMenu.fm
        TxtCantidad.Text = frm.DataGridView1.Rows(frm.Row).Cells(2).Value
    End Sub
End Class