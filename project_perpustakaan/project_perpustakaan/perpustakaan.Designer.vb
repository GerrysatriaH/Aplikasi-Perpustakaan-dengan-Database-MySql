<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menuKoleksi = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBKoleksiBuku = New System.Windows.Forms.ListBox()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.menuKoleksi.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuKoleksi
        '
        Me.menuKoleksi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem, Me.ArrayToolStripMenuItem})
        Me.menuKoleksi.Location = New System.Drawing.Point(0, 0)
        Me.menuKoleksi.Name = "menuKoleksi"
        Me.menuKoleksi.Size = New System.Drawing.Size(969, 24)
        Me.menuKoleksi.TabIndex = 0
        Me.menuKoleksi.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.KoleksiToolStripMenuItem.Text = "Menu Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ArrayToolStripMenuItem.Text = "Latihan Array"
        '
        'LBKoleksiBuku
        '
        Me.LBKoleksiBuku.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBKoleksiBuku.FormattingEnabled = True
        Me.LBKoleksiBuku.ItemHeight = 17
        Me.LBKoleksiBuku.Location = New System.Drawing.Point(12, 62)
        Me.LBKoleksiBuku.Name = "LBKoleksiBuku"
        Me.LBKoleksiBuku.Size = New System.Drawing.Size(448, 412)
        Me.LBKoleksiBuku.TabIndex = 1
        '
        'BtnPlus
        '
        Me.BtnPlus.BackgroundImage = Global.project_perpustakaan.My.Resources.Resources.btnPlus
        Me.BtnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPlus.FlatAppearance.BorderSize = 0
        Me.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlus.Location = New System.Drawing.Point(12, 27)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(29, 25)
        Me.BtnPlus.TabIndex = 2
        Me.BtnPlus.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.BackgroundImage = Global.project_perpustakaan.My.Resources.Resources.btnMinus
        Me.BtnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinus.FlatAppearance.BorderSize = 0
        Me.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinus.Location = New System.Drawing.Point(42, 27)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(29, 25)
        Me.BtnMinus.TabIndex = 4
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(476, 62)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowTemplate.Height = 25
        Me.DataGridKoleksi.Size = New System.Drawing.Size(478, 412)
        Me.DataGridKoleksi.TabIndex = 5
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(720, 486)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(801, 486)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 7
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(882, 486)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 8
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 522)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.BtnMinus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.LBKoleksiBuku)
        Me.Controls.Add(Me.menuKoleksi)
        Me.MainMenuStrip = Me.menuKoleksi
        Me.Name = "perpustakaan"
        Me.Text = "Perpustakaan"
        Me.menuKoleksi.ResumeLayout(False)
        Me.menuKoleksi.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuKoleksi As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBKoleksiBuku As ListBox
    Friend WithEvents BtnPlus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnRemove As Button
End Class
