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
  
```  
  
variableorproperty = value  
```  
  
## Parts  
 `variableorproperty`  
 Any writable variable or any property.  
  
 `value`  
 Any literal, constant, or expression.  
  
## Remarks  
 The element on the left side of the equal sign (`=`) can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../VS_csharp/readonly--visual-basic-.md). The `=` operator assigns the value on its right to the variable or property on its left.  
  
> [!NOTE]
>  The `=` operator is also used as a comparison operator. For details, see [Comparison Operators (Visual Basic)](../VS_csharp/comparison-operators--visual-basic-.md).  
  
## Overloading  
 The `=` operator can be overloaded only as a relational comparison operator, not as an assignment operator. For more information, see [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example demonstrates the assignment operator. The value on the right is assigned to the variable on the left.  
  
 [!code[VbVbalrOperators#9](../VS_csharp/codesnippet/VisualBasic/=-operator--visual-basic-_1.vb)]  
  
## See Also  
 [&= Operator](../VS_csharp/-=-operator--visual-basic-.md)   
 [*= Operator](../VS_csharp/-=-operator--visual-basic-.md)   
 [+= Operator](../VS_csharp/-=-operator--visual-basic-.md)   
 [-= Operator (Visual Basic)](../VS_csharp/-=-operator--visual-basic-2.md)   
 [/= Operator (Visual Basic)](../VS_csharp/-=-operator--visual-basic-1.md)   
 [\\= Operator](../VS_csharp/-=-operator.md)   
 [^= Operator](../VS_csharp/^=-operator--visual-basic-.md)   
 [Statements in Visual Basic](../VS_csharp/statements-in-visual-basic.md)   
 [Comparison Operators (Visual Basic)](../VS_csharp/comparison-operators--visual-basic-.md)   
 [ReadOnly (Visual Basic)](../VS_csharp/readonly--visual-basic-.md)   
 [Local Type Inference](../VS_csharp/local-type-inference--visual-basic-.md)