---
title: "&amp;= Operator (Visual Basic)"
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
  - "vb.&="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operator &="
  - "assignment statements, compound"
  - "statements [Visual Basic], compound assignment"
  - "&= operator [Visual Basic]"
  - "compound assignment statements"
ms.assetid: 0cf262fc-1a05-419a-a503-60013f111c8a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &amp;= Operator (Visual Basic)
Concatenates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expression to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variable or property and assigns the result to the variable or property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable or property.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expression.  
  
## Remarks  
 The element on the left side of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md). The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator concatenates the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression on its right to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable or property on its left, and assigns the result to the variable or property on its left.  
  
## Overloading  
 The [& Operator](../vs140/--operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator affects the behavior of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator. If your code uses <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on a class or structure that overloads <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator to concatenate two <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variables and assign the result to the first variable.  
  
 [!code[VbVbalrOperators#3](../vs140/codesnippet/VisualBasic/-=-operator--visual-basic-_1.vb)]  
  
## See Also  
 [& Operator](../vs140/--operator--visual-basic-.md)   
 [+= Operator](../vs140/-=-operator--visual-basic-.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Concatenation Operators](../vs140/concatenation-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)