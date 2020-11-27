Imports System.Data.SqlClient
Imports System.IO
Public Class EditArticulo
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String
        Dim res = Articulos.BuscarClave(TxtClave.Text)
        If res <> 0 And TxtClave.Text <> claveArticuloSeleccionado Then
            'If TxtClave.Text <> claveArticuloSeleccionado Then
            Articulos.ValidarClaveExistente(TxtClave.Text, Me)
            'End If
        Else
            R = "UPDATE articulo SET codigo=@codigo,descripcion=@desc,precio=@prec,caracteristicas=@caract,img=@img WHERE codigo='" & claveArticuloSeleccionado & "'"
            conexion.Open()
            comando = conexion.CreateCommand
            comando.CommandText = R
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = TxtClave.Text
            comando.Parameters.Add("@desc", SqlDbType.VarChar).Value = TxtDescripcion.Text
            comando.Parameters.Add("@prec", SqlDbType.Decimal).Value = Val(TxtPrecioV.Text)
            comando.Parameters.Add("@caract", SqlDbType.VarChar).Value = TxtCaracteristicas.Text
            comando.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

            comando.ExecuteNonQuery()
            conexion.Close()
            Dim Frm As Articulos = FrmMenu.fm
            Frm.UpdateItems()

            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub EditArticulo_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String = "Select A.codigo, A.descripcion, A.precio, A.caracteristicas, A.img " &
                            "FROM articulo AS A " &
                            "WHERE A.codigo = '" & claveArticuloSeleccionado & "'"

        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        TxtClave.Text = lector(0)
        TxtDescripcion.Text = lector(1)
        TxtPrecioV.Text = lector(2)
        TxtCaracteristicas.Text = lector(3)
        Dim img() As Byte
        img = lector(4)
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
        lector.Close()
        conexion.Close()
    End Sub
End Class