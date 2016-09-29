---
title: "Late binding operations cannot be converted to an expression tree"
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
  - "vbc36604"
  - "bc36604"
helpviewer_keywords: 
  - "BC36604"
ms.assetid: 6fd66d12-8c99-46e0-9095-fe1b29fd2692
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Late binding operations cannot be converted to an expression tree
An attempt has been made to convert a late binding operation into an expression tree. This is not valid. For example, the following code causes this error.  
  
```vb#  
Option Strict Off  
Module Module1  
  
    Sub Main()  
        '' Not valid.  
        ' Test(Function(someInstance) someInstance.SomeProperty)  
    End Sub  
  
    Sub Test(ByVal ex As Expressions.Expression(Of Func(Of Object, Object)))  
    End Sub  
  
End Module  
```  
  
 **Error ID:** BC36604  
  
## See Also  
 [Early and Late Binding](../vs140/early-and-late-binding--visual-basic-.md)   
 [NOT IN BUILD: Expression Trees in LINQ](assetId:///1a2e8e74-4bbc-45ab-9a46-2b6cfce3bcb2)