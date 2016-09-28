---
title: "Arrays of type &#39;System.Void&#39; are not allowed in this expression"
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
  - "vbc31428"
  - "bc31428"
helpviewer_keywords: 
  - "BC31428"
ms.assetid: 21d77b56-585f-4107-b7ec-21933ba58017
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arrays of type &#39;System.Void&#39; are not allowed in this expression
An expression in an assignment statement or a declaration specifies an array of type <xref:System.Void*>.  
  
 The <xref:System.Void*> structure is a specialized type used internally by the .NET Framework and particularly by Visual C# and Visual C++. It represents a return value type for a method that does not return a value. Visual Basic uses a `Sub` procedure when a value is not returned and a `Function` procedure when a value is returned.  
  
 Arrays of type <xref:System.Void*> are not meaningful and are not allowed in any context.  
  
 **Error ID:** BC31428  
  
### To correct this error  
  
1.  Remove the parentheses that designate an array.  
  
2.  Unless you have a particular reason to compare a run-time type to <xref:System.Void*>, remove the reference to it altogether.  
  
## See Also  
 <xref:System.Void*>