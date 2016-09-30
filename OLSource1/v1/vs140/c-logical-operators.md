---
title: "C Logical Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "logical operators, expression sequence points"
  - "logical operators, C"
  - "logical AND operator"
  - "|| operator"
  - "operators [C], logical"
  - "short-circuit evaluation"
  - "&& operator"
  - "logical OR operator"
ms.assetid: c0a4e766-ad56-4300-bf76-b28dc0e19b43
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Logical Operators
The logical operators perform logical-AND (**&&**) and logical-OR ( <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> ) operations.  
  
 **Syntax**  
  
 *logical-AND-expression*:  
 *inclusive-OR-expression*  
  
 *logical-AND-expression*  **&&**  *inclusive-OR-expression*  
  
 *logical-OR-expression*:  
 *logical-AND-expression*  
  
 *logical-OR-expression*  **&#124;&#124;**  *logical-AND-expression*  
  
 Logical operators do not perform the usual arithmetic conversions. Instead, they evaluate each operand in terms of its equivalence to 0. The result of a logical operation is either 0 or 1. The result's type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The C logical operators are described below:  
  
|Operator|Description|  
|--------------|-----------------|  
|**&&**|The logical-AND operator produces the value 1 if both operands have nonzero values. If either operand is equal to 0, the result is 0. If the first operand of a logical-AND operation is equal to 0, the second operand is not evaluated.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The logical-OR operator performs an inclusive-OR operation on its operands. The result is 0 if both operands have 0 values. If either operand has a nonzero value, the result is 1. If the first operand of a logical-OR operation has a nonzero value, the second operand is not evaluated.|  
  
 The operands of logical-AND and logical-OR expressions are evaluated from left to right. If the value of the first operand is sufficient to determine the result of the operation, the second operand is not evaluated. This is called "short-circuit evaluation." There is a sequence point after the first operand. See [Sequence Points](../vs140/c-sequence-points.md) for more information.  
  
## Examples  
 The following examples illustrate the logical operators:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is called to print a message if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the second operand (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) is not evaluated and nothing is printed. Note that this could cause problems in cases where the second operand has side effects that are being relied on for some other reason.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is equal to either <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the second argument to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function evaluates to true and the value 1 is printed. Otherwise, it evaluates to false and the value 0 is printed. As soon as one of the conditions evaluates to true, evaluation ceases.  
  
## See Also  
 [Logical AND Operator: &&](../vs140/logical-and-operator----.md)   
 [Logical OR Operator: &#124;&#124;](../vs140/logical-or-operator----.md)