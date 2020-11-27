<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCotizacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.LblDescuento = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TxtId = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnImporte = New System.Windows.Forms.Button()
        Me.BtnDescuento = New System.Windows.Forms.Button()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnCantidad = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 504)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Cant, Me.PrecioU, Me.Importe})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(82, 171)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(766, 261)
        Me.DataGridView1.TabIndex = 4
        '
        'Codigo
        '
        Me.Codigo.FillWeight = 124.2654!
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 327.9989!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Cant
        '
        Me.Cant.FillWeight = 69.77472!
        Me.Cant.HeaderText = "Cantidad"
        Me.Cant.MinimumWidth = 6
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'PrecioU
        '
        Me.PrecioU.FillWeight = 66.43593!
        Me.PrecioU.HeaderText = "Precio Unitario"
        Me.PrecioU.MinimumWidth = 6
        Me.PrecioU.Name = "PrecioU"
        Me.PrecioU.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.FillWeight = 57.68283!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(82, 432)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(766, 72)
        Me.Panel6.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.LblDescuento)
        Me.Panel10.Location = New System.Drawing.Point(464, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(285, 30)
        Me.Panel10.TabIndex = 5
        '
        'LblDescuento
        '
        Me.LblDescuento.AutoSize = True
        Me.LblDescuento.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblDescuento.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescuento.ForeColor = System.Drawing.Color.Red
        Me.LblDescuento.Location = New System.Drawing.Point(114, 0)
        Me.LblDescuento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescuento.Name = "LblDescuento"
        Me.LblDescuento.Size = New System.Drawing.Size(171, 23)
        Me.LblDescuento.TabIndex = 3
        Me.LblDescuento.Text = "Descuento: $ 0.00"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Location = New System.Drawing.Point(464, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 30)
        Me.Panel1.TabIndex = 4
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblTotal.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LblTotal.Location = New System.Drawing.Point(76, 0)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(209, 28)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "Total: $ 0.00 MXN"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(82, 49)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(766, 122)
        Me.Panel5.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.TxtIdCliente)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.TxtCliente)
        Me.Panel9.Location = New System.Drawing.Point(151, 56)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(602, 58)
        Me.Panel9.TabIndex = 2
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtIdCliente.Location = New System.Drawing.Point(474, 19)
        Me.TxtIdCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(124, 27)
        Me.TxtIdCliente.TabIndex = 15
        Me.TxtIdCliente.Text = "-"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._160_user_71
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(348, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "      ID Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._160_user_71
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(2, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cliente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCliente.Location = New System.Drawing.Point(104, 19)
        Me.TxtCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(236, 27)
        Me.TxtCliente.TabIndex = 1
        Me.TxtCliente.Text = "-"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TxtId)
        Me.Panel8.Controls.Add(Me.DTPFecha)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Location = New System.Drawing.Point(151, 7)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(602, 46)
        Me.Panel8.TabIndex = 1
        '
        'TxtId
        '
        Me.TxtId.AutoSize = True
        Me.TxtId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtId.Location = New System.Drawing.Point(120, 14)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(18, 19)
        Me.TxtId.TabIndex = 5
        Me.TxtId.Text = "0"
        '
        'DTPFecha
        '
        Me.DTPFecha.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(445, 11)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(153, 27)
        Me.DTPFecha.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._124_calendar_21
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(348, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 41)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(2, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "# Cotización:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Location = New System.Drawing.Point(4, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(142, 112)
        Me.Panel7.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._188_photo_camera_1
        Me.PictureBox1.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Button17)
        Me.Panel4.Controls.Add(Me.Button14)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Panel4.Location = New System.Drawing.Point(0, 49)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(82, 455)
        Me.Panel4.TabIndex = 1
        '
        'Button17
        '
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Button17.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._160_user_71
        Me.Button17.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button17.Location = New System.Drawing.Point(-2, 65)
        Me.Button17.Margin = New System.Windows.Forms.Padding(2)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(82, 59)
        Me.Button17.TabIndex = 12
        Me.Button17.Text = "Cliente"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Button14.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._200_diskette
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button14.Location = New System.Drawing.Point(-2, 2)
        Me.Button14.Margin = New System.Windows.Forms.Padding(2)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(82, 59)
        Me.Button14.TabIndex = 9
        Me.Button14.Text = "Guardar"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(253, 259)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 51)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Buscar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BtnBuscar)
        Me.Panel3.Controls.Add(Me.BtnImporte)
        Me.Panel3.Controls.Add(Me.BtnDescuento)
        Me.Panel3.Controls.Add(Me.BtnRemover)
        Me.Panel3.Controls.Add(Me.BtnCantidad)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(848, 49)
        Me.Panel3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(666, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "COTIZACIÓN"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._071_loupe_1
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(0, 0)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(82, 51)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnImporte
        '
        Me.BtnImporte.FlatAppearance.BorderSize = 0
        Me.BtnImporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImporte.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImporte.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._259_calculator
        Me.BtnImporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImporte.Location = New System.Drawing.Point(394, -2)
        Me.BtnImporte.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnImporte.Name = "BtnImporte"
        Me.BtnImporte.Size = New System.Drawing.Size(104, 51)
        Me.BtnImporte.TabIndex = 5
        Me.BtnImporte.Text = "Importe"
        Me.BtnImporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImporte.UseVisualStyleBackColor = True
        '
        'BtnDescuento
        '
        Me.BtnDescuento.FlatAppearance.BorderSize = 0
        Me.BtnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDescuento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDescuento.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._266_percentage
        Me.BtnDescuento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDescuento.Location = New System.Drawing.Point(290, -2)
        Me.BtnDescuento.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDescuento.Name = "BtnDescuento"
        Me.BtnDescuento.Size = New System.Drawing.Size(104, 51)
        Me.BtnDescuento.TabIndex = 4
        Me.BtnDescuento.Text = "Descuento"
        Me.BtnDescuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDescuento.UseVisualStyleBackColor = True
        '
        'BtnRemover
        '
        Me.BtnRemover.FlatAppearance.BorderSize = 0
        Me.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemover.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemover.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._237_cancel1
        Me.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRemover.Location = New System.Drawing.Point(186, -2)
        Me.BtnRemover.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(104, 51)
        Me.BtnRemover.TabIndex = 3
        Me.BtnRemover.Text = "Remover"
        Me.BtnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRemover.UseVisualStyleBackColor = True
        '
        'BtnCantidad
        '
        Me.BtnCantidad.FlatAppearance.BorderSize = 0
        Me.BtnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCantidad.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._258_calculator_1
        Me.BtnCantidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCantidad.Location = New System.Drawing.Point(82, -2)
        Me.BtnCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCantidad.Name = "BtnCantidad"
        Me.BtnCantidad.Size = New System.Drawing.Size(104, 51)
        Me.BtnCantidad.TabIndex = 2
        Me.BtnCantidad.Text = "Cantidad"
        Me.BtnCantidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCantidad.UseVisualStyleBackColor = True
        '
        'FormCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 504)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCotizacion"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnImporte As Button
    Friend WithEvents BtnDescuento As Button
    Friend WithEvents BtnRemover As Button
    Friend WithEvents BtnCantidad As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblDescuento As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtId As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents PrecioU As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
