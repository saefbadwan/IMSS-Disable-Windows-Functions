<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_ConfigureOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_ConfigureOptions))
        Me._IMSS_BackGroundPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Recommended_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_StopClearingPageFile_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OK_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Cancel_Button = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_SpeedUpToStageOne_RadioButton = New System.Windows.Forms.RadioButton()
        Me._IMSS_SpeedUpToStageTwo_RadioButton = New System.Windows.Forms.RadioButton()
        Me._IMSS_RestoreDefault_Button = New DevComponents.DotNetBar.ButtonX()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._IMSS_BackGroundPanel.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_BackGroundPanel
        '
        Me._IMSS_BackGroundPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_BackGroundPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_BackGroundPanel.Controls.Add(Me._IMSS_SpeedUpToStageTwo_RadioButton)
        Me._IMSS_BackGroundPanel.Controls.Add(Me._IMSS_SpeedUpToStageOne_RadioButton)
        Me._IMSS_BackGroundPanel.Controls.Add(Me.PanelEx2)
        Me._IMSS_BackGroundPanel.Controls.Add(Me.PictureBox1)
        Me._IMSS_BackGroundPanel.Controls.Add(Me.LabelX1)
        Me._IMSS_BackGroundPanel.Controls.Add(Me.PanelEx1)
        Me._IMSS_BackGroundPanel.Controls.Add(Me._IMSS_StopClearingPageFile_CheckBox)
        Me._IMSS_BackGroundPanel.Controls.Add(Me._IMSS_Recommended_Label)
        Me._IMSS_BackGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_BackGroundPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_BackGroundPanel.Name = "_IMSS_BackGroundPanel"
        Me._IMSS_BackGroundPanel.Size = New System.Drawing.Size(361, 215)
        Me._IMSS_BackGroundPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_BackGroundPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._IMSS_BackGroundPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_BackGroundPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_BackGroundPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_BackGroundPanel.Style.BorderWidth = 0
        Me._IMSS_BackGroundPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_BackGroundPanel.Style.GradientAngle = 90
        Me._IMSS_BackGroundPanel.TabIndex = 0
        '
        '_IMSS_Recommended_Label
        '
        Me._IMSS_Recommended_Label.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Recommended_Label.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Recommended_Label.ForeColor = System.Drawing.Color.Green
        Me._IMSS_Recommended_Label.Location = New System.Drawing.Point(265, 98)
        Me._IMSS_Recommended_Label.Name = "_IMSS_Recommended_Label"
        Me._IMSS_Recommended_Label.Size = New System.Drawing.Size(83, 16)
        Me._IMSS_Recommended_Label.TabIndex = 3
        Me._IMSS_Recommended_Label.Text = "(Recommended)"
        '
        '_IMSS_StopClearingPageFile_CheckBox
        '
        '
        '
        '
        Me._IMSS_StopClearingPageFile_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_StopClearingPageFile_CheckBox.Location = New System.Drawing.Point(9, 152)
        Me._IMSS_StopClearingPageFile_CheckBox.Name = "_IMSS_StopClearingPageFile_CheckBox"
        Me._IMSS_StopClearingPageFile_CheckBox.Size = New System.Drawing.Size(337, 23)
        Me._IMSS_StopClearingPageFile_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_StopClearingPageFile_CheckBox.TabIndex = 4
        Me._IMSS_StopClearingPageFile_CheckBox.Text = "Stop clearing the page file every time you power off the computer"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me._IMSS_RestoreDefault_Button)
        Me.PanelEx1.Controls.Add(Me._IMSS_Cancel_Button)
        Me.PanelEx1.Controls.Add(Me._IMSS_OK_Button)
        Me.PanelEx1.Controls.Add(Me.ShapeContainer1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 181)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(361, 34)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 7
        '
        '_IMSS_OK_Button
        '
        Me._IMSS_OK_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_OK_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_OK_Button.Location = New System.Drawing.Point(283, 7)
        Me._IMSS_OK_Button.Name = "_IMSS_OK_Button"
        Me._IMSS_OK_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_OK_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OK_Button.TabIndex = 0
        Me._IMSS_OK_Button.Text = "OK"
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Cancel_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(202, 7)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Cancel_Button.TabIndex = 1
        Me._IMSS_Cancel_Button.Text = "Cancel"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabelX1.Location = New System.Drawing.Point(107, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(246, 71)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = resources.GetString("LabelX1.Text")
        Me.LabelX1.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.LabelX1.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Location = New System.Drawing.Point(0, 85)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(360, 1)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 10
        '
        '_IMSS_SpeedUpToStageOne_RadioButton
        '
        Me._IMSS_SpeedUpToStageOne_RadioButton.AutoSize = True
        Me._IMSS_SpeedUpToStageOne_RadioButton.Location = New System.Drawing.Point(12, 96)
        Me._IMSS_SpeedUpToStageOne_RadioButton.Name = "_IMSS_SpeedUpToStageOne_RadioButton"
        Me._IMSS_SpeedUpToStageOne_RadioButton.Size = New System.Drawing.Size(253, 17)
        Me._IMSS_SpeedUpToStageOne_RadioButton.TabIndex = 11
        Me._IMSS_SpeedUpToStageOne_RadioButton.TabStop = True
        Me._IMSS_SpeedUpToStageOne_RadioButton.Text = "Speed up Windows shutdown 5000 milliseconds"
        Me._IMSS_SpeedUpToStageOne_RadioButton.UseVisualStyleBackColor = True
        '
        '_IMSS_SpeedUpToStageTwo_RadioButton
        '
        Me._IMSS_SpeedUpToStageTwo_RadioButton.AutoSize = True
        Me._IMSS_SpeedUpToStageTwo_RadioButton.Location = New System.Drawing.Point(12, 126)
        Me._IMSS_SpeedUpToStageTwo_RadioButton.Name = "_IMSS_SpeedUpToStageTwo_RadioButton"
        Me._IMSS_SpeedUpToStageTwo_RadioButton.Size = New System.Drawing.Size(253, 17)
        Me._IMSS_SpeedUpToStageTwo_RadioButton.TabIndex = 12
        Me._IMSS_SpeedUpToStageTwo_RadioButton.TabStop = True
        Me._IMSS_SpeedUpToStageTwo_RadioButton.Text = "Speed up Windows shutdown 1000 milliseconds"
        Me._IMSS_SpeedUpToStageTwo_RadioButton.UseVisualStyleBackColor = True
        '
        '_IMSS_RestoreDefault_Button
        '
        Me._IMSS_RestoreDefault_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_RestoreDefault_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_RestoreDefault_Button.Location = New System.Drawing.Point(93, 7)
        Me._IMSS_RestoreDefault_Button.Name = "_IMSS_RestoreDefault_Button"
        Me._IMSS_RestoreDefault_Button.Size = New System.Drawing.Size(94, 23)
        Me._IMSS_RestoreDefault_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_RestoreDefault_Button.TabIndex = 2
        Me._IMSS_RestoreDefault_Button.Text = "Restore default"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(361, 34)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 192
        Me.LineShape1.X2 = 192
        Me.LineShape1.Y1 = 10
        Me.LineShape1.Y2 = 25
        '
        'IMSS_ConfigureOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 215)
        Me.Controls.Add(Me._IMSS_BackGroundPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IMSS_ConfigureOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configure Options"
        Me._IMSS_BackGroundPanel.ResumeLayout(False)
        Me._IMSS_BackGroundPanel.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_BackGroundPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Recommended_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Cancel_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_OK_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_StopClearingPageFile_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SpeedUpToStageOne_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_SpeedUpToStageTwo_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_RestoreDefault_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
