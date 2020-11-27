Imports System.Data.SqlClient
Imports System.IO
Public Class EditCliente
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String

        R = "UPDATE cliente SET nombre=@nombre,
                                domicilio=@domicilio,
                                noExt=@noExt,
                                noInt=@noInt,
                                localidad=@localidad,
                                ciudad=@ciudad,
                                estado=@estado,
                                pais=@pais,
                                cp=@cp,
                                rfc=@rfc,
                                colonia=@colonia,
                                telefono=@telefono,
                                celular=@celular,
                                mail=@mail,
                                comentario=@comentario,
                                foto=@foto WHERE cli_id=" & claveClienteSeleccionado
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = R
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        comando.Parameters.Add("@id", SqlDbType.Int).Value = Val(TxtID.Text)
        comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
        comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = TxtCalle.Text
        comando.Parameters.Add("@noExt", SqlDbType.VarChar).Value = TxtNumExt.Text
        comando.Parameters.Add("@noInt", SqlDbType.VarChar).Value = TxtNumInt.Text
        comando.Parameters.Add("@localidad", SqlDbType.VarChar).Value = TxtLocalidad.Text
        comando.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = TxtCiudad.Text
        comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = ComboBoxEstado.SelectedItem.ToString
        comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = TxtPais.Text
        comando.Parameters.Add("@cp", SqlDbType.VarChar).Value = TxtCP.Text
        comando.Parameters.Add("@rfc", SqlDbType.VarChar).Value = TxtRFC.Text
        comando.Parameters.Add("@colonia", SqlDbType.VarChar).Value = TxtColonia.Text
        comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = TxtTelefono.Text
        comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = TxtCelular.Text
        comando.Parameters.Add("@mail", SqlDbType.VarChar).Value = TxtEmail.Text
        comando.Parameters.Add("@comentario", SqlDbType.VarChar).Value = TxtComentario.Text
        comando.Parameters.Add("@satus", SqlDbType.Int).Value = 1
        comando.Parameters.Add("@foto", SqlDbType.Image).Value = ms.ToArray()

        comando.ExecuteNonQuery()
        conexion.Close()
        Dim Frm As Clientes = FrmMenu.fm
        Frm.UpdateItems()

        Me.Dispose()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub EditCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String = "Select * " &
                            "FROM cliente AS C " &
                            "WHERE C.cli_id = " & claveClienteSeleccionado

        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()

        TxtID.Text = lector(0)
        TxtNombre.Text = lector(1)
        TxtCalle.Text = lector(2)
        TxtNumExt.Text = lector(3)
        TxtNumInt.Text = lector(4)
        TxtLocalidad.Text = lector(5)
        TxtCiudad.Text = lector(6)
        ComboBoxEstado.Text = lector(7)
        TxtPais.Text = lector(8)
        TxtCP.Text = lector(9)
        TxtRFC.Text = lector(10)
        TxtColonia.Text = lector(11)
        TxtTelefono.Text = lector(12)
        TxtCelular.Text = lector(13)
        TxtEmail.Text = lector(14)
        TxtComentario.Text = lector(15)

        Dim img() As Byte
        img = lector(16)
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Choose image(*.JPG;*.PNG)|*.JPG;*.PNG"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

End Class