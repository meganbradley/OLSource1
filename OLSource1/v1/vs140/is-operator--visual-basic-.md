---
title: "Is Operator (Visual Basic)"
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
  - "vb.is"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "comparison operators"
  - "equivalent objects"
  - "TypeOf...Is expression"
  - "Is operator [Visual Basic]"
ms.assetid: 8045a6c8-2a83-45b6-ad47-d09a704c656d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Is Operator (Visual Basic)
Compares two object reference variables.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> name.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> name.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator determines if two object references refer to the same object. However, it does not perform value comparisons. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> both refer to the exact same object instance, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; if they do not, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can also be used with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword to make a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> expression, which tests whether an object variable is compatible with a data type.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword is also used in the [Select...Case Statement (Visual Basic)](../vs140/select...case-statement--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator to compare pairs of object references. The results are assigned to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value representing whether the two objects are identical.  
  
 [!code[VbVbalrOperators#27](../vs140/codesnippet/VisualBasic/is-operator--visual-basic-_1.vb)]  
  
 As the preceding example demonstrates, you can use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator to test both early bound and late bound objects.  
  
## See Also  
 [TypeOf Operator](../vs140/typeof-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Operators and Expressions](../vs140/operators-and-expressions-in-visual-basic.md)