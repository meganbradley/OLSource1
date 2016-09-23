---
title: "Type or &#39;With&#39; expected"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc30988
  - bc30988
helpviewer_keywords: 
  - BC30988
ms.assetid: ab9c0cee-9fe4-4764-a3c2-aec16e709d4c
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type or &#39;With&#39; expected
When you declare an instance of a class, the `New` keyword must be followed by a type name or by `With`. For example, the following statements each declare `client` to be an instance of the `Customer` class. The type name `Customer` follows `New`.  
  
```  
' Dim client As New Customer()  
' The next declaration uses an object initializer.  
Dim client As New Customer() With {.Name = "Litware, Inc."}  
```  
  
 Beginning with [!INCLUDE[vb_orcas_long](../vs140/includes/vb_orcas_long_md.md)], you can declare an object to be an instance of an anonymous type, in which case you do not specify a data type. In anonymous type declarations, the keyword `With` follows `New`.  
  
```  
Dim person = New With {.Name ="Mike Nash", .Age = 27}  
```  
  
 **Error ID:** BC30988  
  
### To correct this error  
  
-   Change the declaration so that `With` or a type name follows `New`.  
  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [Object Initializer](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)   
 [NotInBuild:Declaration Statements in Visual Basic](assetId:///81f3c398-f45c-4d95-80bf-aa39d1a0fb30)