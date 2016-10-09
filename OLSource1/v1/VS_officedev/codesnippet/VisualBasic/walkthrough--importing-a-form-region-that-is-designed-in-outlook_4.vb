    Private Sub RefreshTaskListBox()
        listBox1.Clear()
        Dim tempTaskItem As Outlook.TaskItem
        Dim tempArray As [String]() = olkTextBox3.Text.Split(New [Char]() {"|"c})

        Dim tempString As String
        For Each tempString In tempArray
            tempTaskItem = FindTaskBySubjectName(tempString)
            If Not (tempTaskItem Is Nothing) Then
                Me.listBox1.AddItem(tempTaskItem.PercentComplete.ToString() & _
                    "% Complete -- " & tempTaskItem.Subject, System.Type.Missing)
            End If
        Next tempString
    End Sub