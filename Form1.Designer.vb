﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.HtmlEditControl1 = New Zoople.HTMLEditControl()
        Me.SuspendLayout()
        '
        'HtmlEditControl1
        '
        Me.HtmlEditControl1.AcceptsReturn = True
        Me.HtmlEditControl1.BaseURL = Nothing
        Me.HtmlEditControl1.CleanMSWordHTMLOnPaste = True
        Me.HtmlEditControl1.CodeEditor.Enabled = True
        Me.HtmlEditControl1.CodeEditor.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.HtmlEditControl1.CodeEditor.Locked = False
        Me.HtmlEditControl1.CodeEditor.TabWidth = 720
        Me.HtmlEditControl1.CodeEditor.WordWrap = False
        Me.HtmlEditControl1.CSSText = Nothing
        Me.HtmlEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HtmlEditControl1.DocumentHTML = Nothing
        Me.HtmlEditControl1.EnableInlineSpelling = False
        Me.HtmlEditControl1.FontSizesList = Nothing
        Me.HtmlEditControl1.FontsList = Nothing
        Me.HtmlEditControl1.HiddenButtons = Nothing
        Me.HtmlEditControl1.ImageStorageLocation = Nothing
        Me.HtmlEditControl1.InCodeView = False
        Me.HtmlEditControl1.IndentAmount = 2
        Me.HtmlEditControl1.IndentsUseBlockuote = False
        Me.HtmlEditControl1.LanguageFile = Nothing
        Me.HtmlEditControl1.LicenceActivationKey = Nothing
        Me.HtmlEditControl1.LicenceKey = Nothing
        Me.HtmlEditControl1.LicenceKeyInlineSpelling = Nothing
        Me.HtmlEditControl1.Location = New System.Drawing.Point(0, 0)
        Me.HtmlEditControl1.Name = "HtmlEditControl1"
        Me.HtmlEditControl1.Size = New System.Drawing.Size(800, 450)
        Me.HtmlEditControl1.TabIndex = 0
        Me.HtmlEditControl1.ToolstripImageScalingSize = New System.Drawing.Size(16, 16)
        Me.HtmlEditControl1.UseParagraphAsDefault = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HtmlEditControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HtmlEditControl1 As Zoople.HTMLEditControl
End Class
