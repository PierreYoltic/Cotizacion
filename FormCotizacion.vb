Imports System.Data.SqlClient
Public Class FormCotizacion
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=amlysoftware_taller; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Dim transaction As SqlTransaction
    Dim IdCotizacion As Integer
    Public Row As Integer = -1
    Public Total As Decimal = 0
    Dim Descuento As Decimal
    Dim Subtotal As Decimal = 0

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        If Row <> -1 Then
            DataGridView1.Rows.Remove(DataGridView1.Rows(Row))
        Else
            MsgBox("Selecciona un Artículo para continuar")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles BtnDescuento.Click
        FrmDescuento.StartPosition = FormStartPosition.CenterParent
        FrmDescuento.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BtnImporte.Click

        If Row <> -1 Then
            CambiarImporte.StartPosition = FormStartPosition.CenterParent
            CambiarImporte.ShowDialog()
        Else
            MsgBox("Selecciona un Artículo para continuar")
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BuscarArticulo.StartPosition = FormStartPosition.CenterParent
        BuscarArticulo.ShowDialog()
    End Sub
    Public Sub AgregarArticulo(ByVal art As String())
        MsgBox(art(0) & art(1) & art(2))
        'Dim Frm As Ventas = FormMenu.fm
        For i = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells(0).Value = art(0) Then
                SetCantidad(Val(DataGridView1.Rows(i).Cells(2).Value) + 1, i)
                CalcularTotal()
                Exit Sub
            End If
        Next
        DataGridView1.Rows.Add(art(0), art(1), "1", art(2), art(2))
        CalcularTotal()
    End Sub

    Private Sub FormCotizacion_Load(sender As Object, e As EventArgs) Handles Me.Load

        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT COUNT(*) FROM cotizacion"
        IdCotizacion = comando.ExecuteScalar + 1
        conexion.Close()

        TxtId.Text = IdCotizacion
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        row = e.RowIndex
    End Sub

    Private Sub BtnCantidad_Click(sender As Object, e As EventArgs) Handles BtnCantidad.Click
        If Row <> -1 Then
            CantidadArticulo.StartPosition = FormStartPosition.CenterParent
            CantidadArticulo.ShowDialog()
        Else
            MsgBox("Selecciona un Artículo para continuar")
        End If

    End Sub
    Public Sub SetCantidad(cant As Integer, i As Integer)
        DataGridView1.Rows(i).Cells(2).Value = cant
        DataGridView1.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(3).Value * cant
        CalcularTotal()
    End Sub
    Public Sub aplicarDescuento(desc As Decimal)
        Descuento = desc
        LblDescuento.Text = "Descuento: $ " & Descuento
        CalcularTotal()
    End Sub
    Public Sub ActualizarImporte(imp As Decimal)
        DataGridView1.Rows(Row).Cells(4).Value = imp
        CalcularTotal()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        BuscarCliente.StartPosition = FormStartPosition.CenterParent
        BuscarCliente.Show()
    End Sub

    Private Sub CalcularTotal()
        Subtotal = 0
        For i = 0 To DataGridView1.RowCount - 1
            Subtotal += DataGridView1.Rows(i).Cells(4).Value
        Next
        Total = Subtotal - Descuento

        LblTotal.Text = "Total: $" & Total & " MXN"

    End Sub
    Public Sub Cerrar()
        conexion.Open()
        comando = conexion.CreateCommand

        transaction = conexion.BeginTransaction("SampleTransaction")

        comando.Connection = conexion
        comando.Transaction = transaction

        Try
            Dim R = "INSERT INTO cotizacion
                VALUES(" & IdCotizacion & "," & Val(TxtIdCliente.Text) & ",'" & DTPFecha.Value & "'," & Subtotal &
                     "," & Descuento & "," & Total & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()

            For i = 0 To DataGridView1.RowCount - 1
                R = "INSERT INTO detallecotizacion
                VALUES(" & IdCotizacion & ",'" & DataGridView1.Rows(i).Cells(0).Value &
                                        "'," & DataGridView1.Rows(i).Cells(2).Value &
                                         "," & DataGridView1.Rows(i).Cells(4).Value & ")"
                comando.CommandText = R
                comando.ExecuteNonQuery()
            Next
            If MsgBox("Desea ejecutar transacción", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
                MsgBox("OK")
            Else
                transaction.Rollback()
                MsgBox("Transacción cancelada")
            End If

        Catch ex As Exception
            MsgBox("Commit Exception Type: {0} no se pudo insertar por error")
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MsgBox("Error Rollback")
            End Try
        End Try
        conexion.Close()
        FrmMenu.AbrirFormInPanel(New FormCotizacion)
        Me.Dispose()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ans As String
        If TxtIdCliente.Text = "-" Then
            MsgBox("Debe seleccionar un cliente para continuar")
            Exit Sub
        End If
        ans = MessageBox.Show("Estas seguro de guardar esta cotización?", "Cerrar Cotización", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Cerrar()
        End If
    End Sub
End Class
