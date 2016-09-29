---
title: "Attributes cannot be applied to parameters of lambda expressions"
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
  - "vbc36634"
  - "bc36634"
helpviewer_keywords: 
  - "BC36634"
ms.assetid: ed751d8d-11b7-4210-97e0-0319edff8c34
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attributes cannot be applied to parameters of lambda expressions
You have applied an attribute to a parameter in a lambda expression definition, which is not supported. The following code causes this error.  
  
```vb#  
Sub LambaAttribute()  
    ' Not valid.  
    Dim add1 = _  
    Function(<System.Runtime.InteropServices.InAttribute()> m As Integer) _  
                   m + 1  
End Sub  
```  
  
 **Error ID:** BC36634  
  
### To correct this error  
  
-   Remove the attribute, or consider revising your code by changing the lambda expression to a regular function.  
  
## See Also  
 <xref:System.Runtime.InteropServices.InAttribute*>   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [NOT IN BUILD: Attributes in Visual Basic](assetId:///620bfc0e-4582-4c8b-8432-ebc5c3dccc22)