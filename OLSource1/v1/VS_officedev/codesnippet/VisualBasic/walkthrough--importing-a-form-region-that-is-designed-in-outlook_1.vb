    Private Sub populateComboBox()
        Dim Application As New Outlook.Application()
        Dim outlookNameSpace As Outlook.NameSpace = _
        Application.GetNamespace("MAPI")
        Dim taskFolder As Outlook.MAPIFolder = _
        outlookNameSpace.GetDefaultFolder _
            (Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderTasks)
        Dim taskItems As Outlook.Items = taskFolder.Items
        Dim task As Outlook.TaskItem
        For Each task In taskItems
            If Not (task.Subject Is Nothing) Then
                comboBox1.AddItem(task.Subject, System.Type.Missing)
            End If
        Next task
        comboBox1.Text = comboBox1.GetItem(0)
    End Sub