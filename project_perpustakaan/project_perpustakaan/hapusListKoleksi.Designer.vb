<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hapusListKoleksi
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
        Me.LblSelectedName = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblTanya = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblSelectedName
        '
        Me.LblSelectedName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSelectedName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSelectedName.ForeColor = System.Drawing.Color.Red
        Me.LblSelectedName.Location = New System.Drawing.Point(0, 135)
        Me.LblSelectedName.Name = "LblSelectedName"
        Me.LblSelectedName.Size = New System.Drawing.Size(470, 28)
        Me.LblSelectedName.TabIndex = 6
        Me.LblSelectedName.Text = "(nama koleksi)"
        Me.LblSelectedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(191, 221)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblTanya
        '
        Me.LblTanya.AutoSize = True
        Me.LblTanya.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTanya.Location = New System.Drawing.Point(133, 59)
        Me.LblTanya.Name = "LblTanya"
        Me.LblTanya.Size = New System.Drawing.Size(220, 19)
        Me.LblTanya.TabIndex = 4
        Me.LblTanya.Text = "Apakah ingin menghapus koleksi ?"
        '
        'hapusListKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 302)
        Me.Controls.Add(Me.LblSelectedName)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblTanya)
        Me.Name = "hapusListKoleksi"
        Me.Text = "hapusListKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSelectedName As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblTanya As Label
End Class
