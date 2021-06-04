Public Class Form1

    Dim vize, final, gecme As Integer
    Dim sonuc As Double

    Private Sub HakkındaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HakkındaToolStripMenuItem1.Click
        MsgBox("Eyüp Can Balaban tarafından geliştirilmiştir.İlerde yeni sürümle devam edilecektir.Takipte kalın..", MsgBoxStyle.OkOnly, "Hakkında")

    End Sub

    Private Sub YardımToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YardımToolStripMenuItem.Click
        MsgBox("Ne tür yardım istiyorsunuz ? :D ", MsgBoxStyle.OkOnly, "Yardım")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        gecme = TextBox1.Text
        vize = TextBox2.Text
        final = TextBox3.Text
        sonuc = vize * 0.4 + final * 0.6
        TextBox4.Text = sonuc

        If sonuc >= gecme Then
            TextBox4.BackColor = Color.GreenYellow
        Else
            TextBox4.BackColor = Color.Red
        End If











    End Sub


End Class
