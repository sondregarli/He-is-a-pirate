Public Class Form1
    Dim lyd As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Upisdown,
          AudioPlayMode.BackgroundLoop)
        lyd = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If lyd = True Then
            My.Computer.Audio.Stop()
            lyd = False
        Else
            My.Computer.Audio.Play(My.Resources.Upisdown,
          AudioPlayMode.BackgroundLoop)
            lyd = True
        End If
    End Sub
End Class
