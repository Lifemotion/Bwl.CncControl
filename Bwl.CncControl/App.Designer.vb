<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits Bwl.Framework.FormAppBase

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DirectControl1 = New Bwl.CncControl.DirectControl()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(2, 509)
        Me.logWriter.Size = New System.Drawing.Size(781, 149)
        '
        'DirectControl1
        '
        Me.DirectControl1.Location = New System.Drawing.Point(12, 27)
        Me.DirectControl1.Machine = Nothing
        Me.DirectControl1.Name = "DirectControl1"
        Me.DirectControl1.Size = New System.Drawing.Size(423, 168)
        Me.DirectControl1.TabIndex = 2
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 659)
        Me.Controls.Add(Me.DirectControl1)
        Me.Name = "App"
        Me.Text = "Bwl.CncControl"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.DirectControl1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DirectControl1 As DirectControl
End Class
