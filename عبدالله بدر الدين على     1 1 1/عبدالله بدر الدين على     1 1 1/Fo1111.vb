Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        L1.Text = T1.Text * T2.Text * T3.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If T3.Text = 0 Then L2.Text = "لايمكن القسمه على صفر"
        If T2.Text = 0 Then L2.Text = "لايمكن القسمه على صفر"
        L1.Text = T1.Text / T2.Text / T3.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        L1.Text = Val(T1.Text) + Val(T2.Text) + Val(T3.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        L1.Text = T1.Text - T2.Text - T3.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox("!!!!...  نرجو ان نكون قد اسعدناكم مع اطيب تمنياتى ........ عبالله بدر الدين", MsgBoxStyle.Question, "QUESTION")
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        L5.Text = ""
        L5.Text = "ABDALLA_BADR_ALDIAN"

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        L5.Text = ""
        L5.Text = "ABDALLA_BADR_ALDIAN"
    End Sub

    Private Sub PictureBox1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Move
        L5.Text = ""
        L5.Text = "ABDALLA_BADR_ALDIAN"
    End Sub
End Class