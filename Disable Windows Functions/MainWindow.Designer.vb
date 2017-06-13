<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainBackGroundPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_FooterPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Done_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me._IMSS_SUWS_Configure = New System.Windows.Forms.LinkLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me._IMSS_WindowsSearchiIndex_On_Off = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me._IMSS_WindowsSearchIndex_Label = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IMSS_Info_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_Hibernationfile_On_Off = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me._IMSS_Hibernationfile_OutPutLabel = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_Hibernationfile_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Details_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Label_Title = New DevComponents.DotNetBar.LabelX()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me._IMSS_WindowsSearchIndexService = New System.ServiceProcess.ServiceController()
        Me._IMSS_BalloonTip = New DevComponents.DotNetBar.BalloonTip()
        Me._IMSS_MainBackGroundPanel.SuspendLayout()
        Me._IMSS_FooterPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me._IMSS_Info_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainBackGroundPanel
        '
        Me._IMSS_MainBackGroundPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainBackGroundPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainBackGroundPanel.Controls.Add(Me._IMSS_FooterPanel)
        Me._IMSS_MainBackGroundPanel.Controls.Add(Me.Panel3)
        Me._IMSS_MainBackGroundPanel.Controls.Add(Me.Panel2)
        Me._IMSS_MainBackGroundPanel.Controls.Add(Me.Panel1)
        Me._IMSS_MainBackGroundPanel.Controls.Add(Me._IMSS_Details_Label)
        Me._IMSS_MainBackGroundPanel.Controls.Add(Me._IMSS_Label_Title)
        Me._IMSS_MainBackGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainBackGroundPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainBackGroundPanel.Name = "_IMSS_MainBackGroundPanel"
        Me._IMSS_MainBackGroundPanel.Size = New System.Drawing.Size(389, 380)
        Me._IMSS_MainBackGroundPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainBackGroundPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainBackGroundPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._IMSS_MainBackGroundPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainBackGroundPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainBackGroundPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainBackGroundPanel.Style.GradientAngle = 90
        Me._IMSS_MainBackGroundPanel.TabIndex = 0
        '
        '_IMSS_FooterPanel
        '
        Me._IMSS_FooterPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_FooterPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_FooterPanel.Controls.Add(Me._IMSS_Done_Button)
        Me._IMSS_FooterPanel.Location = New System.Drawing.Point(0, 336)
        Me._IMSS_FooterPanel.Name = "_IMSS_FooterPanel"
        Me._IMSS_FooterPanel.Size = New System.Drawing.Size(389, 44)
        Me._IMSS_FooterPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_FooterPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_FooterPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_FooterPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_FooterPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_FooterPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_FooterPanel.Style.GradientAngle = 90
        Me._IMSS_FooterPanel.TabIndex = 7
        '
        '_IMSS_Done_Button
        '
        Me._IMSS_Done_Button.Location = New System.Drawing.Point(302, 11)
        Me._IMSS_Done_Button.Name = "_IMSS_Done_Button"
        Me._IMSS_Done_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Done_Button.TabIndex = 0
        Me._IMSS_Done_Button.Text = "Done"
        Me._IMSS_Done_Button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me._IMSS_SUWS_Configure)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.LabelX4)
        Me.Panel3.Location = New System.Drawing.Point(25, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(339, 81)
        Me.Panel3.TabIndex = 6
        '
        '_IMSS_SUWS_Configure
        '
        Me._IMSS_SUWS_Configure.AutoSize = True
        Me._IMSS_SUWS_Configure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SUWS_Configure.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me._IMSS_SUWS_Configure.LinkColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_SUWS_Configure.Location = New System.Drawing.Point(97, 44)
        Me._IMSS_SUWS_Configure.Name = "_IMSS_SUWS_Configure"
        Me._IMSS_SUWS_Configure.Size = New System.Drawing.Size(61, 13)
        Me._IMSS_SUWS_Configure.TabIndex = 5
        Me._IMSS_SUWS_Configure.TabStop = True
        Me._IMSS_SUWS_Configure.Text = "Configure"
        '
        'PictureBox4
        '
        Me._IMSS_BalloonTip.SetBalloonCaption(Me.PictureBox4, "About Speed Up Windows Shutdown")
        Me._IMSS_BalloonTip.SetBalloonText(Me.PictureBox4, resources.GetString("PictureBox4.BalloonText"))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(286, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(88, 74)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelX4.Location = New System.Drawing.Point(97, 13)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(183, 16)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Speed Up Windows Shutdown"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me._IMSS_WindowsSearchiIndex_On_Off)
        Me.Panel2.Controls.Add(Me._IMSS_WindowsSearchIndex_Label)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Location = New System.Drawing.Point(25, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 81)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox2
        '
        Me._IMSS_BalloonTip.SetBalloonCaption(Me.PictureBox2, "About Windows Search iIndex")
        Me._IMSS_BalloonTip.SetBalloonText(Me.PictureBox2, "Windows uses the index to perform very fast searches on your computer, Windows in" & _
                "dexes the most commonly searched locations on your PC to make your searches fast" & _
                "er")
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(257, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        '_IMSS_WindowsSearchiIndex_On_Off
        '
        '
        '
        '
        Me._IMSS_WindowsSearchiIndex_On_Off.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_WindowsSearchiIndex_On_Off.Location = New System.Drawing.Point(97, 55)
        Me._IMSS_WindowsSearchiIndex_On_Off.Name = "_IMSS_WindowsSearchiIndex_On_Off"
        Me._IMSS_WindowsSearchiIndex_On_Off.Size = New System.Drawing.Size(67, 21)
        Me._IMSS_WindowsSearchiIndex_On_Off.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_WindowsSearchiIndex_On_Off.TabIndex = 3
        '
        '_IMSS_WindowsSearchIndex_Label
        '
        Me._IMSS_WindowsSearchIndex_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_WindowsSearchIndex_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_WindowsSearchIndex_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_WindowsSearchIndex_Label.Location = New System.Drawing.Point(97, 34)
        Me._IMSS_WindowsSearchIndex_Label.Name = "_IMSS_WindowsSearchIndex_Label"
        Me._IMSS_WindowsSearchIndex_Label.Size = New System.Drawing.Size(67, 15)
        Me._IMSS_WindowsSearchIndex_Label.TabIndex = 2
        Me._IMSS_WindowsSearchIndex_Label.Text = "OutPut Label"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(88, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelX2.Location = New System.Drawing.Point(97, 13)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(154, 16)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Windows Search iIndex"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me._IMSS_Info_PictureBox)
        Me.Panel1.Controls.Add(Me._IMSS_Hibernationfile_On_Off)
        Me.Panel1.Controls.Add(Me._IMSS_Hibernationfile_OutPutLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me._IMSS_Hibernationfile_Label)
        Me.Panel1.Location = New System.Drawing.Point(25, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 81)
        Me.Panel1.TabIndex = 2
        '
        '_IMSS_Info_PictureBox
        '
        Me._IMSS_BalloonTip.SetBalloonCaption(Me._IMSS_Info_PictureBox, "About Hibernation file")
        Me._IMSS_BalloonTip.SetBalloonText(Me._IMSS_Info_PictureBox, "To avoid some of the drawbacks of Vista’s Sleep power-saving mode, you can hibern" & _
                "ate your PC. Hibernate saves a copy of everything in your PC’s memory (RAM) onto" & _
                " your hard disk before it shuts down.")
        Me._IMSS_Info_PictureBox.Cursor = System.Windows.Forms.Cursors.Help
        Me._IMSS_Info_PictureBox.Image = CType(resources.GetObject("_IMSS_Info_PictureBox.Image"), System.Drawing.Image)
        Me._IMSS_Info_PictureBox.Location = New System.Drawing.Point(221, 13)
        Me._IMSS_Info_PictureBox.Name = "_IMSS_Info_PictureBox"
        Me._IMSS_Info_PictureBox.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Info_PictureBox.TabIndex = 4
        Me._IMSS_Info_PictureBox.TabStop = False
        '
        '_IMSS_Hibernationfile_On_Off
        '
        '
        '
        '
        Me._IMSS_Hibernationfile_On_Off.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Hibernationfile_On_Off.Location = New System.Drawing.Point(97, 55)
        Me._IMSS_Hibernationfile_On_Off.Name = "_IMSS_Hibernationfile_On_Off"
        Me._IMSS_Hibernationfile_On_Off.Size = New System.Drawing.Size(67, 21)
        Me._IMSS_Hibernationfile_On_Off.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Hibernationfile_On_Off.TabIndex = 3
        '
        '_IMSS_Hibernationfile_OutPutLabel
        '
        Me._IMSS_Hibernationfile_OutPutLabel.AutoSize = True
        '
        '
        '
        Me._IMSS_Hibernationfile_OutPutLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Hibernationfile_OutPutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_Hibernationfile_OutPutLabel.Location = New System.Drawing.Point(97, 34)
        Me._IMSS_Hibernationfile_OutPutLabel.Name = "_IMSS_Hibernationfile_OutPutLabel"
        Me._IMSS_Hibernationfile_OutPutLabel.Size = New System.Drawing.Size(67, 15)
        Me._IMSS_Hibernationfile_OutPutLabel.TabIndex = 2
        Me._IMSS_Hibernationfile_OutPutLabel.Text = "OutPut Label"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_Hibernationfile_Label
        '
        Me._IMSS_Hibernationfile_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Hibernationfile_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Hibernationfile_Label.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Hibernationfile_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me._IMSS_Hibernationfile_Label.Location = New System.Drawing.Point(97, 13)
        Me._IMSS_Hibernationfile_Label.Name = "_IMSS_Hibernationfile_Label"
        Me._IMSS_Hibernationfile_Label.Size = New System.Drawing.Size(118, 16)
        Me._IMSS_Hibernationfile_Label.TabIndex = 0
        Me._IMSS_Hibernationfile_Label.Text = "Hibernation file"
        '
        '_IMSS_Details_Label
        '
        Me._IMSS_Details_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Details_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Details_Label.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Details_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_Details_Label.Location = New System.Drawing.Point(25, 39)
        Me._IMSS_Details_Label.Name = "_IMSS_Details_Label"
        Me._IMSS_Details_Label.Size = New System.Drawing.Size(339, 30)
        Me._IMSS_Details_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Details_Label.TabIndex = 1
        Me._IMSS_Details_Label.Text = "The following Windows functions are not needed by every user." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You may be able to" & _
            " disable them to free up disk space"
        Me._IMSS_Details_Label.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        '_IMSS_Label_Title
        '
        Me._IMSS_Label_Title.AutoSize = True
        '
        '
        '
        Me._IMSS_Label_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Label_Title.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Label_Title.Location = New System.Drawing.Point(25, 11)
        Me._IMSS_Label_Title.Name = "_IMSS_Label_Title"
        Me._IMSS_Label_Title.Size = New System.Drawing.Size(125, 17)
        Me._IMSS_Label_Title.TabIndex = 0
        Me._IMSS_Label_Title.Text = "Windows Functions"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 380)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(389, 0)
        Me.DockSite4.TabIndex = 4
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 0)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 380)
        Me.DockSite1.TabIndex = 1
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(389, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 380)
        Me.DockSite2.TabIndex = 2
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 380)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(389, 0)
        Me.DockSite8.TabIndex = 8
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 380)
        Me.DockSite5.TabIndex = 5
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(389, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 380)
        Me.DockSite6.TabIndex = 6
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(389, 0)
        Me.DockSite7.TabIndex = 7
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(389, 0)
        Me.DockSite3.TabIndex = 3
        Me.DockSite3.TabStop = False
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Name = "DockContainerItem1"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(383, 69)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        '_IMSS_WindowsSearchIndexService
        '
        Me._IMSS_WindowsSearchIndexService.ServiceName = "WSearch"
        '
        '_IMSS_BalloonTip
        '
        Me._IMSS_BalloonTip.AlertAnimation = DevComponents.DotNetBar.eAlertAnimation.LeftToRight
        Me._IMSS_BalloonTip.AutoCloseTimeOut = 10
        Me._IMSS_BalloonTip.DefaultBalloonWidth = 300
        Me._IMSS_BalloonTip.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 380)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me._IMSS_MainBackGroundPanel)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(405, 418)
        Me.MinimumSize = New System.Drawing.Size(405, 418)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Windows Functions"
        Me._IMSS_MainBackGroundPanel.ResumeLayout(False)
        Me._IMSS_MainBackGroundPanel.PerformLayout()
        Me._IMSS_FooterPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._IMSS_Info_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainBackGroundPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Details_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Label_Title As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents _IMSS_Hibernationfile_On_Off As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents _IMSS_Hibernationfile_OutPutLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Hibernationfile_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Info_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_WindowsSearchiIndex_On_Off As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents _IMSS_WindowsSearchIndex_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents _IMSS_WindowsSearchIndexService As System.ServiceProcess.ServiceController
    Friend WithEvents _IMSS_SUWS_Configure As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_FooterPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Done_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_BalloonTip As DevComponents.DotNetBar.BalloonTip

End Class
