'Tsagan Garyaeva
'Comp-185
'Lab 9 Student Clubs 
'11/18/2017




Public Class Form1
    Dim ClubArray(,) As Integer = {{0, 1, 2, 3},
                                    {1, 0, 1, 0},
                                    {0, 0, 1, 0},
                                    {1, 1, 1, 0},
                                    {0, 0, 1, 0},
                                    {1, 1, 1, 0},
                                    {1, 0, 1, 0},
                                    {0, 1, 1, 0},
                                    {0, 0, 1, 0},
                                    {1, 0, 1, 0},
                                    {1, 0, 1, 0},
                                    {0, 0, 0, 1}}
    Dim CounterMembers(4) As Integer
    Private Sub cbClubs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClubs.SelectedIndexChanged
        Dim CounterMembers = {0, 0, 0, 0}
        lblText.Text = String.Empty
        Try
            If cbClubs.SelectedIndex <> -1 Then
                lstClubMembershipList.Items.Clear()
                btnAddStudent.Enabled = True
                btnRemoveSelStudent.Enabled = True
            End If
            For i = 0 To lstGeneralStudentList.Items.Count - 1
                If (ClubArray(i, cbClubs.SelectedIndex) = 1) Then
                    lstClubMembershipList.Items.Add(lstGeneralStudentList.Items(i))
                    CounterMembers(cbClubs.SelectedIndex) = CounterMembers(cbClubs.SelectedIndex) + 1
                End If
                lblText.Text = CounterMembers(cbClubs.SelectedIndex).ToString

            Next
        Catch

        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Sub add()
        lstClubMembershipList.Items.Add(lstClubMembershipList.SelectedItem.ToString)
        ClubArray(lstGeneralStudentList.SelectedIndex, cbClubs.SelectedIndex) = 1
        CounterMembers(cbClubs.SelectedIndex) = CounterMembers(cbClubs.SelectedIndex) + 1
        lblText.Text = CounterMembers(cbClubs.SelectedIndex).ToString
    End Sub





    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

        Dim IsSelected As Boolean = True
        Try

            'if user did not select item
            If lstGeneralStudentList.SelectedIndex = -1 Then MessageBox.Show("Select a student")

            If lstClubMembershipList.Items.Count = 0 Then
                add()
            Else

                For i = lstClubMembershipList.Items.Count - 1 To 0 Step -1
                    If lstGeneralStudentList.SelectedItem.ToString() = lstClubMembershipList.Items(i).ToString Then
                        MessageBox.Show("This student is member already")
                        IsSelected = False
                    End If
                Next
                If IsSelected Then
                    add()
                End If
            End If
            lblText.Text = CounterMembers(cbClubs.SelectedIndex).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnRemoveSelStudent_Click(sender As Object, e As EventArgs) Handles btnRemoveSelStudent.Click
        Dim strInputDelete As String 'holds selected item


        Try
            If lstClubMembershipList.SelectedIndex = -1 Then MessageBox.Show("Select a student")

            strInputDelete = lstClubMembershipList.SelectedItem.ToString()
            lstClubMembershipList.Items.Remove(strInputDelete)

            For i = 0 To lstGeneralStudentList.Items.Count - 1
                If strInputDelete = lstGeneralStudentList.Items(i).ToString Then
                    ClubArray(i, cbClubs.SelectedIndex) = 0
                    CounterMembers(cbClubs.SelectedIndex) = CounterMembers(cbClubs.SelectedIndex) - 1

                End If
            Next
            lblText.Text = CounterMembers(cbClubs.SelectedIndex).ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        If lstClubMembershipList.Items.Count = 0 Then lblText.Text = "There are no members in the list!"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
