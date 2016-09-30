---
title: "Option Strict On disallows operands of type Object for operator &#39;&lt;operatorname&gt;&#39;"
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
  - "bc32013"
  - "vbc32013"
helpviewer_keywords: 
  - "BC32013"
ms.assetid: cd197da8-2676-453b-884b-3231fb6f909d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict On disallows operands of type Object for operator &#39;&lt;operatorname&gt;&#39;
Option Strict On disallows operands of type Object for operator '\<operatorname>'. Use the Is operator to test for object identity.  
  
 An arithmetic comparison operator such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is used with one or more object variables when <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 **Error ID:** BC32013  
  
### To correct this error  
  
1.  Turn <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the object variables contain numeric values and you intend an arithmetic comparison.  
  
2.  Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator to compare for object identity.  
  
## See Also  
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)   
 [Is Operator](../vs140/is-operator--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)