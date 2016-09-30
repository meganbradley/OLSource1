---
title: "First operand in a binary &#39;If&#39; expression must be nullable or a reference type"
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
  - "bc33107"
  - "vbc33107"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC33107"
ms.assetid: 493c8899-3f6b-4471-8eb6-9284e8492768
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# First operand in a binary &#39;If&#39; expression must be nullable or a reference type
An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression can take either two or three arguments. When you send only two arguments, the first argument must be a reference type or a nullable type. If the first argument evaluates to anything other than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, its value is returned. If the first argument evaluates to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the second argument is evaluated and returned.  
  
 For example, the following code contains two <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expressions, one with three arguments and one with two arguments. The expressions calculate and return the same value.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following expressions cause this error:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Error ID:** BC33107  
  
### To correct this error  
  
-   If you cannot change the code so that the first argument is a nullable type or reference type, consider converting to a three-argument <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression, or to an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [If Operator](../vs140/if-operator--visual-basic-.md)   
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)   
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)