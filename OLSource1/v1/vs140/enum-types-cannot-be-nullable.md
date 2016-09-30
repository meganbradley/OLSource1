---
title: "Enum types cannot be nullable"
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
  - "vbc32129"
  - "bc32129"
helpviewer_keywords: 
  - "BC32129"
ms.assetid: 9e0fe5c9-72c7-4905-b177-d00cc3469ea9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enum types cannot be nullable
The underlying type that is used to declare an enumeration cannot be nullable. For example, the following code causes this error:  
  
```vb#  
'' Not valid.  
' Enum exampleEnum As Integer?  
'     Member declarations.  
' End Enum  
```  
  
 **Error ID:** BC32129  
  
### To correct this error  
  
-   Do not use a nullable underlying type in an `Enum` declaration.  
  
## See Also  
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)   
 [Enum Statement](../vs140/enum-statement--visual-basic-.md)