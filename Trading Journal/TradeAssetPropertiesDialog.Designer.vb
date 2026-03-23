<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TradeAssetPropertiesDialog
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
        LabelName = New Label()
        LabelType = New Label()
        ButtonCancel = New Button()
        ButtonOk = New Button()
        TextBoxName = New TextBox()
        TextBoxType = New TextBox()
        SuspendLayout()
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(10, 9)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(39, 15)
        LabelName.TabIndex = 0
        LabelName.Text = "Name"
        ' 
        ' LabelType
        ' 
        LabelType.AutoSize = True
        LabelType.Location = New Point(10, 55)
        LabelType.Name = "LabelType"
        LabelType.Size = New Size(32, 15)
        LabelType.TabIndex = 1
        LabelType.Text = "Type"
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        ButtonCancel.Cursor = Cursors.Hand
        ButtonCancel.Location = New Point(10, 102)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(75, 23)
        ButtonCancel.TabIndex = 2
        ButtonCancel.Text = "Cancel"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' ButtonOk
        ' 
        ButtonOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonOk.Cursor = Cursors.Hand
        ButtonOk.Location = New Point(156, 102)
        ButtonOk.Name = "ButtonOk"
        ButtonOk.Size = New Size(75, 23)
        ButtonOk.TabIndex = 3
        ButtonOk.Text = "Ok"
        ButtonOk.UseVisualStyleBackColor = True
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxName.BorderStyle = BorderStyle.FixedSingle
        TextBoxName.Location = New Point(10, 29)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(221, 23)
        TextBoxName.TabIndex = 4
        ' 
        ' TextBoxType
        ' 
        TextBoxType.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxType.BorderStyle = BorderStyle.FixedSingle
        TextBoxType.Location = New Point(10, 73)
        TextBoxType.Name = "TextBoxType"
        TextBoxType.Size = New Size(221, 23)
        TextBoxType.TabIndex = 5
        ' 
        ' TradeAssetPropertiesDialog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(243, 133)
        Controls.Add(TextBoxType)
        Controls.Add(TextBoxName)
        Controls.Add(ButtonOk)
        Controls.Add(ButtonCancel)
        Controls.Add(LabelType)
        Controls.Add(LabelName)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        MinimizeBox = False
        Name = "TradeAssetPropertiesDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Trade Asset Properties"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents LabelType As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonOk As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxType As TextBox
End Class
