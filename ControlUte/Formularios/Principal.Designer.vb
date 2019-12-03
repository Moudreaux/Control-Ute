<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLecturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesde = New System.Windows.Forms.TextBox()
        Me.txthasta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDias = New System.Windows.Forms.TextBox()
        Me.TxtConsumidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdiario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpproxima = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtConsumoEstimado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDiasEstimados = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAPagar = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtresto = New System.Windows.Forms.TextBox()
        Me.txtmedio = New System.Windows.Forms.TextBox()
        Me.txtprimeros = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GrafPromedios = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GrafPromedios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AgregarLecturaToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(928, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AgregarLecturaToolStripMenuItem
        '
        Me.AgregarLecturaToolStripMenuItem.Name = "AgregarLecturaToolStripMenuItem"
        Me.AgregarLecturaToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.AgregarLecturaToolStripMenuItem.Text = "Lecturas"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Período:"
        '
        'txtdesde
        '
        Me.txtdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesde.ForeColor = System.Drawing.SystemColors.Window
        Me.txtdesde.Location = New System.Drawing.Point(83, 25)
        Me.txtdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.ReadOnly = True
        Me.txtdesde.Size = New System.Drawing.Size(108, 22)
        Me.txtdesde.TabIndex = 2
        Me.txtdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txthasta
        '
        Me.txthasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthasta.ForeColor = System.Drawing.SystemColors.Window
        Me.txthasta.Location = New System.Drawing.Point(203, 25)
        Me.txthasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.ReadOnly = True
        Me.txthasta.Size = New System.Drawing.Size(108, 22)
        Me.txthasta.TabIndex = 3
        Me.txthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Días:"
        '
        'TxtDias
        '
        Me.TxtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDias.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtDias.Location = New System.Drawing.Point(83, 59)
        Me.TxtDias.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.ReadOnly = True
        Me.TxtDias.Size = New System.Drawing.Size(65, 22)
        Me.TxtDias.TabIndex = 5
        Me.TxtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtConsumidos
        '
        Me.TxtConsumidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConsumidos.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtConsumidos.Location = New System.Drawing.Point(245, 59)
        Me.TxtConsumidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtConsumidos.Name = "TxtConsumidos"
        Me.TxtConsumidos.ReadOnly = True
        Me.TxtConsumidos.Size = New System.Drawing.Size(65, 22)
        Me.TxtConsumidos.TabIndex = 7
        Me.TxtConsumidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Consumidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Promedio Diario:"
        '
        'txtdiario
        '
        Me.txtdiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiario.ForeColor = System.Drawing.SystemColors.Window
        Me.txtdiario.Location = New System.Drawing.Point(126, 90)
        Me.txtdiario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiario.Name = "txtdiario"
        Me.txtdiario.ReadOnly = True
        Me.txtdiario.Size = New System.Drawing.Size(65, 22)
        Me.txtdiario.TabIndex = 10
        Me.txtdiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(193, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Max:7.7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdesde)
        Me.GroupBox1.Controls.Add(Me.txthasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdiario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtConsumidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtDias)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 143)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mes en curso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Próximo vencimiento:"
        '
        'dtpproxima
        '
        Me.dtpproxima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpproxima.Location = New System.Drawing.Point(136, 24)
        Me.dtpproxima.Name = "dtpproxima"
        Me.dtpproxima.Size = New System.Drawing.Size(108, 22)
        Me.dtpproxima.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Consumo estimado:"
        '
        'TxtConsumoEstimado
        '
        Me.TxtConsumoEstimado.Location = New System.Drawing.Point(136, 90)
        Me.TxtConsumoEstimado.Name = "TxtConsumoEstimado"
        Me.TxtConsumoEstimado.ReadOnly = True
        Me.TxtConsumoEstimado.Size = New System.Drawing.Size(60, 22)
        Me.TxtConsumoEstimado.TabIndex = 16
        Me.TxtConsumoEstimado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Días estimados:"
        '
        'TxtDiasEstimados
        '
        Me.TxtDiasEstimados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiasEstimados.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtDiasEstimados.Location = New System.Drawing.Point(136, 59)
        Me.TxtDiasEstimados.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiasEstimados.Name = "TxtDiasEstimados"
        Me.TxtDiasEstimados.ReadOnly = True
        Me.TxtDiasEstimados.Size = New System.Drawing.Size(60, 22)
        Me.TxtDiasEstimados.TabIndex = 18
        Me.TxtDiasEstimados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtDiasEstimados)
        Me.GroupBox2.Controls.Add(Me.TxtConsumoEstimado)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpproxima)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 143)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estimados"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(198, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Max: 230"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAPagar)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.txtresto)
        Me.GroupBox3.Controls.Add(Me.txtmedio)
        Me.GroupBox3.Controls.Add(Me.txtprimeros)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(629, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 143)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Próxima Factura"
        '
        'txtAPagar
        '
        Me.txtAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPagar.Location = New System.Drawing.Point(197, 63)
        Me.txtAPagar.Name = "txtAPagar"
        Me.txtAPagar.Size = New System.Drawing.Size(85, 25)
        Me.txtAPagar.TabIndex = 21
        Me.txtAPagar.Text = "0"
        Me.txtAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(197, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "A pagar:"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.SystemColors.Window
        Me.txttotal.Location = New System.Drawing.Point(114, 121)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(65, 22)
        Me.txttotal.TabIndex = 19
        Me.txttotal.Text = "0"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtresto
        '
        Me.txtresto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresto.ForeColor = System.Drawing.SystemColors.Window
        Me.txtresto.Location = New System.Drawing.Point(114, 90)
        Me.txtresto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtresto.Name = "txtresto"
        Me.txtresto.ReadOnly = True
        Me.txtresto.Size = New System.Drawing.Size(65, 22)
        Me.txtresto.TabIndex = 19
        Me.txtresto.Text = "0"
        Me.txtresto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtmedio
        '
        Me.txtmedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedio.ForeColor = System.Drawing.SystemColors.Window
        Me.txtmedio.Location = New System.Drawing.Point(114, 59)
        Me.txtmedio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedio.Name = "txtmedio"
        Me.txtmedio.ReadOnly = True
        Me.txtmedio.Size = New System.Drawing.Size(65, 22)
        Me.txtmedio.TabIndex = 19
        Me.txtmedio.Text = "0"
        Me.txtmedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtprimeros
        '
        Me.txtprimeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprimeros.ForeColor = System.Drawing.SystemColors.Window
        Me.txtprimeros.Location = New System.Drawing.Point(114, 24)
        Me.txtprimeros.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprimeros.Name = "txtprimeros"
        Me.txtprimeros.ReadOnly = True
        Me.txtprimeros.Size = New System.Drawing.Size(65, 22)
        Me.txtprimeros.TabIndex = 19
        Me.txtprimeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Resto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "100 - 140"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Primeros 100:"
        '
        'GrafPromedios
        '
        ChartArea1.AxisX.Title = "Fechas"
        ChartArea1.AxisY.Title = "Consumo"
        ChartArea1.Name = "ChartArea1"
        Me.GrafPromedios.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.GrafPromedios.Legends.Add(Legend1)
        Me.GrafPromedios.Location = New System.Drawing.Point(12, 186)
        Me.GrafPromedios.Name = "GrafPromedios"
        Me.GrafPromedios.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Blue
        Series1.MarkerSize = 7
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Me.GrafPromedios.Series.Add(Series1)
        Me.GrafPromedios.Size = New System.Drawing.Size(601, 283)
        Me.GrafPromedios.TabIndex = 21
        Me.GrafPromedios.Text = "Chart1"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 481)
        Me.Controls.Add(Me.GrafPromedios)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.Text = "Control de UTE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GrafPromedios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLecturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdesde As TextBox
    Friend WithEvents txthasta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDias As TextBox
    Friend WithEvents TxtConsumidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdiario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpproxima As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtConsumoEstimado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDiasEstimados As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtresto As TextBox
    Friend WithEvents txtmedio As TextBox
    Friend WithEvents txtprimeros As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAPagar As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GrafPromedios As DataVisualization.Charting.Chart
End Class
