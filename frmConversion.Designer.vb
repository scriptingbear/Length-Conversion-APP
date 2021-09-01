<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversion
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtYards = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblKilometers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMeters = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCentimeters = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Miles"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(87, 12)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(125, 34)
        Me.txtMiles.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtMiles, "Enter a positive whole number, or 0, or leave blank")
        '
        'txtYards
        '
        Me.txtYards.Location = New System.Drawing.Point(87, 52)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(125, 34)
        Me.txtYards.TabIndex = 2
        Me.txtYards.Tag = "1760"
        Me.ToolTip1.SetToolTip(Me.txtYards, "Enter a positive whole number, or 0, or leave blank")
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(87, 92)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(125, 34)
        Me.txtFeet.TabIndex = 3
        Me.txtFeet.Tag = "3"
        Me.ToolTip1.SetToolTip(Me.txtFeet, "Enter a positive whole number, or 0, or leave blank")
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(87, 132)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(125, 34)
        Me.txtInches.TabIndex = 4
        Me.txtInches.Tag = "12"
        Me.ToolTip1.SetToolTip(Me.txtInches, "Enter a positive whole number, or 0, or leave blank")
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(430, 19)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(121, 64)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.ToolTip1.SetToolTip(Me.btnConvert, "Convert total of Imperial measurements to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kilometers, meters and centimeters")
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblKilometers
        '
        Me.lblKilometers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKilometers.Location = New System.Drawing.Point(238, 18)
        Me.lblKilometers.Name = "lblKilometers"
        Me.lblKilometers.Size = New System.Drawing.Size(136, 25)
        Me.lblKilometers.TabIndex = 2
        Me.lblKilometers.Tag = "km"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Yards"
        '
        'lblMeters
        '
        Me.lblMeters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMeters.Location = New System.Drawing.Point(238, 58)
        Me.lblMeters.Name = "lblMeters"
        Me.lblMeters.Size = New System.Drawing.Size(136, 25)
        Me.lblMeters.TabIndex = 2
        Me.lblMeters.Tag = "m"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Feet"
        '
        'lblCentimeters
        '
        Me.lblCentimeters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCentimeters.Location = New System.Drawing.Point(238, 98)
        Me.lblCentimeters.Name = "lblCentimeters"
        Me.lblCentimeters.Size = New System.Drawing.Size(136, 25)
        Me.lblCentimeters.TabIndex = 2
        Me.lblCentimeters.Tag = "cm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Inches"
        '
        'txtClear
        '
        Me.txtClear.Location = New System.Drawing.Point(430, 92)
        Me.txtClear.Name = "txtClear"
        Me.txtClear.Size = New System.Drawing.Size(121, 64)
        Me.txtClear.TabIndex = 6
        Me.txtClear.Text = "Clear"
        Me.txtClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(380, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "km"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(380, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "m"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(380, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "cm"
        '
        'frmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 200)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblCentimeters)
        Me.Controls.Add(Me.lblMeters)
        Me.Controls.Add(Me.lblKilometers)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Length Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblKilometers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYards As TextBox
    Friend WithEvents lblMeters As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents lblCentimeters As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInches As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
