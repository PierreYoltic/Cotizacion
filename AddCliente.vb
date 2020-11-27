Imports System.Data.SqlClient
Imports System.IO
Public Class AddCliente
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim IdCliente
    Dim Frm As Clientes = FrmMenu.fm

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String

        conexion.Open()
        comando = conexion.CreateCommand

        R = "INSERT INTO cliente VALUES(@id,@nombre,@domicilio,@noExt,@noInt,@localidad,@ciudad,@estado,@pais,@cp,@rfc,@colonia,@telefono,@celular,@mail,@comentario,@satus,@foto)"
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
        Frm.UpdateItems()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Choose image(*.JPG;*.PNG)|*.JPG;*.PNG"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        'FindImageInByte(OpenFileDialog1.FileName)
    End Sub

    Private Sub AddCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String = "SELECT COUNT(*) FROM cliente"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        IdCliente = lector(0) + 1
        TxtID.Text = IdCliente
        conexion.Close()
    End Sub
End Class