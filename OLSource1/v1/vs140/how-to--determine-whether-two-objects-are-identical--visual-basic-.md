---
title: "How to: Determine Whether Two Objects Are Identical (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "testing, objects"
  - "objects [Visual Basic], comparing"
  - "object variables, determining identity"
ms.assetid: 7829f817-0d1f-4749-a707-de0b95e0cf5c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Determine Whether Two Objects Are Identical (Visual Basic)
In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], two variable references are considered identical if their pointers are the same, that is, if both variables point to the same class instance in memory. For example, in a Windows Forms application, you might want to make a comparison to determine whether the current instance (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) is the same as a particular instance, such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides two operators to compare pointers. The [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md) returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the objects are identical, and the [IsNot Operator](../vs140/isnot-operator--visual-basic-.md) returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if they are not.  
  
## Determining if Two Objects Are Identical  
  
#### To determine if two objects are identical  
  
1.  Set up a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> expression to test the two objects.  
  
2.  In your testing expression, use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator with the two objects as operands.  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the objects point to the same class instance.  
  
## Determining if Two Objects Are Not Identical  
 Sometimes you want to perform an action if the two objects are not identical, and it can be awkward to combine <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. In such a case you can use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator.  
  
#### To determine if two objects are not identical  
  
1.  Set up a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> expression to test the two objects.  
  
2.  In your testing expression, use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator with the two objects as operands.  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the objects do not point to the same class instance.  
  
## Example  
 The following example tests pairs of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variables to see if they point to the same class instance.  
  
 [!code[VbVbalrKeywords#14](../vs140/codesnippet/VisualBasic/how-to--determine-whether-two-objects-are-identical--visual-basic-_1.vb)]  
  
 The preceding example displays the following output.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## See Also  
 [Object Data Type](../vs140/object-data-type.md)   
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Values](../vs140/object-variable-values--visual-basic-.md)   
 [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Related](../vs140/how-to--determine-whether-two-objects-are-related--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)