---
title: "IsNot Operator (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 13
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
# IsNot Operator (Visual Basic)
Compares two object reference variables.  
  
## Syntax  
  
```  
  
result = object1 IsNot object2  
```  
  
## Parts  
 `result`  
 Required. A `Boolean` value.  
  
 `object1`  
 Required. Any `Object` variable or expression.  
  
 `object2`  
 Required. Any `Object` variable or expression.  
  
## Remarks  
 The `IsNot` operator determines if two object references refer to different objects. However, it does not perform value comparisons. If `object1` and `object2` both refer to the exact same object instance, `result` is `False`; if they do not, `result` is `True`.  
  
 `IsNot` is the opposite of the `Is` operator. The advantage of `IsNot` is that you can avoid awkward syntax with `Not` and `Is`, which can be difficult to read.  
  
 You can use the `Is` and `IsNot` operators to test both early-bound and late-bound objects.  
  
> [!NOTE]
>  The `IsNot` operator cannot be used to compare expressions returned from the `TypeOf` operator. Instead, you must use the `Not` and `Is` operators.  
  
## Example  
 The following code example uses both the `Is` operator and the `IsNot` operator to accomplish the same comparison.  
  
 [!code[VbVbalrOperators#29](../VS_visualbasic/codesnippet/VisualBasic/isnot-operator--visual-basic-_1.vb)]  
  
## See Also  
 [Is Operator](../VS_visualbasic/is-operator--visual-basic-.md)   
 [TypeOf Operator](../VS_visualbasic/typeof-operator--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [How to: Test Whether Two Objects Are the Same](../VS_visualbasic/how-to--test-whether-two-objects-are-the-same--visual-basic-.md)