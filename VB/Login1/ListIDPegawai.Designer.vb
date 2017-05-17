<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListIDPegawai
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
        Me.DataGridViewList = New System.Windows.Forms.DataGridView
        CType(Me.DataGridViewList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewList
        '
        Me.DataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewList.Location = New System.Drawing.Point(13, 13)
        Me.DataGridViewList.Name = "DataGridViewList"
        Me.DataGridViewList.Size = New System.Drawing.Size(297, 362)
        Me.DataGridViewList.TabIndex = 0
        '
        'ListIDPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 387)
        Me.Controls.Add(Me.DataGridViewList)
        Me.Name = "ListIDPegawai"
        Me.Text = "List ID Pegawai"
        CType(Me.DataGridViewList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewList As System.Windows.Forms.DataGridView
End Class
