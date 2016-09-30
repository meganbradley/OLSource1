---
title: "- Operator (Visual Basic)1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "- Operator (Visual Basic)"
f1_keywords: 
  - "vb.Negate"
  - "vb.-"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "- operator [Visual Basic]"
  - "operators [Visual Basic], subtraction"
  - "operators [Visual Basic], difference"
  - "negation operator"
  - "operators [Visual Basic], arithmetic"
  - "subtraction operator, syntax"
  - "arithmetic operators, subtraction"
  - "difference operator"
  - "math operators"
  - "operators [Visual Basic], negation"
  - "minus operator [Visual Basic]"
ms.assetid: bff2c368-662d-4c92-ac87-1d9bdfd3426a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# - Operator (Visual Basic)1
Returns the difference between two numeric expressions or the negative value of a numeric expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any numeric expression.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required unless the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator is calculating a negative value. Any numeric expression.  
  
## Result  
 The result is the difference between <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or the negated value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The result data type is a numeric type appropriate for the data types of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. See the "Integer Arithmetic" tables in [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md).  
  
## Supported Types  
 All numeric types. This includes the unsigned and floating-point types and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 In the first usage shown in the syntax shown previously, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operator is the *binary* arithmetic subtraction operator for the difference between two numeric expressions.  
  
 In the second usage shown in the syntax shown previously, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator is the *unary* negation operator for the negative value of an expression. In this sense, the negation consists of reversing the sign of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> so that the result is positive if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is negative.  
  
 If either expression evaluates to [Nothing](../vs140/nothing--visual-basic-.md), the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operator treats it as zero.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, make sure that you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> operator to calculate and return the difference between two numbers, and then to negate a number.  
  
 [!code[VbVbalrOperators#10](../vs140/codesnippet/VisualBasic/--operator--visual-basic-1_1.vb)]  
  
 Following the execution of these statements, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> contains 124.45 and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> contains –334.90.  
  
## See Also  
 [-= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-2.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)