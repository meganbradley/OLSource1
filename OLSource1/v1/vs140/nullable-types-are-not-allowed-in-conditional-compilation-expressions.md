---
title: "Nullable types are not allowed in conditional compilation expressions"
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
  - "bc33111"
  - "vbc33111"
helpviewer_keywords: 
  - "BC33111"
ms.assetid: 2c2587e5-2179-4a31-bcf7-7004db6f2d73
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable types are not allowed in conditional compilation expressions
A nullable type cannot be used in the expression of a conditional compilation directive. For example, the following code causes this error.  
  
```vb#  
'#Const triggerPoint = 0  
  
'' Not valid.  
'#If CType(triggerpoint, Boolean?) = True Then  
'        ' Body of the conditional directive.  
'#End If  
```  
  
 **Error ID:** BC33111  
  
### To correct this error  
  
-   Remove the nullable type designation.  
  
## See Also  
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)   
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)   
 [Conditional Compilation Overview](../vs140/conditional-compilation-in-visual-basic.md)