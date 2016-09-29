---
title: "&#39;Is&#39; requires operands that have reference types, but this operand has the value type &#39;&lt;typename&gt;&#39;"
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
  - "bc30020"
  - "vbc30020"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30020"
ms.assetid: 228afebd-1203-4bd3-8d7a-c5c56f3cedc4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Is&#39; requires operands that have reference types, but this operand has the value type &#39;&lt;typename&gt;&#39;
The `Is` comparison operator determines whether two object variables refer to the same instance. This comparison is not defined for value types.  
  
 **Error ID:** BC30020  
  
### To correct this error  
  
-   Use the appropriate arithmetic comparison operator or the `Like` operator to compare two value types.  
  
## See Also  
 [Is Operator](../VS_csharp/is-operator--visual-basic-.md)   
 [Like Operator](../VS_csharp/like-operator--visual-basic-.md)   
 [Comparison Operators](../VS_csharp/comparison-operators--visual-basic-.md)