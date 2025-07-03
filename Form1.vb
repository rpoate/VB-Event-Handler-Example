Imports Zoople

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Me.HtmlEditControl1.CancellableUserInteraction, AddressOf CancellableUserInteraction
        Dim oButton = Me.HtmlEditControl1.ToolStripItems.Add("Code Wrap")
        AddHandler oButton.Click, AddressOf CodeWrap_Click
    End Sub

    Private Sub CodeWrap_Click(sender As Object, e As EventArgs)
        Me.HtmlEditControl1.CodeEditor.WordWrap = Not Me.HtmlEditControl1.CodeEditor.WordWrap
    End Sub

    Private Sub CancellableUserInteraction(sender As Object, e As CancellableUserInteractionEventsArgs)

        If e.InteractionType = Zoople.EditorUIEvents.onkeydown Then

            If e.Keys.Keycode = Keys.Tab Then

                e.Cancel = True
                HtmlEditControl1.InsertAtCursor("&nbsp;&nbsp;", HTMLEditControl.ed_InsertType.ed_InsertReplaceSelection)

            End If
        End If

    End Sub
End Class
