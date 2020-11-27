Imports System.Data.SqlClient
Imports System.IO
Public Class AddArticulo
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim Frm As Articulos = FrmMenu.fm
    Dim file() As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String
        Dim res = Articulos.BuscarClave(TxtClave.Text)


        If res <> 0 Then
            Articulos.ValidarClaveExistente(TxtClave.Text, Me)

        Else

            conexion.Open()
            comando = conexion.CreateCommand

            R = "INSERT INTO articulo(codigo,descripcion,precio,caracteristicas,status,img) VALUES(@codigo,@desc,@precio,@caract,@sta,@img)"
            comando.CommandText = R
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = TxtClave.Text
            comando.Parameters.Add("@desc", SqlDbType.VarChar).Value = TxtDescripcion.Text
            comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = Val(TxtPrecioV.Text)
            comando.Parameters.Add("@caract", SqlDbType.VarChar).Value = TxtCaracteristicas.Text
            comando.Parameters.Add("@sta", SqlDbType.Int).Value = 1
            comando.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

            comando.ExecuteNonQuery()

            conexion.Close()
            Frm.UpdateItems()

            Me.Dispose()
        End If
    End Sub

    Private Sub FindImageInByte(Filename As String)
        Dim oFile As System.IO.FileInfo
        oFile = New System.IO.FileInfo(Filename)
        Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
        Dim lBytes As Long = oFileStream.Length
        If (lBytes > 0) Then
            Dim fileData(lBytes - 1) As Byte
            oFileStream.Read(fileData, 0, lBytes)
            oFileStream.Close()
            file = fileData
            'SaveToDB(fileData)
        End If
    End Sub
    Private Sub SaveToDB(ByVal memStreamOrg As Byte())

        conexion.Open()
        Dim Command As New SqlClient.SqlCommand("Insert into  articulo (img) values( @PicOrig )", conexion)
        Dim PicOrig As SqlClient.SqlParameter
        PicOrig = New SqlClient.SqlParameter("@PicOrig", SqlDbType.Image)
        PicOrig.Value = memStreamOrg
        Command.Parameters.Add(PicOrig)
        Command.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Choose image(*.JPG;*.PNG)|*.JPG;*.PNG"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        'FindImageInByte(OpenFileDialog1.FileName)
    End Sub
End Class