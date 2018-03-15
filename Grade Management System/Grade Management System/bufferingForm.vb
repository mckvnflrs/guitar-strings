Option Explicit On

Public NotInheritable Class bufferingForm

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            Me.Close()
            Timer1.Stop()

        End If
    End Sub
End Class
