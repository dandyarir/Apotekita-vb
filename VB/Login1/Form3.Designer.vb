<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_refIdObat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dg_ref = New System.Windows.Forms.DataGridView
        CType(Me.dg_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_ref
        '
        Me.dg_ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ref.Location = New System.Drawing.Point(12, 12)
        Me.dg_ref.Name = "dg_ref"
        Me.dg_ref.Size = New System.Drawing.Size(277, 323)
        Me.dg_ref.TabIndex = 0
        '
        'form_refIdObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 347)
        Me.Controls.Add(Me.dg_ref)
        Me.Name = "form_refIdObat"
        Me.Text = "Referensi ID Obat"
        CType(Me.dg_ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_ref As System.Windows.Forms.DataGridView
End Class
