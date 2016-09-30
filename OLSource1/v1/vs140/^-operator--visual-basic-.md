---
title: "^ Operator (Visual Basic)"
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
  - "vb.^"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "raising numbers to powers"
  - "^ operator [Visual Basic], exponention"
  - "square operator"
  - "^ operator [Visual Basic]"
  - "exponentiation operator [Visual Basic]"
  - "exponent"
  - "numbers, rasing"
  - "powers"
  - "arithmetic operators, exponentiation"
ms.assetid: d89a1ca8-83da-4784-a87b-a9d7dceb3f62
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ^ Operator (Visual Basic)
Raises a number to the power of another number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any numeric expression.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Any numeric expression.  
  
## Result  
 The result is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> raised to the power of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, always as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value.  
  
## Supported Types  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Operands of any different type are converted to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 Visual Basic always performs exponentiation in the [Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md).  
  
 The value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be fractional, negative, or both.  
  
 When more than one exponentiation is performed in a single expression, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator is evaluated as it is encountered from left to right.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator to raise a number to the power of an exponent. The result is the first operand raised to the power of the second.  
  
 [!code[VbVbalrOperators#20](../vs140/codesnippet/VisualBasic/^-operator--visual-basic-_1.vb)]  
  
 The preceding example produces the following results:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to 4 (2 squared).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set to 19683 (3 cubed, then that value cubed).  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to -125 (-5 cubed).  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to 625 (-5 to the fourth power).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to 2 (cube root of 8).  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to 0.5 (1.0 divided by the cube root of 8).  
  
 Note the importance of the parentheses in the expressions in the preceding example. Because of *operator precedence*, Visual Basic normally performs the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operator before any others, even the unary <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> had been calculated without parentheses, they would have produced the following results:  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> would be calculated as –(5 to the fourth power), which would result in -625.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> would be calculated as (8 to the –1 power, or 0.125) divided by 3.0, which would result in 0.041666666666666666666666666666667.  
  
## See Also  
 [^= Operator](../vs140/^=-operator--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)