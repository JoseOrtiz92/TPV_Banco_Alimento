<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraficoSalida
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
        Me.DsGraficoSalida = New TPV.dsGraficoSalida()
        Me.GraficosalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GraficosalidaTableAdapter = New TPV.dsGraficoSalidaTableAdapters.graficosalidaTableAdapter()
        Me.TableAdapterManager = New TPV.dsGraficoSalidaTableAdapters.TableAdapterManager()
        Me.CRViewerGraficoSalida = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsGraficoSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraficosalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsGraficoSalida
        '
        Me.DsGraficoSalida.DataSetName = "dsGraficoSalida"
        Me.DsGraficoSalida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GraficosalidaBindingSource
        '
        Me.GraficosalidaBindingSource.DataMember = "graficosalida"
        Me.GraficosalidaBindingSource.DataSource = Me.DsGraficoSalida
        '
        'GraficosalidaTableAdapter
        '
        Me.GraficosalidaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TPV.dsGraficoSalidaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRViewerGraficoSalida
        '
        Me.CRViewerGraficoSalida.ActiveViewIndex = -1
        Me.CRViewerGraficoSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewerGraficoSalida.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewerGraficoSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewerGraficoSalida.Location = New System.Drawing.Point(0, 0)
        Me.CRViewerGraficoSalida.Name = "CRViewerGraficoSalida"
        Me.CRViewerGraficoSalida.Size = New System.Drawing.Size(515, 367)
        Me.CRViewerGraficoSalida.TabIndex = 0
        '
        'GraficoSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 367)
        Me.Controls.Add(Me.CRViewerGraficoSalida)
        Me.Name = "GraficoSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GraficoSalida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsGraficoSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraficosalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsGraficoSalida As dsGraficoSalida
    Friend WithEvents GraficosalidaBindingSource As BindingSource
    Friend WithEvents GraficosalidaTableAdapter As dsGraficoSalidaTableAdapters.graficosalidaTableAdapter
    Friend WithEvents TableAdapterManager As dsGraficoSalidaTableAdapters.TableAdapterManager
    Friend WithEvents CRViewerGraficoSalida As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
