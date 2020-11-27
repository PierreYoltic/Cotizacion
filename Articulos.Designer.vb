<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Articulos
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewArticulos = New System.Windows.Forms.DataGridView()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowActiveItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amlysoftware_tallerDataSet = New Prototipo_Cotizacion.amlysoftware_tallerDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.PictureBoxImg = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ShowActiveItemsTableAdapter = New Prototipo_Cotizacion.amlysoftware_tallerDataSetTableAdapters.showActiveItemsTableAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowActiveItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amlysoftware_tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 65)
        Me.Panel1.TabIndex = 1
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._105_trash1
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(233, 0)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.BtnEliminar.Size = New System.Drawing.Size(118, 65)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._169_editar
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(115, 0)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.BtnEditar.Size = New System.Drawing.Size(118, 65)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._121_add
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(2, 0)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 65)
        Me.BtnAgregar.TabIndex = 7
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(676, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ARTÍCULOS"
        '
        'DataGridViewArticulos
        '
        Me.DataGridViewArticulos.AllowUserToAddRows = False
        Me.DataGridViewArticulos.AllowUserToDeleteRows = False
        Me.DataGridViewArticulos.AutoGenerateColumns = False
        Me.DataGridViewArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewArticulos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.DataGridViewArticulos.DataSource = Me.ShowActiveItemsBindingSource
        Me.DataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewArticulos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewArticulos.Name = "DataGridViewArticulos"
        Me.DataGridViewArticulos.ReadOnly = True
        Me.DataGridViewArticulos.RowHeadersWidth = 51
        Me.DataGridViewArticulos.RowTemplate.Height = 24
        Me.DataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewArticulos.Size = New System.Drawing.Size(609, 401)
        Me.DataGridViewArticulos.TabIndex = 2
        '
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        Me.CódigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShowActiveItemsBindingSource
        '
        Me.ShowActiveItemsBindingSource.DataMember = "showActiveItems"
        Me.ShowActiveItemsBindingSource.DataSource = Me.Amlysoftware_tallerDataSet
        '
        'Amlysoftware_tallerDataSet
        '
        Me.Amlysoftware_tallerDataSet.DataSetName = "amlysoftware_tallerDataSet"
        Me.Amlysoftware_tallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.LblPrecio)
        Me.Panel2.Controls.Add(Me.PictureBoxImg)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(609, 65)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 401)
        Me.Panel2.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LblDesc)
        Me.Panel4.Location = New System.Drawing.Point(22, 227)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 35)
        Me.Panel4.TabIndex = 3
        '
        'LblDesc
        '
        Me.LblDesc.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.LblDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LblDesc.Location = New System.Drawing.Point(2, 5)
        Me.LblDesc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(176, 30)
        Me.LblDesc.TabIndex = 1
        Me.LblDesc.Text = "DESCRIPCIÓN"
        Me.LblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.LblPrecio.ForeColor = System.Drawing.Color.Black
        Me.LblPrecio.Location = New System.Drawing.Point(71, 265)
        Me.LblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(72, 30)
        Me.LblPrecio.TabIndex = 2
        Me.LblPrecio.Text = "$0.00"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxImg
        '
        Me.PictureBoxImg.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBoxImg.Image = Global.Prototipo_Cotizacion.My.Resources.Resources._188_photo_camera_1
        Me.PictureBoxImg.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxImg.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxImg.Name = "PictureBoxImg"
        Me.PictureBoxImg.Size = New System.Drawing.Size(225, 178)
        Me.PictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImg.TabIndex = 0
        Me.PictureBoxImg.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridViewArticulos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 65)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 401)
        Me.Panel3.TabIndex = 4
        '
        'ShowActiveItemsTableAdapter
        '
        Me.ShowActiveItemsTableAdapter.ClearBeforeFill = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        showActiveItems.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            showActiveItems"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=PIER18;Initial Catalog=amlysoftware_taller;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "showActiveItems", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Descripción", "Descripción"), New System.Data.Common.DataColumnMapping("Precio", "Precio")})})
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 466)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Articulos"
        Me.Text = "Articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowActiveItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amlysoftware_tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewArticulos As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents PictureBoxImg As PictureBox
    Friend WithEvents Amlysoftware_tallerDataSet As amlysoftware_tallerDataSet
    Friend WithEvents ShowActiveItemsBindingSource As BindingSource
    Friend WithEvents ShowActiveItemsTableAdapter As amlysoftware_tallerDataSetTableAdapters.showActiveItemsTableAdapter
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As Panel
End Class
