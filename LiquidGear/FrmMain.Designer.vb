<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits LiquidGear.gdkForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtDialogs = New System.Windows.Forms.TextBox()
        Me.DialogList = New System.Windows.Forms.ListView()
        Me.CDiags = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBatchExport = New System.Windows.Forms.Button()
        Me.BtnBatchImport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.Location = New System.Drawing.Point(4, 4)
        Me.LblTitle.Size = New System.Drawing.Size(273, 19)
        Me.LblTitle.Text = "LiquidGear Decoded by Ati"
        '
        'TxtDialogs
        '
        Me.TxtDialogs.Location = New System.Drawing.Point(214, 182)
        Me.TxtDialogs.Multiline = True
        Me.TxtDialogs.Name = "TxtDialogs"
        Me.TxtDialogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDialogs.Size = New System.Drawing.Size(418, 164)
        Me.TxtDialogs.TabIndex = 11
        '
        'DialogList
        '
        Me.DialogList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CDiags})
        Me.DialogList.FullRowSelect = True
        Me.DialogList.Location = New System.Drawing.Point(8, 36)
        Me.DialogList.MultiSelect = False
        Me.DialogList.Name = "DialogList"
        Me.DialogList.Size = New System.Drawing.Size(200, 340)
        Me.DialogList.TabIndex = 12
        Me.DialogList.UseCompatibleStateImageBehavior = False
        Me.DialogList.View = System.Windows.Forms.View.Details
        '
        'CDiags
        '
        Me.CDiags.Text = "Dialogs"
        Me.CDiags.Width = 175
        '
        'BtnBatchExport
        '
        Me.BtnBatchExport.Enabled = False
        Me.BtnBatchExport.Location = New System.Drawing.Point(500, 352)
        Me.BtnBatchExport.Name = "BtnBatchExport"
        Me.BtnBatchExport.Size = New System.Drawing.Size(80, 24)
        Me.BtnBatchExport.TabIndex = 16
        Me.BtnBatchExport.Text = "&Batch Export"
        Me.BtnBatchExport.UseVisualStyleBackColor = True
        '
        'BtnBatchImport
        '
        Me.BtnBatchImport.Enabled = False
        Me.BtnBatchImport.Location = New System.Drawing.Point(400, 352)
        Me.BtnBatchImport.Name = "BtnBatchImport"
        Me.BtnBatchImport.Size = New System.Drawing.Size(80, 24)
        Me.BtnBatchImport.TabIndex = 16
        Me.BtnBatchImport.Text = "&Batch Import"
        Me.BtnBatchImport.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 384)
        Me.Controls.Add(Me.BtnBatchImport)
        Me.Controls.Add(Me.BtnBatchExport)
        Me.Controls.Add(Me.DialogList)
        Me.Controls.Add(Me.TxtDialogs)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.SetChildIndex(Me.TxtDialogs, 0)
        Me.Controls.SetChildIndex(Me.DialogList, 0)
        Me.Controls.SetChildIndex(Me.BtnBatchExport, 0)
        Me.Controls.SetChildIndex(Me.BtnBatchImport, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDialogs As System.Windows.Forms.TextBox
    Friend WithEvents DialogList As System.Windows.Forms.ListView
    Friend WithEvents CDiags As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnBatchExport As System.Windows.Forms.Button
    Friend WithEvents BtnBatchImport As System.Windows.Forms.Button

End Class
