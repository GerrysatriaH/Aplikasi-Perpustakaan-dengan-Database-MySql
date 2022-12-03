<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class array
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
        Me.LblDemoArray = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxArray = New System.Windows.Forms.ListBox()
        Me.ListBoxArrayDynamic = New System.Windows.Forms.ListBox()
        Me.ListBoxArrayMulti = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListArrayList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxStack = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxQueue = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListHashTable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblDemoArray
        '
        Me.LblDemoArray.AutoSize = True
        Me.LblDemoArray.Location = New System.Drawing.Point(12, 16)
        Me.LblDemoArray.Name = "LblDemoArray"
        Me.LblDemoArray.Size = New System.Drawing.Size(70, 15)
        Me.LblDemoArray.TabIndex = 0
        Me.LblDemoArray.Text = "Demo Array"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Demo Array Dynamic"
        '
        'ListBoxArray
        '
        Me.ListBoxArray.FormattingEnabled = True
        Me.ListBoxArray.ItemHeight = 15
        Me.ListBoxArray.Location = New System.Drawing.Point(12, 43)
        Me.ListBoxArray.Name = "ListBoxArray"
        Me.ListBoxArray.Size = New System.Drawing.Size(147, 169)
        Me.ListBoxArray.TabIndex = 2
        '
        'ListBoxArrayDynamic
        '
        Me.ListBoxArrayDynamic.FormattingEnabled = True
        Me.ListBoxArrayDynamic.ItemHeight = 15
        Me.ListBoxArrayDynamic.Location = New System.Drawing.Point(185, 43)
        Me.ListBoxArrayDynamic.Name = "ListBoxArrayDynamic"
        Me.ListBoxArrayDynamic.Size = New System.Drawing.Size(147, 169)
        Me.ListBoxArrayDynamic.TabIndex = 3
        '
        'ListBoxArrayMulti
        '
        Me.ListBoxArrayMulti.FormattingEnabled = True
        Me.ListBoxArrayMulti.ItemHeight = 15
        Me.ListBoxArrayMulti.Location = New System.Drawing.Point(361, 43)
        Me.ListBoxArrayMulti.Name = "ListBoxArrayMulti"
        Me.ListBoxArrayMulti.Size = New System.Drawing.Size(147, 169)
        Me.ListBoxArrayMulti.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Demo Array Multidimensi"
        '
        'ListArrayList
        '
        Me.ListArrayList.FormattingEnabled = True
        Me.ListArrayList.ItemHeight = 15
        Me.ListArrayList.Location = New System.Drawing.Point(530, 43)
        Me.ListArrayList.Name = "ListArrayList"
        Me.ListArrayList.Size = New System.Drawing.Size(147, 169)
        Me.ListArrayList.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(530, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Demo Array List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Demo Stack"
        '
        'ListBoxStack
        '
        Me.ListBoxStack.FormattingEnabled = True
        Me.ListBoxStack.ItemHeight = 15
        Me.ListBoxStack.Location = New System.Drawing.Point(107, 267)
        Me.ListBoxStack.Name = "ListBoxStack"
        Me.ListBoxStack.Size = New System.Drawing.Size(147, 169)
        Me.ListBoxStack.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Demo Queue"
        '
        'ListBoxQueue
        '
        Me.ListBoxQueue.FormattingEnabled = True
        Me.ListBoxQueue.ItemHeight = 15
        Me.ListBoxQueue.Location = New System.Drawing.Point(280, 267)
        Me.ListBoxQueue.Name = "ListBoxQueue"
        Me.ListBoxQueue.Size = New System.Drawing.Size(147, 169)
        Me.ListBoxQueue.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(456, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Demo HashTable"
        '
        'ListHashTable
        '
        Me.ListHashTable.FormattingEnabled = True
        Me.ListHashTable.ItemHeight = 15
        Me.ListHashTable.Location = New System.Drawing.Point(456, 267)
        Me.ListHashTable.Name = "ListHashTable"
        Me.ListHashTable.Size = New System.Drawing.Size(147, 169)
        Me.ListHashTable.TabIndex = 12
        '
        'array
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 476)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListHashTable)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBoxQueue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBoxStack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListArrayList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxArrayMulti)
        Me.Controls.Add(Me.ListBoxArrayDynamic)
        Me.Controls.Add(Me.ListBoxArray)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDemoArray)
        Me.Name = "array"
        Me.Text = "array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDemoArray As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxArray As ListBox
    Friend WithEvents ListBoxArrayDynamic As ListBox
    Friend WithEvents ListBoxArrayMulti As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListArrayList As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxStack As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxQueue As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListHashTable As ListBox
End Class
