    <CachedAttribute()> _
    Public CachedString As String = "This string is cached in the workbook."

    Private protectStructureValue As Boolean
    Private protectWindowsValue As Boolean

    Protected Overrides Sub UnprotectDocument()
        protectStructureValue = Me.ProtectStructure
        protectWindowsValue = Me.ProtectWindows

        Me.Unprotect(securelyStoredPassword)
    End Sub

    Protected Overrides Sub ProtectDocument()
        Me.Protect(securelyStoredPassword, protectStructureValue, _
            protectWindowsValue)
    End Sub