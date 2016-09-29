---
title: "Data type(s) of the type parameter(s) in extension method &#39;&lt;methodname&gt;&#39; defined in &#39;&lt;typename&gt;&#39; cannot be inferred from these arguments because more than one type is possible"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc36655"
  - "vbc36652"
  - "vbc36655"
  - "bc36652"
helpviewer_keywords: 
  - "BC36655"
  - "BC36652"
ms.assetid: 49836f20-c877-4267-8bdc-6f6d108fb8c0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data type(s) of the type parameter(s) in extension method &#39;&lt;methodname&gt;&#39; defined in &#39;&lt;typename&gt;&#39; cannot be inferred from these arguments because more than one type is possible
Data type(s) of the type parameter(s) in extension method '<methodname\>' defined in '<typename\>' cannot be inferred from these arguments because more than one type is possible. Specifying the data type(s) explicitly might correct this error.  
  
 An attempt has been made to use type inference to determine the type (or types) of the type parameter (or parameters) in a call to a generic extension method. The compiler finds more than one possible data type for one or more of the type parameters, and it reports this error.  
  
> [!NOTE]
>  When specifying arguments is not an option (for example, for query operators in query expressions), the error message appears without the second sentence.  
  
 The following code demonstrates the error.  
  
```vb#  
Option Strict Off  
Imports System.Runtime.CompilerServices  
Module Module1  
    Sub Main()  
  
        Dim caller As New Class1  
        '' Not valid.  
        'caller.targetExtension(1, "2")  
  
    End Sub  
  
    <Extension()> _  
    Sub targetExtension(Of T)(ByVal p0 As Class1, ByVal p1 As T, ByVal p2 As T)  
    End Sub  
  
    Class Class1  
    End Class  
  
End Module  
```  
  
 **Error ID:** BC36655 (within [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries) and BC36652 (outside queries)  
  
### To correct this error  
  
-   If the error appears outside of a query, try specifying the data type of the type parameter or parameters explicitly:  
  
    ```  
    caller.targetExtension(Of Integer)(1, "2")  
    caller.targetExtension(Of String)(1, "2")  
    ```  
  
## See Also  
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)