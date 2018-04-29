<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectControl
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bYm = New System.Windows.Forms.Button()
        Me.bXm = New System.Windows.Forms.Button()
        Me.bXp = New System.Windows.Forms.Button()
        Me.bYp = New System.Windows.Forms.Button()
        Me.bZm = New System.Windows.Forms.Button()
        Me.bZp = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bDist1 = New System.Windows.Forms.Button()
        Me.bDist10 = New System.Windows.Forms.Button()
        Me.bDist100 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bYm
        '
        Me.bYm.Location = New System.Drawing.Point(31, 3)
        Me.bYm.Name = "bYm"
        Me.bYm.Size = New System.Drawing.Size(29, 25)
        Me.bYm.TabIndex = 0
        Me.bYm.Text = "Y-"
        Me.bYm.UseVisualStyleBackColor = True
        '
        'bXm
        '
        Me.bXm.Location = New System.Drawing.Point(3, 31)
        Me.bXm.Name = "bXm"
        Me.bXm.Size = New System.Drawing.Size(29, 25)
        Me.bXm.TabIndex = 1
        Me.bXm.Text = "X-"
        Me.bXm.UseVisualStyleBackColor = True
        '
        'bXp
        '
        Me.bXp.Location = New System.Drawing.Point(58, 31)
        Me.bXp.Name = "bXp"
        Me.bXp.Size = New System.Drawing.Size(29, 25)
        Me.bXp.TabIndex = 1
        Me.bXp.Text = "X+"
        Me.bXp.UseVisualStyleBackColor = True
        '
        'bYp
        '
        Me.bYp.Location = New System.Drawing.Point(31, 60)
        Me.bYp.Name = "bYp"
        Me.bYp.Size = New System.Drawing.Size(29, 25)
        Me.bYp.TabIndex = 1
        Me.bYp.Text = "Y+"
        Me.bYp.UseVisualStyleBackColor = True
        '
        'bZm
        '
        Me.bZm.Location = New System.Drawing.Point(99, 60)
        Me.bZm.Name = "bZm"
        Me.bZm.Size = New System.Drawing.Size(29, 25)
        Me.bZm.TabIndex = 1
        Me.bZm.Text = "Z-"
        Me.bZm.UseVisualStyleBackColor = True
        '
        'bZp
        '
        Me.bZp.Location = New System.Drawing.Point(99, 3)
        Me.bZp.Name = "bZp"
        Me.bZp.Size = New System.Drawing.Size(29, 25)
        Me.bZp.TabIndex = 1
        Me.bZp.Text = "Z+"
        Me.bZp.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "1"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bDist1
        '
        Me.bDist1.Location = New System.Drawing.Point(134, 29)
        Me.bDist1.Name = "bDist1"
        Me.bDist1.Size = New System.Drawing.Size(29, 25)
        Me.bDist1.TabIndex = 3
        Me.bDist1.Text = "1"
        Me.bDist1.UseVisualStyleBackColor = True
        '
        'bDist10
        '
        Me.bDist10.Location = New System.Drawing.Point(169, 29)
        Me.bDist10.Name = "bDist10"
        Me.bDist10.Size = New System.Drawing.Size(29, 25)
        Me.bDist10.TabIndex = 3
        Me.bDist10.Text = "10"
        Me.bDist10.UseVisualStyleBackColor = True
        '
        'bDist100
        '
        Me.bDist100.Location = New System.Drawing.Point(134, 60)
        Me.bDist100.Name = "bDist100"
        Me.bDist100.Size = New System.Drawing.Size(64, 25)
        Me.bDist100.TabIndex = 3
        Me.bDist100.Text = "100"
        Me.bDist100.UseVisualStyleBackColor = True
        '
        'DirectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bDist100)
        Me.Controls.Add(Me.bDist10)
        Me.Controls.Add(Me.bDist1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bZp)
        Me.Controls.Add(Me.bZm)
        Me.Controls.Add(Me.bYp)
        Me.Controls.Add(Me.bXp)
        Me.Controls.Add(Me.bXm)
        Me.Controls.Add(Me.bYm)
        Me.Name = "DirectControl"
        Me.Size = New System.Drawing.Size(432, 171)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bYm As Button
    Friend WithEvents bXm As Button
    Friend WithEvents bXp As Button
    Friend WithEvents bYp As Button
    Friend WithEvents bZm As Button
    Friend WithEvents bZp As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bDist1 As Button
    Friend WithEvents bDist10 As Button
    Friend WithEvents bDist100 As Button
End Class
