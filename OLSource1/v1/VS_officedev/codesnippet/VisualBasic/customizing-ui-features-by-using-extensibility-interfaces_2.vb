    Friend taskPaneHelper1 As TaskPaneHelper

    Protected Overrides Function RequestService( _
        ByVal serviceGuid As Guid) As Object

        If (serviceGuid = GetType(Office.ICustomTaskPaneConsumer).GUID) Then
            If (taskPaneHelper1 Is Nothing) Then
                taskPaneHelper1 = New TaskPaneHelper()
            End If
            Return taskPaneHelper1
        End If

        Return MyBase.RequestService(serviceGuid)
    End Function