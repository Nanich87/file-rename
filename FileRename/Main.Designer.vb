<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileRename
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
        Me.btnRename = New System.Windows.Forms.Button()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.txtIntStartIndex = New System.Windows.Forms.TextBox()
        Me.txtIntLength = New System.Windows.Forms.TextBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.frmString = New System.Windows.Forms.GroupBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblStartIndex = New System.Windows.Forms.Label()
        Me.frmFileName = New System.Windows.Forms.GroupBox()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.lblGooglePlus = New System.Windows.Forms.LinkLabel()
        Me.btnSelectDirectory = New System.Windows.Forms.Button()
        Me.TrackBar = New System.Windows.Forms.TrackBar()
        Me.txtOldNamePreview = New System.Windows.Forms.TextBox()
        Me.frmNamePreview = New System.Windows.Forms.GroupBox()
        Me.lblNewNamePreview = New System.Windows.Forms.Label()
        Me.lblOldNamePreview = New System.Windows.Forms.Label()
        Me.txtNewNamePreview = New System.Windows.Forms.TextBox()
        Me.lblHomePage = New System.Windows.Forms.LinkLabel()
        Me.frmString.SuspendLayout()
        Me.frmFileName.SuspendLayout()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmNamePreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(313, 12)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(87, 24)
        Me.btnRename.TabIndex = 0
        Me.btnRename.Text = "Промени"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(14, 14)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(252, 21)
        Me.txtDirectory.TabIndex = 1
        '
        'txtIntStartIndex
        '
        Me.txtIntStartIndex.Location = New System.Drawing.Point(90, 13)
        Me.txtIntStartIndex.Name = "txtIntStartIndex"
        Me.txtIntStartIndex.Size = New System.Drawing.Size(58, 21)
        Me.txtIntStartIndex.TabIndex = 2
        '
        'txtIntLength
        '
        Me.txtIntLength.Location = New System.Drawing.Point(90, 39)
        Me.txtIntLength.Name = "txtIntLength"
        Me.txtIntLength.Size = New System.Drawing.Size(58, 21)
        Me.txtIntLength.TabIndex = 3
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(92, 13)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(116, 21)
        Me.txtPrefix.TabIndex = 4
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(92, 39)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(116, 21)
        Me.txtSuffix.TabIndex = 5
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(92, 65)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(65, 21)
        Me.txtExtension.TabIndex = 6
        '
        'frmString
        '
        Me.frmString.Controls.Add(Me.lblLength)
        Me.frmString.Controls.Add(Me.lblStartIndex)
        Me.frmString.Controls.Add(Me.txtIntStartIndex)
        Me.frmString.Controls.Add(Me.txtIntLength)
        Me.frmString.Location = New System.Drawing.Point(14, 41)
        Me.frmString.Name = "frmString"
        Me.frmString.Size = New System.Drawing.Size(160, 70)
        Me.frmString.TabIndex = 7
        Me.frmString.TabStop = False
        Me.frmString.Text = "Низ"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(7, 42)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(60, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "Дължина"
        '
        'lblStartIndex
        '
        Me.lblStartIndex.AutoSize = True
        Me.lblStartIndex.Location = New System.Drawing.Point(7, 16)
        Me.lblStartIndex.Name = "lblStartIndex"
        Me.lblStartIndex.Size = New System.Drawing.Size(50, 13)
        Me.lblStartIndex.TabIndex = 0
        Me.lblStartIndex.Text = "Начало"
        '
        'frmFileName
        '
        Me.frmFileName.Controls.Add(Me.lblExtension)
        Me.frmFileName.Controls.Add(Me.lblSuffix)
        Me.frmFileName.Controls.Add(Me.txtExtension)
        Me.frmFileName.Controls.Add(Me.lblPrefix)
        Me.frmFileName.Controls.Add(Me.txtSuffix)
        Me.frmFileName.Controls.Add(Me.txtPrefix)
        Me.frmFileName.Location = New System.Drawing.Point(180, 41)
        Me.frmFileName.Name = "frmFileName"
        Me.frmFileName.Size = New System.Drawing.Size(220, 100)
        Me.frmFileName.TabIndex = 8
        Me.frmFileName.TabStop = False
        Me.frmFileName.Text = "Име на файл"
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Location = New System.Drawing.Point(6, 68)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(78, 13)
        Me.lblExtension.TabIndex = 2
        Me.lblExtension.Text = "Разширение"
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Location = New System.Drawing.Point(6, 42)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(52, 13)
        Me.lblSuffix.TabIndex = 1
        Me.lblSuffix.Text = "Суфикс"
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.Location = New System.Drawing.Point(6, 16)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(58, 13)
        Me.lblPrefix.TabIndex = 0
        Me.lblPrefix.Text = "Префикс"
        '
        'lblGooglePlus
        '
        Me.lblGooglePlus.AutoSize = True
        Me.lblGooglePlus.Location = New System.Drawing.Point(131, 256)
        Me.lblGooglePlus.Name = "lblGooglePlus"
        Me.lblGooglePlus.Size = New System.Drawing.Size(56, 13)
        Me.lblGooglePlus.TabIndex = 9
        Me.lblGooglePlus.TabStop = True
        Me.lblGooglePlus.Text = "Google+"
        '
        'btnSelectDirectory
        '
        Me.btnSelectDirectory.Location = New System.Drawing.Point(272, 12)
        Me.btnSelectDirectory.Name = "btnSelectDirectory"
        Me.btnSelectDirectory.Size = New System.Drawing.Size(38, 24)
        Me.btnSelectDirectory.TabIndex = 10
        Me.btnSelectDirectory.Text = "..."
        Me.btnSelectDirectory.UseVisualStyleBackColor = True
        '
        'TrackBar
        '
        Me.TrackBar.Location = New System.Drawing.Point(14, 117)
        Me.TrackBar.Name = "TrackBar"
        Me.TrackBar.Size = New System.Drawing.Size(160, 45)
        Me.TrackBar.TabIndex = 11
        '
        'txtOldNamePreview
        '
        Me.txtOldNamePreview.Location = New System.Drawing.Point(90, 18)
        Me.txtOldNamePreview.Name = "txtOldNamePreview"
        Me.txtOldNamePreview.ReadOnly = True
        Me.txtOldNamePreview.Size = New System.Drawing.Size(284, 21)
        Me.txtOldNamePreview.TabIndex = 12
        '
        'frmNamePreview
        '
        Me.frmNamePreview.Controls.Add(Me.lblNewNamePreview)
        Me.frmNamePreview.Controls.Add(Me.lblOldNamePreview)
        Me.frmNamePreview.Controls.Add(Me.txtNewNamePreview)
        Me.frmNamePreview.Controls.Add(Me.txtOldNamePreview)
        Me.frmNamePreview.Location = New System.Drawing.Point(14, 168)
        Me.frmNamePreview.Name = "frmNamePreview"
        Me.frmNamePreview.Size = New System.Drawing.Size(386, 85)
        Me.frmNamePreview.TabIndex = 13
        Me.frmNamePreview.TabStop = False
        Me.frmNamePreview.Text = "Визуализация"
        '
        'lblNewNamePreview
        '
        Me.lblNewNamePreview.AutoSize = True
        Me.lblNewNamePreview.Location = New System.Drawing.Point(13, 51)
        Me.lblNewNamePreview.Name = "lblNewNamePreview"
        Me.lblNewNamePreview.Size = New System.Drawing.Size(66, 13)
        Me.lblNewNamePreview.TabIndex = 15
        Me.lblNewNamePreview.Text = "Ново име:"
        '
        'lblOldNamePreview
        '
        Me.lblOldNamePreview.AutoSize = True
        Me.lblOldNamePreview.Location = New System.Drawing.Point(7, 21)
        Me.lblOldNamePreview.Name = "lblOldNamePreview"
        Me.lblOldNamePreview.Size = New System.Drawing.Size(72, 13)
        Me.lblOldNamePreview.TabIndex = 14
        Me.lblOldNamePreview.Text = "Старо име:"
        '
        'txtNewNamePreview
        '
        Me.txtNewNamePreview.Location = New System.Drawing.Point(90, 48)
        Me.txtNewNamePreview.Name = "txtNewNamePreview"
        Me.txtNewNamePreview.ReadOnly = True
        Me.txtNewNamePreview.Size = New System.Drawing.Size(284, 21)
        Me.txtNewNamePreview.TabIndex = 13
        '
        'lblHomePage
        '
        Me.lblHomePage.AutoSize = True
        Me.lblHomePage.Location = New System.Drawing.Point(193, 256)
        Me.lblHomePage.Name = "lblHomePage"
        Me.lblHomePage.Size = New System.Drawing.Size(86, 13)
        Me.lblHomePage.TabIndex = 14
        Me.lblHomePage.TabStop = True
        Me.lblHomePage.Text = "GNNMobile.eu"
        '
        'FileRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 271)
        Me.Controls.Add(Me.lblHomePage)
        Me.Controls.Add(Me.frmNamePreview)
        Me.Controls.Add(Me.TrackBar)
        Me.Controls.Add(Me.btnSelectDirectory)
        Me.Controls.Add(Me.lblGooglePlus)
        Me.Controls.Add(Me.frmFileName)
        Me.Controls.Add(Me.frmString)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.btnRename)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(425, 310)
        Me.MinimumSize = New System.Drawing.Size(425, 310)
        Me.Name = "FileRename"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Преименуване на файлове v1.1"
        Me.frmString.ResumeLayout(False)
        Me.frmString.PerformLayout()
        Me.frmFileName.ResumeLayout(False)
        Me.frmFileName.PerformLayout()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmNamePreview.ResumeLayout(False)
        Me.frmNamePreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents txtIntStartIndex As System.Windows.Forms.TextBox
    Friend WithEvents txtIntLength As System.Windows.Forms.TextBox
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox
    Friend WithEvents frmString As System.Windows.Forms.GroupBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblStartIndex As System.Windows.Forms.Label
    Friend WithEvents frmFileName As System.Windows.Forms.GroupBox
    Friend WithEvents lblExtension As System.Windows.Forms.Label
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents lblGooglePlus As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSelectDirectory As System.Windows.Forms.Button
    Friend WithEvents TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents txtOldNamePreview As System.Windows.Forms.TextBox
    Friend WithEvents frmNamePreview As System.Windows.Forms.GroupBox
    Friend WithEvents lblNewNamePreview As System.Windows.Forms.Label
    Friend WithEvents lblOldNamePreview As System.Windows.Forms.Label
    Friend WithEvents txtNewNamePreview As System.Windows.Forms.TextBox
    Friend WithEvents lblHomePage As System.Windows.Forms.LinkLabel

End Class
