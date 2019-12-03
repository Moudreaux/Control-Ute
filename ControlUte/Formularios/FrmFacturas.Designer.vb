<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblUltimo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtLectura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvLecturas = New System.Windows.Forms.DataGridView()
        Me.idfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvLecturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUltimo
        '
        Me.LblUltimo.AutoSize = True
        Me.LblUltimo.Location = New System.Drawing.Point(103, 481)
        Me.LblUltimo.Name = "LblUltimo"
        Me.LblUltimo.Size = New System.Drawing.Size(13, 13)
        Me.LblUltimo.TabIndex = 9
        Me.LblUltimo.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Último consumo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtLectura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 54)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar lectura"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(272, 16)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(67, 31)
        Me.BtnAgregar.TabIndex = 7
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtLectura
        '
        Me.TxtLectura.Location = New System.Drawing.Point(184, 21)
        Me.TxtLectura.Name = "TxtLectura"
        Me.TxtLectura.Size = New System.Drawing.Size(82, 20)
        Me.TxtLectura.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Consumo:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(47, 21)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(82, 20)
        Me.DtpFecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha:"
        '
        'DgvLecturas
        '
        Me.DgvLecturas.AllowUserToAddRows = False
        Me.DgvLecturas.AllowUserToDeleteRows = False
        Me.DgvLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLecturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idfactura, Me.Fecha, Me.Lectura, Me.Consumo, Me.Diario})
        Me.DgvLecturas.Location = New System.Drawing.Point(12, 62)
        Me.DgvLecturas.Name = "DgvLecturas"
        Me.DgvLecturas.ReadOnly = True
        Me.DgvLecturas.Size = New System.Drawing.Size(339, 412)
        Me.DgvLecturas.TabIndex = 6
        '
        'idfactura
        '
        Me.idfactura.DataPropertyName = "IdFactura"
        Me.idfactura.HeaderText = "Idfactura"
        Me.idfactura.Name = "idfactura"
        Me.idfactura.ReadOnly = True
        Me.idfactura.Visible = False
        Me.idfactura.Width = 60
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "FechaCorte"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.ToolTipText = "Fecha en que se tomó el consumo"
        Me.Fecha.Width = 90
        '
        'Lectura
        '
        Me.Lectura.DataPropertyName = "Lectura"
        Me.Lectura.HeaderText = "Lectura"
        Me.Lectura.Name = "Lectura"
        Me.Lectura.ReadOnly = True
        Me.Lectura.Width = 80
        '
        'Consumo
        '
        Me.Consumo.DataPropertyName = "Consumo"
        Me.Consumo.HeaderText = "Consumo"
        Me.Consumo.Name = "Consumo"
        Me.Consumo.ReadOnly = True
        Me.Consumo.ToolTipText = "Lectura del medidor"
        Me.Consumo.Width = 60
        '
        'Diario
        '
        Me.Diario.DataPropertyName = "Diario"
        Me.Diario.HeaderText = "Diario"
        Me.Diario.Name = "Diario"
        Me.Diario.ReadOnly = True
        Me.Diario.Width = 60
        '
        'FrmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 502)
        Me.Controls.Add(Me.LblUltimo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvLecturas)
        Me.Name = "FrmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvLecturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUltimo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtLectura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvLecturas As DataGridView
    Friend WithEvents idfactura As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Lectura As DataGridViewTextBoxColumn
    Friend WithEvents Consumo As DataGridViewTextBoxColumn
    Friend WithEvents Diario As DataGridViewTextBoxColumn
End Class
