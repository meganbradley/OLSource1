---
title: "&#39;Extension&#39; attribute can be applied only to &#39;Module&#39;, &#39;Sub&#39;, or &#39;Function&#39; declarations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc36550"
  - "vbc36550"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC36550"
ms.assetid: 4387a51f-733c-45d7-abdb-eb64d4f51078
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Extension&#39; attribute can be applied only to &#39;Module&#39;, &#39;Sub&#39;, or &#39;Function&#39; declarations
The only way to extend a data type in Visual Basic is to define an extension method inside a standard module. The extension method can be a `Sub` procedure or a `Function` procedure. All extension methods must be marked with the extension attribute, `<Extension()>`, from the <xref:System.Runtime.CompilerServices*?displayProperty=fullName> namespace. Optionally, a module that contains an extension method may be marked in the same way. No other use of the extension attribute is valid.  
  
 **Error ID:** BC36550  
  
### To correct this error  
  
-   Remove the extension attribute.  
  
-   Redesign your extension as a method, defined in an enclosing module.  
  
## Example  
 The following example defines a `Print` method for the `String` data type.  
  
```  
Imports StringUtility  
Imports System.Runtime.CompilerServices  
Namespace StringUtility  
    <Extension()>   
    Module StringExtensions  
        <Extension()>   
        Public Sub Print (ByVal str As String)  
            Console.WriteLine(str)  
        End Sub  
    End Module  
End Namespace  
  
```  
  
## See Also  
 [Attributes (C# and Visual Basic)](../VS_csharp/attributes--csharp-and-visual-basic-.md)   
 [Extension Methods (Visual Basic)](../VS_csharp/extension-methods--visual-basic-.md)   
 [Module Statement](../VS_csharp/module-statement.md)