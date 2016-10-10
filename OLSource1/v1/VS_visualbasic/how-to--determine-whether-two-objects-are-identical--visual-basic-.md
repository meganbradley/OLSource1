---
title: "How to: Determine Whether Two Objects Are Identical (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Determine Whether Two Objects Are Identical (Visual Basic)
In [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)], two variable references are considered identical if their pointers are the same, that is, if both variables point to the same class instance in memory. For example, in a Windows Forms application, you might want to make a comparison to determine whether the current instance (`Me`) is the same as a particular instance, such as `Form2`.  
  
 [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] provides two operators to compare pointers. The [Is Operator](../VS_visualbasic/is-operator--visual-basic-.md) returns `True` if the objects are identical, and the [IsNot Operator](../VS_visualbasic/isnot-operator--visual-basic-.md) returns `True` if they are not.  
  
## Determining if Two Objects Are Identical  
  
#### To determine if two objects are identical  
  
1.  Set up a `Boolean` expression to test the two objects.  
  
2.  In your testing expression, use the `Is` operator with the two objects as operands.  
  
     `Is` returns `True` if the objects point to the same class instance.  
  
## Determining if Two Objects Are Not Identical  
 Sometimes you want to perform an action if the two objects are not identical, and it can be awkward to combine `Not` and `Is`, for example `If Not obj1 Is obj2`. In such a case you can use the `IsNot` operator.  
  
#### To determine if two objects are not identical  
  
1.  Set up a `Boolean` expression to test the two objects.  
  
2.  In your testing expression, use the `IsNot` operator with the two objects as operands.  
  
     `IsNot` returns `True` if the objects do not point to the same class instance.  
  
## Example  
 The following example tests pairs of `Object` variables to see if they point to the same class instance.  
  
 [!code[VbVbalrKeywords#14](../VS_visualbasic/codesnippet/VisualBasic/how-to--determine-whether-two-objects-are-identical--visual-basic-_1.vb)]  
  
 The preceding example displays the following output.  
  
 `objA different from objB? True`  
  
 `objA identical to objC? True`  
  
## See Also  
 [Object Data Type](../VS_visualbasic/object-data-type.md)   
 [Object Variables](../VS_visualbasic/object-variables-in-visual-basic.md)   
 [Object Variable Values](../VS_visualbasic/object-variable-values--visual-basic-.md)   
 [Is Operator](../VS_visualbasic/is-operator--visual-basic-.md)   
 [IsNot Operator](../VS_visualbasic/isnot-operator--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Related](../VS_visualbasic/how-to--determine-whether-two-objects-are-related--visual-basic-.md)   
 [Me, My, MyBase, and MyClass](../VS_visualbasic/me--my--mybase--and-myclass-in-visual-basic.md)