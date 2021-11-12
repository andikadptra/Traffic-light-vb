Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lampMerah.Visible = True
        LampKuning.Visible = False
        lampHijau.Visible = False
        'lampu2
        lampHijau2.Visible = True
        lampKuning2.Visible = False
        lampMerah2.Visible = False
        lampKuningScnd1.Visible = False
        lampKuningScnd2.Visible = False
        Timer4.Start()
        Timer1.Start()
        Timer2.Stop()
        Timer3.Stop()
        Timer5.Stop()

        counter1.Text = 10
        counter2.Text = 10

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lamp 1
        If (lampMerah.Visible = True) Then 'merah
            counter1.Text = 10
            Timer3.Start()
            Timer2.Stop()
            Timer1.Stop()
            Timer5.Stop()
            lampMerah.Visible = False
            LampKuning.Visible = True
            lampHijau.Visible = False
            lampKuningScnd1.Visible = False
        End If
        'lamp 2
        If (lampHijau2.Visible = True) Then
            counter2.Text = 10
            lampHijau2.Visible = False
            lampKuning2.Visible = True
            lampMerah2.Visible = False
            lampKuningScnd2.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'lamp 1
        If (lampHijau.Visible = True) Then 'hijau
            counter1.Text = 10
            Timer2.Stop()
            Timer1.Stop()
            Timer3.Stop()
            Timer5.Start()
            lampHijau.Visible = False
            LampKuning.Visible = False
            lampMerah.Visible = False
            lampKuningScnd1.Visible = True
        End If
        'lamp 2
        If (lampMerah2.Visible = True) Then
            counter2.Text = 10
            lampHijau2.Visible = False
            lampKuning2.Visible = False
            lampMerah2.Visible = False
            lampKuningScnd2.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'lamp 1
        If (LampKuning.Visible = True) Then 'kuning
            counter1.Text = 10
            Timer1.Stop()
            Timer2.Start()
            Timer3.Stop()
            Timer5.Stop()
            LampKuning.Visible = False
            lampMerah.Visible = False
            lampHijau.Visible = True
            lampKuningScnd1.Visible = False
        End If
        'lamp 2
        If (lampKuning2.Visible = True) Then
            counter2.Text = 10
            lampHijau2.Visible = False
            lampKuning2.Visible = False
            lampMerah2.Visible = True
            lampKuningScnd2.Visible = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        counter1.Text = Val(counter1.Text) - 1
        counter2.Text = Val(counter2.Text) - 1
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs)
        'lamp 1
        If (lampKuningScnd1.Visible = True) Then 'kuning
            counter1.Text = 2
            Timer1.Start()
            Timer2.Stop()
            Timer3.Stop()
            Timer5.Stop()
            LampKuning.Visible = False
            lampMerah.Visible = True
            lampHijau.Visible = False
            lampKuningScnd1.Visible = False
        End If
        'lamp 2
        If (lampKuningScnd2.Visible = True) Then
            counter2.Text = 2
            lampHijau2.Visible = True
            lampKuning2.Visible = False
            lampMerah2.Visible = False
            lampKuningScnd2.Visible = False
        End If

    End Sub

End Class
