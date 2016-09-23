---
title: "&#39;{&#39; expected"
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
  - vbc30987
  - bc30987
helpviewer_keywords: 
  - BC30987
ms.assetid: 3d1552b6-338a-47cf-84d5-77b59209e0d3
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;{&#39; expected
To declare an instance of a named or anonymous type by using an object initializer, you must enclose the list of fields or properties and their initial values in braces ({ and }).  
  
```  
Dim client As New Customer() With {.Name = "Microsoft", .City = "Seattle"}  
Dim emp = New Employee() With {.Name = "Rob Young", .ID = 55555}  
Dim anon = New With {.ID = 123456}  
```  
  
 **Error ID:** BC30987  
  
### To correct this error  
  
-   Include an initialization list after `With`, enclosed in braces.  
  
## See Also  
 [Object Initializer](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [NOT IN BUILD: Property Procedures vs. Fields](assetId:///da1c05c1-87c7-40fa-b92c-e9c7e4d170f7)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)