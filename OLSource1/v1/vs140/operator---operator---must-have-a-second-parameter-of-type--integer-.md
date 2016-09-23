---
title: "Operator &#39;&lt;operator&gt;&#39; must have a second parameter of type &#39;Integer&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - BC33041
  - vbc33041
helpviewer_keywords: 
  - BC33041
ms.assetid: 5cd56f6d-2f0f-49de-a8e6-59bdb57bdb1d
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operator &#39;&lt;operator&gt;&#39; must have a second parameter of type &#39;Integer&#39;
A bit-shift operator is declared with the second parameter of a type other than `Integer`.  
  
 When you use the right shift (`>>`) or left shift (`<<`) operator in an expression, you specify the shift amount in the second operand. For this operand, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] allows you to supply any data type that widens to `Integer`. However, the definition of the second operand is strictly `Integer`. If you define a class or structure with a bit-shift operator on that class or structure, your definition must specify `Integer` for the second operand.  
  
 **Error ID:** BC33041  
  
### To correct this error  
  
-   Change the definition of the bit-shift operator to return an `Integer` value.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Bit Shift Operators](../vs140/bit-shift-operators--visual-basic-.md)