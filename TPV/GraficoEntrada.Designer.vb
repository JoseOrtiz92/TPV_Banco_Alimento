<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraficoEntrada
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
        Me.components = New System.ComponentModel.Container()
        Me.DsGraficoEntrada = New TPV.dsGraficoEntrada()
        Me.GraficoentradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GraficoentradaTableAdapter = New TPV.dsGraficoEntradaTableAdapters.graficoentradaTableAdapter()
        Me.TableAdapterManager = New TPV.dsGraficoEntradaTableAdapters.TableAdapterManager()
        Me.CRViewerGraficoEntrada = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsGraficoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraficoentradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsGraficoEntrada
        '
        Me.DsGraficoEntrada.DataSetName = "dsGraficoEntrada"
        Me.DsGraficoEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GraficoentradaBindingSource
        '
        Me.GraficoentradaBindingSource.DataMember = "graficoentrada"
        Me.GraficoentradaBindingSource.DataSource = Me.DsGraficoEntrada
        '
        'GraficoentradaTableAdapter
        '
        Me.GraficoentradaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TPV.dsGraficoEntradaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRViewerGraficoEntrada
        '
        Me.CRViewerGraficoEntrada.ActiveViewIndex = -1
        Me.CRViewerGraficoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewerGraficoEntrada.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewerGraficoEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewerGraficoEntrada.Location = New System.Drawing.Point(0, 0)
        Me.CRViewerGraficoEntrada.Name = "CRViewerGraficoEntrada"
        Me.CRViewerGraficoEntrada.Size = New System.Drawing.Size(520, 350)
        Me.CRViewerGraficoEntrada.TabIndex = 0
        '
        'GraficoEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 350)
        Me.Controls.Add(Me.CRViewerGraficoEntrada)
        Me.Name = "GraficoEntrada"
        Me.Text = "GraficoEntrada"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsGraficoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraficoentradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsGraficoEntrada As dsGraficoEntrada
    Friend WithEvents GraficoentradaBindingSource As BindingSource
    Friend WithEvents GraficoentradaTableAdapter As dsGraficoEntradaTableAdapters.graficoentradaTableAdapter
    Friend WithEvents TableAdapterManager As dsGraficoEntradaTableAdapters.TableAdapterManager
    Friend WithEvents CRViewerGraficoEntrada As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
