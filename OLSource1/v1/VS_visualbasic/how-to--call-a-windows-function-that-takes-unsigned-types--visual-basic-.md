---
title: "How to: Call a Windows Function that Takes Unsigned Types (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Windows functions, calling"
  - "unsigned data types"
  - "UShort data type, using"
  - "functions [Visual Basic], calling Windows functions"
  - "ULong data type, using"
  - "UInteger data type, using"
  - "data types [Visual Basic], using"
  - "unsigned types"
  - "data types [Visual Basic], unsigned"
  - "data types [Visual Basic], numeric"
  - "unsigned types, using"
ms.assetid: c2c0e712-8dc2-43b9-b4c6-345fbb02e7ce
caps.latest.revision: 18
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Call a Windows Function that Takes Unsigned Types (Visual Basic)
If you are consuming a class, module, or structure that has members of unsigned integer types, you can access these members with [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)].  
  
### To call a Windows function that takes an unsigned type  
  
1.  Use a [Declare Statement](../VS_visualbasic/declare-statement.md) to tell [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] which library holds the function, what its name is in that library, what its calling sequence is, and how to convert strings when calling it.  
  
2.  In the `Declare` statement, use `UInteger`, `ULong`, `UShort`, or `Byte` as appropriate for each parameter with an unsigned type.  
  
3.  Consult the documentation for the Windows function you are calling to find the names and values of the constants it uses. Many of these are defined in the WinUser.h file.  
  
4.  Declare the necessary constants in your code. Many Windows constants are 32-bit unsigned values, and you should declare these `As``UInteger`.  
  
5.  Call the function in the normal way. The following example calls the Windows function `MessageBox`, which takes an unsigned integer argument.  
  
    ```  
    Public Class windowsMessage  
        Private Declare Auto Function mb Lib "user32.dll" Alias "MessageBox" (  
            ByVal hWnd As Integer,   
            ByVal lpText As String,   
            ByVal lpCaption As String,   
            ByVal uType As UInteger) As Integer  
        Private Const MB_OK As UInteger = 0  
        Private Const MB_ICONEXCLAMATION As UInteger = &H30  
        Private Const IDOK As UInteger = 1  
        Private Const IDCLOSE As UInteger = 8  
        Private Const c As UInteger = MB_OK Or MB_ICONEXCLAMATION  
        Public Function messageThroughWindows() As String  
            Dim r As Integer = mb(0, "Click OK if you see this!",   
                "Windows API call", c)  
            Dim s As String = "Windows API MessageBox returned " &  
                 CStr(r)& vbCrLf & "(IDOK = " & CStr(IDOK) &  
                 ", IDCLOSE = " & CStr(IDCLOSE) & ")"  
            Return s  
        End Function  
    End Class  
    ```  
  
     You can test the function `messageThroughWindows` with the following code.  
  
    ```  
    Public Sub consumeWindowsMessage()  
        Dim w As New windowsMessage  
        w.messageThroughWindows()  
    End Sub  
    ```  
  
    > [!CAUTION]
    >  The `UInteger`, `ULong`, `UShort`, and `SByte` data types are not part of the [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md) (CLS), so CLS-compliant code cannot consume a component that uses them.  
  
    > [!IMPORTANT]
    >  Making a call to unmanaged code, such as the Windows application programming interface (API), exposes your code to potential security risks.  
  
    > [!IMPORTANT]
    >  Calling the Windows API requires unmanaged code permission, which might affect its execution in partial-trust situations. For more information, see \<xref:System.Security.Permissions.SecurityPermission> and [Code Access Permissions](assetId:///e5ae402f-6dda-4732-bbe8-77296630f675).  
  
## See Also  
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)   
 [Integer Data Type](../VS_visualbasic/integer-data-type--visual-basic-.md)   
 [UInteger Data Type](../VS_visualbasic/uinteger-data-type.md)   
 [Declare Statement](../VS_visualbasic/declare-statement.md)   
 [Walkthrough: Calling Windows APIs](../VS_visualbasic/walkthrough--calling-windows-apis--visual-basic-.md)