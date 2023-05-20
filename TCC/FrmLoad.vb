Public Class FrmLoad

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click



    End Sub

    Private Sub FrmLoad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Minimum
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            FrmPrincipal.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub
End Class