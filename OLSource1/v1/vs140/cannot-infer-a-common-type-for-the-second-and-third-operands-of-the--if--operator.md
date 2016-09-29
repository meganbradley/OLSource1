---
title: "Cannot infer a common type for the second and third operands of the &#39;If&#39; operator"
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
  - "vbc33106"
  - "bc33106"
helpviewer_keywords: 
  - "BC33106"
ms.assetid: 793eed88-a9f9-43e3-b657-c16795ecbbcc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot infer a common type for the second and third operands of the &#39;If&#39; operator
Cannot infer a common type for the second and third operands of the 'If' operator. One must have a widening conversion to the other.  
  
 When the `If` operator is called with three arguments, there must be a widening conversion between the second and third arguments. For example, because there is not a widening conversion in either direction between `Integer` and `String`, the following code causes this error.  
  
```vb#  
Dim divisor = 3  
' Not valid.  
' Console.WriteLine(If(divisor <> 0, number \ divisor, "Division by zero"))  
```  
  
 **Error ID:** BC33106  
  
### To correct this error  
  
-   Provide an explicit conversion for one of the operands, if that is possible in your code.  
  
-   Use a different condition construction, such as an `If...Then...Else` statement.  
  
## See Also  
 [If Operator](../vs140/if-operator--visual-basic-.md)   
 [If...Then...Else Statement (Visual Basic)](../vs140/if...then...else-statement--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)