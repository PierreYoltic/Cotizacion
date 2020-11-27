Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.ComponentModel
Public Class ConsultaCotizacion
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Public Row As Integer
    Public cliid As Integer
    Private Sub showCotizacion()
        Dim FechaFinal As DateTime = DTPFechaFinal.Value
        FechaFinal = DateTime.Parse(FechaFinal.Date & " 23:59:59")
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "EXEC showCotizacion @DateFrom = '" & DTPFechaInicial.Text & "'," &
                              " @DateTo = '" & FechaFinal & "'"
        lector = comando.ExecuteReader
        While lector.Read
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        conexion.Close()
    End Sub

    Private Sub DTPFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinal.ValueChanged
        DataGridView1.Rows.Clear()
        showCotizacion()
    End Sub

    Private Sub DTPFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaInicial.ValueChanged
        DataGridView1.Rows.Clear()
        showCotizacion()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Row = e.RowIndex
        claveVentaSeleccionada = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub ConsultaCotizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        showCotizacion()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ConsultaIndividualCotizacion.StartPosition = FormStartPosition.CenterParent
        ConsultaIndividualCotizacion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion.Open()
        comando = conexion.CreateCommand

        Dim cotId As Integer = DataGridView1.Rows(Row).Cells(1).Value
        Dim R As String = "SELECT C.nombre, C.domicilio, C.ciudad, C.mail, C.rfc, C.telefono, C.celular, Cot.fecha, Cot.total, Cot.descuento " &
                          "FROM cliente AS C INNER JOIN cotizacion AS Cot ON Cot.cli_id = C.cli_id " &
                          "WHERE Cot.cot_id = " & cotId
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        Dim nombre As String = lector(0)
        Dim domicilio As String = lector(1)
        Dim ciudad As String = lector(2)
        Dim email As String = lector(3)
        Dim rfc As String = lector(4)
        Dim tel As String = lector(5)
        Dim cel As String = lector(6)

        Dim fecha As String = lector(7)
        Dim folio As String = cotId
        Dim total As String = lector(8)
        Dim descuento As String = lector(9)
        lector.Close()

        R = "reporteCotizacion @Cot = " & cotId

        MsgBox(R)

        Dim Data As New DataSet("Data1")

        Dim command As New SqlCommand(R, conexion)
        Dim Adaptador As New SqlDataAdapter(command)
        Adaptador.Fill(Data)

        'MsgBox(Adaptador.ToString)
        'Data.DataSetName = "Data1"


        Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
        DataSource.Name = "DataSet1"
        DataSource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("fecha", fecha)
        Dim p2 As New ReportParameter("descuento", descuento)
        Dim p3 As New ReportParameter("total", total)
        Dim p4 As New ReportParameter("folio", folio)
        Dim p5 As New ReportParameter("nombre", nombre)
        Dim p6 As New ReportParameter("email", email)
        Dim p7 As New ReportParameter("domicilio", domicilio)
        Dim p8 As New ReportParameter("ciudad", ciudad)
        Dim p9 As New ReportParameter("rfc", rfc)
        Dim p10 As New ReportParameter("tel", tel)
        Dim p11 As New ReportParameter("cel", cel)

        Dim Frm As New FormReporteCotizacion

        Frm.ReportViewer1.LocalReport.ReportPath = "C:\Users\Pierre Yoltic\source\repos\Prototipo Cotizacion\ReporteCotizacion.rdlc"

        Frm.ReportViewer1.LocalReport.DataSources.Clear()
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Frm.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        'ReporteExistenciaArticulos.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ReporteAsistenciaMenores.rdlc"
        Frm.ReportViewer1.LocalReport.EnableHyperlinks = True
        Frm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11})
        Frm.ReportViewer1.RefreshReport()
        Frm.WindowState = FormWindowState.Maximized
        FrmMenu.AbrirFormInPanel(New ConsultaCotizacion)
        Frm.Show()
        conexion.Close()

        Me.Dispose()
    End Sub
End Class