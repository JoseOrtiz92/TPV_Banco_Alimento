<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventanaInformes
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
        Me.btnInformeStock = New System.Windows.Forms.Button()
        Me.btnInfEntradaFecha = New System.Windows.Forms.Button()
        Me.dtpFechaInicio = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.dtpFechaFin = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnGraficoEntrada = New System.Windows.Forms.Button()
        Me.btnGraficoSalida = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInformeStock
        '
        Me.btnInformeStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnInformeStock.FlatAppearance.BorderSize = 0
        Me.btnInformeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformeStock.Font = New System.Drawing.Font("Raleway SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeStock.ForeColor = System.Drawing.Color.White
        Me.btnInformeStock.Location = New System.Drawing.Point(261, 122)
        Me.btnInformeStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInformeStock.Name = "btnInformeStock"
        Me.btnInformeStock.Size = New System.Drawing.Size(236, 92)
        Me.btnInformeStock.TabIndex = 13
        Me.btnInformeStock.Text = "Informe Stock actual"
        Me.btnInformeStock.UseVisualStyleBackColor = False
        '
        'btnInfEntradaFecha
        '
        Me.btnInfEntradaFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnInfEntradaFecha.FlatAppearance.BorderSize = 0
        Me.btnInfEntradaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfEntradaFecha.Font = New System.Drawing.Font("Raleway SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfEntradaFecha.ForeColor = System.Drawing.Color.White
        Me.btnInfEntradaFecha.Location = New System.Drawing.Point(21, 298)
        Me.btnInfEntradaFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInfEntradaFecha.Name = "btnInfEntradaFecha"
        Me.btnInfEntradaFecha.Size = New System.Drawing.Size(236, 82)
        Me.btnInfEntradaFecha.TabIndex = 14
        Me.btnInfEntradaFecha.Text = "Informe por fecha"
        Me.btnInfEntradaFecha.UseVisualStyleBackColor = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpFechaInicio.BorderRadius = 0
        Me.dtpFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFechaInicio.FormatCustom = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(331, 298)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(405, 30)
        Me.dtpFechaInicio.TabIndex = 17
        Me.dtpFechaInicio.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpFechaFin.BorderRadius = 0
        Me.dtpFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFechaFin.FormatCustom = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(331, 350)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(405, 30)
        Me.dtpFechaFin.TabIndex = 18
        Me.dtpFechaFin.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(115, 458)
        Me.Line1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(528, 10)
        Me.Line1.TabIndex = 19
        Me.Line1.Text = "Line1"
        '
        'btnGraficoEntrada
        '
        Me.btnGraficoEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnGraficoEntrada.FlatAppearance.BorderSize = 0
        Me.btnGraficoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoEntrada.Font = New System.Drawing.Font("Raleway SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoEntrada.ForeColor = System.Drawing.Color.White
        Me.btnGraficoEntrada.Location = New System.Drawing.Point(69, 543)
        Me.btnGraficoEntrada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGraficoEntrada.Name = "btnGraficoEntrada"
        Me.btnGraficoEntrada.Size = New System.Drawing.Size(236, 92)
        Me.btnGraficoEntrada.TabIndex = 20
        Me.btnGraficoEntrada.Text = "Grafico Entrada de Producto"
        Me.btnGraficoEntrada.UseVisualStyleBackColor = False
        '
        'btnGraficoSalida
        '
        Me.btnGraficoSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnGraficoSalida.FlatAppearance.BorderSize = 0
        Me.btnGraficoSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoSalida.Font = New System.Drawing.Font("Raleway SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficoSalida.ForeColor = System.Drawing.Color.White
        Me.btnGraficoSalida.Location = New System.Drawing.Point(453, 543)
        Me.btnGraficoSalida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGraficoSalida.Name = "btnGraficoSalida"
        Me.btnGraficoSalida.Size = New System.Drawing.Size(236, 92)
        Me.btnGraficoSalida.TabIndex = 21
        Me.btnGraficoSalida.Text = "Grafico Salida de Producto"
        Me.btnGraficoSalida.UseVisualStyleBackColor = False
        '
        'ventanaInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(757, 694)
        Me.Controls.Add(Me.btnGraficoSalida)
        Me.Controls.Add(Me.btnGraficoEntrada)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.btnInfEntradaFecha)
        Me.Controls.Add(Me.btnInformeStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ventanaInformes"
        Me.Text = "ventanaInformes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInformeStock As Button
    Friend WithEvents btnInfEntradaFecha As Button
    Friend WithEvents dtpFechaInicio As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents dtpFechaFin As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents btnGraficoEntrada As Button
    Friend WithEvents btnGraficoSalida As Button
End Class
