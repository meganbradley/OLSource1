    Private Sub AddDependentTask_Click1() Handles addDependentTask.Click
        Dim tempTaskItem As Outlook.TaskItem = FindTaskBySubjectName _
            (comboBox1.Text)
        If Not (tempTaskItem Is Nothing) Then
            Me.listBox1.AddItem(tempTaskItem.PercentComplete.ToString() & _
                "% Complete -- " & tempTaskItem.Subject, System.Type.Missing)
            Me.olkTextBox3.Text = Me.olkTextBox3.Text & "|" & tempTaskItem.Subject
        End If
    End Sub