---
title: "IsNot Operator (Visual Basic)"
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
  - "vb.isnot"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "IsNot operator"
ms.assetid: 8dd2bcdb-0166-48a2-9094-60dfb448f36c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IsNot Operator (Visual Basic)
Compares two object reference variables.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable or expression.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable or expression.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator determines if two object references refer to different objects. However, it does not perform value comparisons. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> both refer to the exact same object instance, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; if they do not, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the opposite of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator. The advantage of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is that you can avoid awkward syntax with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, which can be difficult to read.  
  
 You can use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operators to test both early-bound and late-bound objects.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator cannot be used to compare expressions returned from the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operator. Instead, you must use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> operators.  
  
## Example  
 The following code example uses both the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operator and the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> operator to accomplish the same comparison.  
  
 [!code[VbVbalrOperators#29](../vs140/codesnippet/VisualBasic/isnot-operator--visual-basic-_1.vb)]  
  
## See Also  
 [Is Operator](../vs140/is-operator--visual-basic-.md)   
 [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [How to: Test Whether Two Objects Are the Same](../vs140/how-to--test-whether-two-objects-are-the-same--visual-basic-.md)