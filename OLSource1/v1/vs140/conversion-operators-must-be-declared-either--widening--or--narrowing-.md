---
title: "Conversion operators must be declared either &#39;Widening&#39; or &#39;Narrowing&#39;"
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
  - "vbc33017"
  - "bc33017"
helpviewer_keywords: 
  - "BC33017"
ms.assetid: 5972d955-ce1d-4348-a021-167eecb3a507
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversion operators must be declared either &#39;Widening&#39; or &#39;Narrowing&#39;
An [Operator Statement](../vs140/operator-statement.md) does not specify either [Widening](../vs140/widening--visual-basic-.md) or [Narrowing](../vs140/narrowing--visual-basic-.md).  
  
 When you define a conversion operator, you must declare it as either <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. These are mutually exclusive characteristics, so you cannot specify both.  
  
 **Error ID:** BC33017  
  
### To correct this error  
  
-   Decide whether the conversion operator is to be <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and include the appropriate keyword in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. You must specify one or the other.  
  
## See Also  
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)