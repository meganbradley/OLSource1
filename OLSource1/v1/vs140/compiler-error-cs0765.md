---
title: "Compiler Error CS0765"
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
  - "CS0765"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0765"
ms.assetid: adfb1f95-f7b1-4e43-83c2-42e8531eb980
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0765
Partial methods with only a defining declaration or removed conditional methods cannot be used in expression trees  
  
 Although a call to a removed partial method is an expression, it is not an acceptable expression in an expression tree.  
  
### To correct this error  
  
1.  Add an implementing declaration for the partial method, or remove the code that is causing the conditional method to be excluded from compilation.  
  
## Example  
 The following code generates CS0765 in two locations:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)   
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)