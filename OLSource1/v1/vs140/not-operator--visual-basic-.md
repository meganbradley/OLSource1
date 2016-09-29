---
title: "Not Operator (Visual Basic)"
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
  - "vb.Not"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Boolean expressions, negating"
  - "operators [Visual Basic], bitwise"
  - "negation operator"
  - "inverse bit values in variables"
  - "bitwise operators, NOT operator"
  - "bitwise comparison"
  - "Not operator [Visual Basic]"
  - "logical negation"
  - "operators [Visual Basic], negation"
ms.assetid: 8f2ea83c-d2ed-480a-a474-3042a1cad9b5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Not Operator (Visual Basic)
Performs logical negation on a `Boolean` expression, or bitwise negation on a numeric expression.  
  
## Syntax  
  
```  
  
result = Not expression  
```  
  
## Parts  
 `result`  
 Required. Any `Boolean` or numeric expression.  
  
 `expression`  
 Required. Any `Boolean` or numeric expression.  
  
## Remarks  
 For `Boolean` expressions, the following table illustrates how `result` is determined.  
  
|If `expression` is|The value of `result` is|  
|------------------------|------------------------------|  
|`True`|`False`|  
|`False`|`True`|  
  
 For numeric expressions, the `Not` operator inverts the bit values of any numeric expression and sets the corresponding bit in `result` according to the following table.  
  
|If bit in `expression` is|The bit in `result` is|  
|-------------------------------|----------------------------|  
|1|0|  
|0|1|  
  
> [!NOTE]
>  Since the logical and bitwise operators have a lower precedence than other arithmetic and relational operators, any bitwise operations should be enclosed in parentheses to ensure accurate execution.  
  
## Data Types  
 For a Boolean negation, the data type of the result is `Boolean`. For a bitwise negation, the result data type is the same as that of `expression`. However, if expression is `Decimal`, the result is `Long`.  
  
## Overloading  
 The `Not` operator can be *overloaded*, which means that a class or structure can redefine its behavior when its operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `Not` operator to perform logical negation on a `Boolean` expression. The result is a `Boolean` value that represents the reverse of the value of the expression.  
  
 [!code[VbVbalrOperators#33](../vs140/codesnippet/VisualBasic/not-operator--visual-basic-_1.vb)]  
  
 The preceding example produces results of `False` and `True`, respectively.  
  
## Example  
 The following example uses the `Not` operator to perform logical negation of the individual bits of a numeric expression. The bit in the result pattern is set to the reverse of the corresponding bit in the operand pattern, including the sign bit.  
  
 [!code[VbVbalrOperators#34](../vs140/codesnippet/VisualBasic/not-operator--visual-basic-_2.vb)]  
  
 The preceding example produces results of –11, –9, and –7, respectively.  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)