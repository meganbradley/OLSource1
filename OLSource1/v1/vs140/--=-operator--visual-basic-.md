---
title: "&gt;&gt;= Operator (Visual Basic)"
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
  - "vb.>>="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "assignment statements, compound"
  - "statements [Visual Basic], compound assignment"
  - "operator >>= [Visual Basic]"
  - "compound assignment statements"
  - ">>= operator [Visual Basic]"
ms.assetid: 2bcd9abb-7a8c-4229-b75d-8816ff1dc700
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &gt;&gt;= Operator (Visual Basic)
Performs an arithmetic right shift on the value of a variable or property and assigns the result back to the variable or property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Variable or property of an integral type (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Required. Numeric expression of a data type that widens to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The element on the left side of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md).  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator first performs an arithmetic right shift on the value of the variable or property. The operator then assigns the result of that operation back to the variable or property.  
  
 Arithmetic shifts are not circular, which means the bits shifted off one end of the result are not reintroduced at the other end. In an arithmetic right shift, the bits shifted beyond the rightmost bit position are discarded, and the leftmost bit is propagated into the bit positions vacated at the left. This means that if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> has a negative value, the vacated positions are set to one. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is positive, or if its data type is an unsigned type, the vacated positions are set to zero.  
  
## Overloading  
 The [>> Operator](../vs140/---operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> operator affects the behavior of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operator. If your code uses <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> on a class or structure that overloads <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator to shift the bit pattern of an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> variable right by the specified amount and assign the result to the variable.  
  
 [!code[VbVbalrOperators#15](../vs140/codesnippet/VisualBasic/--=-operator--visual-basic-_1.vb)]  
  
## See Also  
 [>> Operator](../vs140/---operator--visual-basic-.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Bit Shift Operators](../vs140/bit-shift-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)