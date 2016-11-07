Public Class Form1
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim GTR As New System.IO.MemoryStream(My.Resources.small_mouse)
        Me.Cursor = New Cursor(GTR)

        Me.WindowState = 2
        i = 0

    End Sub

    Private Sub AxVLCPlugin21_Enter(sender As Object, e As EventArgs) Handles AxVLCPlugin21.Enter
        AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1

        If i = 3 Then           'change this to the number of seconds
            AxVLCPlugin21.playlist.stop()
            Form2.Show()
            Form6.Show()
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    MsgBox(i)
    'End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    i = i + 1
    'End Sub

    ''Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    'End Sub
End Class
