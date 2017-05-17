<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogspn
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ya_btn = New System.Windows.Forms.Button
        Me.tidak_btn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ya_btn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tidak_btn, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(78, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ya_btn
        '
        Me.ya_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ya_btn.Location = New System.Drawing.Point(20, 3)
        Me.ya_btn.Name = "ya_btn"
        Me.ya_btn.Size = New System.Drawing.Size(67, 23)
        Me.ya_btn.TabIndex = 0
        Me.ya_btn.Text = "Ya"
        '
        'tidak_btn
        '
        Me.tidak_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tidak_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tidak_btn.Location = New System.Drawing.Point(127, 3)
        Me.tidak_btn.Name = "tidak_btn"
        Me.tidak_btn.Size = New System.Drawing.Size(67, 23)
        Me.tidak_btn.TabIndex = 1
        Me.tidak_btn.Text = "Tidak"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apakah anda yakin?"
        '
        'dialogspn
        '
        Me.AcceptButton = Me.ya_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.tidak_btn
        Me.ClientSize = New System.Drawing.Size(395, 83)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialogspn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Simpan"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ya_btn As System.Windows.Forms.Button
    Friend WithEvents tidak_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
