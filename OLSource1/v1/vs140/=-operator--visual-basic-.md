---
title: "= Operator (Visual Basic)"
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
  - "vb.Assign"
  - "vb.="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "= operator [Visual Basic]"
  - "= assignment statements [Visual Basic]"
ms.assetid: 2dac2e49-86c8-42f8-80c1-458452fb5e29
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# = Operator (Visual Basic)
Assigns a value to a variable or property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Any writable variable or any property.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Any literal, constant, or expression.  
  
## Remarks  
 The element on the left side of the equal sign (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md). The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator assigns the value on its right to the variable or property on its left.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator is also used as a comparison operator. For details, see [Comparison Operators (Visual Basic)](../vs140/comparison-operators--visual-basic-.md).  
  
## Overloading  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator can be overloaded only as a relational comparison operator, not as an assignment operator. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example demonstrates the assignment operator. The value on the right is assigned to the variable on the left.  
  
 [!code[VbVbalrOperators#9](../vs140/codesnippet/VisualBasic/=-operator--visual-basic-_1.vb)]  
  
## See Also  
 [&= Operator](../vs140/-=-operator--visual-basic-.md)   
 [*= Operator](../vs140/-=-operator--visual-basic-.md)   
 [+= Operator](../vs140/-=-operator--visual-basic-.md)   
 [-= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-2.md)   
 [/= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-1.md)   
 [\\= Operator](../vs140/-=-operator.md)   
 [^= Operator](../vs140/^=-operator--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)   
 [Comparison Operators (Visual Basic)](../vs140/comparison-operators--visual-basic-.md)   
 [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)