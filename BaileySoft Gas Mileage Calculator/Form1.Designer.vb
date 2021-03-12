<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMileageCalc
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
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.txtMPG = New System.Windows.Forms.TextBox()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(154, 51)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 23)
        Me.txtGallons.TabIndex = 0
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Location = New System.Drawing.Point(66, 54)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(74, 15)
        Me.lblGallons.TabIndex = 1
        Me.lblGallons.Text = "Gallons used"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(154, 99)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 23)
        Me.txtMiles.TabIndex = 2
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(69, 102)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(71, 15)
        Me.lblMiles.TabIndex = 3
        Me.lblMiles.Text = "Miles driven"
        '
        'txtMPG
        '
        Me.txtMPG.Location = New System.Drawing.Point(92, 147)
        Me.txtMPG.Name = "txtMPG"
        Me.txtMPG.ReadOnly = True
        Me.txtMPG.Size = New System.Drawing.Size(100, 23)
        Me.txtMPG.TabIndex = 4
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(207, 150)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(33, 15)
        Me.lblMPG.TabIndex = 5
        Me.lblMPG.Text = "MPG"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(110, 211)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 44)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'FrmMileageCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 308)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.txtMPG)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.txtGallons)
        Me.Name = "FrmMileageCalc"
        Me.Text = "BaileySoft Gas Mileage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGallons As TextBox
    Friend WithEvents lblGallons As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblMiles As Label
    Friend WithEvents txtMPG As TextBox
    Friend WithEvents lblMPG As Label
    Friend WithEvents btnCalculate As Button
End Class
