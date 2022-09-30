<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearEntry = New System.Windows.Forms.Button()
        Me.btnLeftBracket = New System.Windows.Forms.Button()
        Me.btnRightBracket = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtResults
        '
        Me.txtResults.Enabled = False
        Me.txtResults.Font = New System.Drawing.Font("Roboto", 24.0!)
        Me.txtResults.Location = New System.Drawing.Point(13, 13)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.Size = New System.Drawing.Size(214, 46)
        Me.txtResults.TabIndex = 0
        Me.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(13, 71)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(49, 50)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClearEntry
        '
        Me.btnClearEntry.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEntry.Location = New System.Drawing.Point(68, 71)
        Me.btnClearEntry.Name = "btnClearEntry"
        Me.btnClearEntry.Size = New System.Drawing.Size(49, 50)
        Me.btnClearEntry.TabIndex = 2
        Me.btnClearEntry.Text = "CE"
        Me.btnClearEntry.UseVisualStyleBackColor = True
        '
        'btnLeftBracket
        '
        Me.btnLeftBracket.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeftBracket.Location = New System.Drawing.Point(123, 71)
        Me.btnLeftBracket.Name = "btnLeftBracket"
        Me.btnLeftBracket.Size = New System.Drawing.Size(49, 50)
        Me.btnLeftBracket.TabIndex = 3
        Me.btnLeftBracket.Text = "("
        Me.btnLeftBracket.UseVisualStyleBackColor = True
        '
        'btnRightBracket
        '
        Me.btnRightBracket.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRightBracket.Location = New System.Drawing.Point(178, 71)
        Me.btnRightBracket.Name = "btnRightBracket"
        Me.btnRightBracket.Size = New System.Drawing.Size(49, 50)
        Me.btnRightBracket.TabIndex = 4
        Me.btnRightBracket.Text = ")"
        Me.btnRightBracket.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(178, 127)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(49, 50)
        Me.btnDivision.TabIndex = 8
        Me.btnDivision.Text = "÷"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(123, 127)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(49, 50)
        Me.btn9.TabIndex = 7
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(68, 127)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(49, 50)
        Me.btn8.TabIndex = 6
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(13, 127)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(49, 50)
        Me.btn7.TabIndex = 5
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.Location = New System.Drawing.Point(178, 183)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(49, 50)
        Me.btnMultiplication.TabIndex = 12
        Me.btnMultiplication.Text = "x"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(123, 183)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(49, 50)
        Me.btn6.TabIndex = 11
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(68, 183)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(49, 50)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(13, 183)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(49, 50)
        Me.btn4.TabIndex = 9
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.Location = New System.Drawing.Point(178, 239)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(49, 50)
        Me.btnSubtraction.TabIndex = 16
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(123, 239)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(49, 50)
        Me.btn3.TabIndex = 15
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(68, 239)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(49, 50)
        Me.btn2.TabIndex = 14
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(13, 239)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(49, 50)
        Me.btn1.TabIndex = 13
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.Location = New System.Drawing.Point(178, 295)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(49, 50)
        Me.btnAddition.TabIndex = 20
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(123, 295)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(49, 50)
        Me.btnEquals.TabIndex = 19
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoint.Location = New System.Drawing.Point(68, 295)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(49, 50)
        Me.btnPoint.TabIndex = 18
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(13, 295)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(49, 50)
        Me.btn0.TabIndex = 17
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 355)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnRightBracket)
        Me.Controls.Add(Me.btnLeftBracket)
        Me.Controls.Add(Me.btnClearEntry)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtResults)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClearEntry As Button
    Friend WithEvents btnLeftBracket As Button
    Friend WithEvents btnRightBracket As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents btn0 As Button
End Class
