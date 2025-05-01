<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ImageRadioButton1 = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.Guna2ImageRadioButton2 = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.Guna2ImageRadioButton3 = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.Guna2ImageRadioButton4 = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.Guna2ImageRadioButton5 = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2GradientPanel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ImageRadioButton5)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ImageRadioButton4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ImageRadioButton3)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ImageRadioButton2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ImageRadioButton1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(315, 198)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"exe -> bat", "exe -> bat (with non-printable chars)", "exe -> vbs", "exe -> js", "exe -> ps1"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(53, 34)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(193, 36)
        Me.Guna2ComboBox1.TabIndex = 0
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(37, 62)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(209, 45)
        Me.Guna2GradientButton1.TabIndex = 1
        Me.Guna2GradientButton1.Text = "Guna2GradientButton1"
        '
        'Guna2ImageRadioButton1
        '
        Me.Guna2ImageRadioButton1.CheckedState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.Guna2ImageRadioButton1.Image = CType(resources.GetObject("Guna2ImageRadioButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageRadioButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageRadioButton1.ImageRotate = 0!
        Me.Guna2ImageRadioButton1.Location = New System.Drawing.Point(12, 97)
        Me.Guna2ImageRadioButton1.Name = "Guna2ImageRadioButton1"
        Me.Guna2ImageRadioButton1.Size = New System.Drawing.Size(24, 24)
        Me.Guna2ImageRadioButton1.TabIndex = 2
        '
        'Guna2ImageRadioButton2
        '
        Me.Guna2ImageRadioButton2.CheckedState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.Guna2ImageRadioButton2.Image = CType(resources.GetObject("Guna2ImageRadioButton2.Image"), System.Drawing.Image)
        Me.Guna2ImageRadioButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageRadioButton2.ImageRotate = 0!
        Me.Guna2ImageRadioButton2.Location = New System.Drawing.Point(53, 97)
        Me.Guna2ImageRadioButton2.Name = "Guna2ImageRadioButton2"
        Me.Guna2ImageRadioButton2.Size = New System.Drawing.Size(24, 24)
        Me.Guna2ImageRadioButton2.TabIndex = 3
        '
        'Guna2ImageRadioButton3
        '
        Me.Guna2ImageRadioButton3.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2ImageRadioButton3.Image = CType(resources.GetObject("Guna2ImageRadioButton3.Image"), System.Drawing.Image)
        Me.Guna2ImageRadioButton3.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageRadioButton3.ImageRotate = 0!
        Me.Guna2ImageRadioButton3.Location = New System.Drawing.Point(83, 97)
        Me.Guna2ImageRadioButton3.Name = "Guna2ImageRadioButton3"
        Me.Guna2ImageRadioButton3.Size = New System.Drawing.Size(24, 24)
        Me.Guna2ImageRadioButton3.TabIndex = 4
        '
        'Guna2ImageRadioButton4
        '
        Me.Guna2ImageRadioButton4.CheckedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2ImageRadioButton4.Image = CType(resources.GetObject("Guna2ImageRadioButton4.Image"), System.Drawing.Image)
        Me.Guna2ImageRadioButton4.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageRadioButton4.ImageRotate = 0!
        Me.Guna2ImageRadioButton4.Location = New System.Drawing.Point(124, 97)
        Me.Guna2ImageRadioButton4.Name = "Guna2ImageRadioButton4"
        Me.Guna2ImageRadioButton4.Size = New System.Drawing.Size(24, 24)
        Me.Guna2ImageRadioButton4.TabIndex = 5
        '
        'Guna2ImageRadioButton5
        '
        Me.Guna2ImageRadioButton5.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2ImageRadioButton5.Image = CType(resources.GetObject("Guna2ImageRadioButton5.Image"), System.Drawing.Image)
        Me.Guna2ImageRadioButton5.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageRadioButton5.ImageRotate = 0!
        Me.Guna2ImageRadioButton5.Location = New System.Drawing.Point(173, 97)
        Me.Guna2ImageRadioButton5.Name = "Guna2ImageRadioButton5"
        Me.Guna2ImageRadioButton5.Size = New System.Drawing.Size(24, 24)
        Me.Guna2ImageRadioButton5.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 198)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ImageRadioButton5 As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents Guna2ImageRadioButton4 As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents Guna2ImageRadioButton3 As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents Guna2ImageRadioButton2 As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents Guna2ImageRadioButton1 As Guna.UI2.WinForms.Guna2ImageRadioButton
End Class
