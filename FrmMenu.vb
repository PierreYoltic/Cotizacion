Public Class FrmMenu
    Public fm As Form
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Public Sub AbrirFormInPanel(FormHijo As Object)
        Panel2.Hide()
        If PanelContenedor.Controls.Count > 0 Then
            While PanelContenedor.Controls.Count > 0
                PanelContenedor.Controls.RemoveAt(0)
            End While
        End If
        fm = FormHijo
        fm.TopLevel = False
        fm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(fm)
        fm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCotizacion.Click
        AbrirFormInPanel(New FormCotizacion())
        'Panel2.Hide()
    End Sub

    Private Sub BtnArticulos_Click(sender As Object, e As EventArgs) Handles BtnArticulos.Click
        AbrirFormInPanel(New Articulos())
        'Panel2.Hide()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormInPanel(New Clientes())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormInPanel(New ConsultaCotizacion())
    End Sub
End Class