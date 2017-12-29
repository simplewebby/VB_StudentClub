'Tsagan Garyaeva
'Comp-185
'Lab 4 Student Club 
'10/15/2017



Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim intNumStudents As Integer ' number of items in general list
        Dim strInput As String 'holds selected item

        Try

            'if user did not select item
            If lstGeneralStudentList.SelectedIndex = -1 Then MessageBox.Show("Select a student")
            'adding selected student to the list
            strInput = lstGeneralStudentList.SelectedItem.ToString()
            If lstGeneralStudentList.SelectedIndex <> -1 Then lstClubMembershipList.Items.Add(strInput)
            lstGeneralStudentList.Items.Remove(strInput)

            'check if is it empty
            If lstGeneralStudentList.Items.Count = 0 Then MessageBox.Show("The are no students in the list!")
            intNumStudents = lstGeneralStudentList.Items.Count
            intNumStudents = lstClubMembershipList.Items.Count
            lblText.Text = intNumStudents & " member(s)"

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnRemoveSelStudent_Click(sender As Object, e As EventArgs) Handles btnRemoveSelStudent.Click
        Dim strInputDelete As String 'holds selected item

        Dim intNumSt As Integer
        Try
            If lstClubMembershipList.SelectedIndex = -1 Then MessageBox.Show("Select a student")
            strInputDelete = lstClubMembershipList.SelectedItem.ToString()
            lstClubMembershipList.Items.Remove(strInputDelete)
            intNumSt = lstClubMembershipList.Items.Count
            lblText.Text = intNumSt & " member(s)"

            If lstClubMembershipList.Items.Count = 0 Then lblText.Text = "There are no members in the list!"




        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub
End Class
