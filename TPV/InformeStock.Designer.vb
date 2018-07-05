<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeStock
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
        Me.DsInformeStock = New TPV.dsInformeStock()
        Me.Informe_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Informe_stockTableAdapter = New TPV.dsInformeStockTableAdapters.informe_stockTableAdapter()
        Me.TableAdapterManager = New TPV.dsInformeStockTableAdapters.TableAdapterManager()
        Me.CRViewerInformeStock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsInformeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Informe_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsInformeStock
        '
        Me.DsInformeStock.DataSetName = "dsInformeStock"
        Me.DsInformeStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Informe_stockBindingSource
        '
        Me.Informe_stockBindingSource.DataMember = "informe_stock"
        Me.Informe_stockBindingSource.DataSource = Me.DsInformeStock
        '
        'Informe_stockTableAdapter
        '
        Me.Informe_stockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TPV.dsInformeStockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRViewerInformeStock
        '
        Me.CRViewerInformeStock.ActiveViewIndex = -1
        Me.CRViewerInformeStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewerInformeStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewerInformeStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewerInformeStock.Location = New System.Drawing.Point(0, 0)
        Me.CRViewerInformeStock.Name = "CRViewerInformeStock"
        Me.CRViewerInformeStock.Size = New System.Drawing.Size(418, 352)
        Me.CRViewerInformeStock.TabIndex = 0
        '
        'InformeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 352)
        Me.Controls.Add(Me.CRViewerInformeStock)
        Me.Name = "InformeStock"
        Me.Text = "InformeStock"
        CType(Me.DsInformeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Informe_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsInformeStock As dsInformeStock
    Friend WithEvents Informe_stockBindingSource As BindingSource
    Friend WithEvents Informe_stockTableAdapter As dsInformeStockTableAdapters.informe_stockTableAdapter
    Friend WithEvents TableAdapterManager As dsInformeStockTableAdapters.TableAdapterManager
    Friend WithEvents CRViewerInformeStock As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
