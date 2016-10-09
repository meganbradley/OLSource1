---
title: "How to: Dispose of a System Resource (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "Using statement, disposing of system resources"
  - "Visual Basic code, control flow"
  - "system resources, disposing of"
  - "resources [Visual Basic], disposing of system"
  - "system resources"
  - "Using statement, Using...End Using"
  - "Using block"
ms.assetid: 8be2b239-8090-419b-8e7e-bcaa75b0ecc8
caps.latest.revision: 15
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
# How to: Dispose of a System Resource (Visual Basic)
You can use a `Using` block to guarantee that the system disposes of a resource when your code exits the block. This is useful if you are using a system resource that consumes a large amount of memory, or that other components also want to use.  
  
### To dispose of a database connection when your code is finished with it  
  
1.  Make sure you include the appropriate [Imports Statement (.NET Namespace and Type)](../VS_visualbasic/imports-statement--.net-namespace-and-type-.md) for the database connection at the beginning of your source file (in this case, \<xref:System.Data.SqlClient>).  
  
2.  Create a `Using` block with the `Using` and `End Using` statements. Inside the block, put the code that deals with the database connection.  
  
3.  Declare the connection and create an instance of it as part of the `Using` statement.  
  
    ```  
    ' Insert the following line at the beginning of your source file.  
    Imports System.Data.SqlClient  
    Public Sub AccessSql(ByVal s As String)  
        Using sqc As New System.Data.SqlClient.SqlConnection(s)  
            MsgBox("Connected with string """ & sqc.ConnectionString & """")  
        End Using  
    End Sub  
    ```  
  
     The system disposes of the resource no matter how you exit the block, including the case of an unhandled exception.  
  
     Note that you cannot access `sqc` from outside the `Using` block, because its scope is limited to the block.  
  
     You can use this same technique on a system resource such as a file handle or a COM wrapper. You use a `Using` block when you want to be sure to leave the resource available for other components after you have exited the `Using` block.  
  
## See Also  
 \<xref:System.Data.SqlClient.SqlConnection>   
 [Control Flow](../VS_visualbasic/control-flow-in-visual-basic.md)   
 [Decision Structures](../VS_visualbasic/decision-structures--visual-basic-.md)   
 [Loop Structures](../VS_visualbasic/loop-structures--visual-basic-.md)   
 [Other Control Structures](../VS_visualbasic/other-control-structures--visual-basic-.md)   
 [Nested Control Structures](../VS_visualbasic/nested-control-structures--visual-basic-.md)   
 [Using Statement](../VS_visualbasic/using-statement--visual-basic-.md)