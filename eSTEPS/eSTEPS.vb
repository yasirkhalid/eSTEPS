Public Class Form1
    Dim CountTab As Integer = 1
    Dim MaxTab As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not CountTab = MaxTab Then
            TabControl1.SelectTab(CountTab)
            CountTab += 1
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaxTab = TabControl1.TabCount
        With cbMStatus
            cbMStatus.Items.Clear()
            cbMStatus.Items.Add("Single")
            cbMStatus.Items.Add("Married")
            cbMStatus.Items.Add("Divorced")
            cbMStatus.Items.Add("Separated")
            cbMStatus.Items.Add("Widow")
        End With
        With cbChildren
            cbChildren.Items.Clear()
            cbChildren.Items.Add("Yes")
            cbChildren.Items.Add("No")
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' If Not CountTab = MaxTab Then
        'TabControl1.TabPages.Count(-1)
        ' CountTab += 1
        '  End If
    End Sub

    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '  Dim ClearT As Control
        cbMStatus.SelectedIndex = -1
        cbChildren.SelectedIndex = 1
        ' For Each ClearT In Me.TabControl1.Controls
        'If TypeOf ClearT Is TextBox Then
        'ClearT.Text = Nothing
        '  End If
        '  Next

    End Sub

    Private Sub CheckedListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox3.SelectedIndexChanged
        Dim i As Integer
        For i = 16 To (CheckedListBox3.Items.Count - 1)
            If CheckedListBox3.GetItemChecked(i) Then
                lcancer.Visible = True
            Else
                lcancer.Visible = False
            End If
        Next
    End Sub
End Class
