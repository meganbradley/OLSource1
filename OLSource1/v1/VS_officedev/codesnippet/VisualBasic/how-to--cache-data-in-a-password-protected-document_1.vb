    <CachedAttribute()> _
    Public CachedString As String = "This string is cached in the document."

    Private protectionTypeValue As Word.WdProtectionType

    Protected Overrides Sub UnprotectDocument()
        If Me.ProtectionType <> Word.WdProtectionType.wdNoProtection Then
            protectionTypeValue = Me.ProtectionType
            Me.Unprotect(securelyStoredPassword)
        End If
    End Sub

    Protected Overrides Sub ProtectDocument()
        Me.Protect(protectionTypeValue, password:=securelyStoredPassword)
    End Sub