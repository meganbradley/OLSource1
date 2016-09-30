---
title: "Compiler Error CS0838"
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
  - "CS0838"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0838"
ms.assetid: 22495e47-3331-42ef-921c-f76ff03ef1f7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0838
An expression tree may not contain a multidimensional array initializer.  
  
 Multidimensional arrays in expression trees cannot be initialized by using an array initializer.  
  
### To correct this error  
  
1.  Create and initialize the array before creating the expression tree.  
  
## Example  
 The following example generates CS0838:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)