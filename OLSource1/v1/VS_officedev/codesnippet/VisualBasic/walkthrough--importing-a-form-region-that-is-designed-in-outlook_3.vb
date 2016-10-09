    Private Function FindTaskBySubjectName(ByVal subjectName As String) _
        As Outlook.TaskItem
        Dim Application As New Outlook.Application()
        Dim outlookNameSpace As Outlook.NameSpace = _
            Application.GetNamespace("MAPI")
        Dim tasksFolder As Outlook.MAPIFolder = _
            outlookNameSpace.GetDefaultFolder _
                (Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderTasks)
        Dim taskItems As Outlook.Items = tasksFolder.Items
        Dim taskItem As Outlook.TaskItem
        For Each taskItem In taskItems
            If taskItem.Subject = subjectName Then
                Return taskItem
            End If
        Next taskItem
        Return Nothing
    End Function