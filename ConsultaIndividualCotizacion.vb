Imports System.Data.SqlClient
Public Class ConsultaIndividualCotizacion
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim Frm As ConsultaCotizacion = FrmMenu.fm

    Private Sub ConsultaIndividualCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand

        Dim cotId As Integer = Val(claveVentaSeleccionada)
        Dim R As String = "SELECT C.nombre, C.domicilio, C.ciudad, C.estado, C.cp, Cot.fecha, Cot.total, Cot.descuento " &
                          "FROM cliente AS C INNER JOIN cotizacion AS Cot ON Cot.cli_id = C.cli_id " &
                          "WHERE Cot.cot_id = " & cotId
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        LblNombre.Text = lector(0)
        LblDomicilio.Text = lector(1)
        LblCiudad.Text = lector(2)
        LblEstado.Text = lector(3)
        LblCP.Text = lector(4)
        LblDate.Text = lector(5)
        LblFolio.Text = cotId
        LblTotal.Text = "Total: $" & lector(6) & " MXN"
        LblDescuento.Text = "Descuento: $" & lector(7)
        lector.Close()

        R = "SELECT DC.cantidad, DC.codigo, A.descripcion, DC.precio FROM detallecotizacion AS DC " &
            "INNER JOIN articulo AS A ON A.codigo = DC.codigo " &
            "INNER JOIN cotizacion AS Cot ON Cot.cot_id = DC.cot_id " &
            "WHERE DC.cot_id = " & cotId
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewVenta.Rows.Add(lector(1), lector(2), lector(0), lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class