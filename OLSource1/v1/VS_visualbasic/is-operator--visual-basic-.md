---
title: "Is Operator (Visual Basic)"
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
  - "vb.is"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "comparison operators"
  - "equivalent objects"
  - "TypeOf...Is expression"
  - "Is operator [Visual Basic]"
ms.assetid: 8045a6c8-2a83-45b6-ad47-d09a704c656d
caps.latest.revision: 12
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
# Is Operator (Visual Basic)
Compares two object reference variables.  
  
## Syntax  
  
```  
  
result = object1 Is object2  
```  
  
## Parts  
 `result`  
 Required. Any `Boolean` value.  
  
 `object1`  
 Required. Any `Object` name.  
  
 `object2`  
 Required. Any `Object` name.  
  
## Remarks  
 The `Is` operator determines if two object references refer to the same object. However, it does not perform value comparisons. If `object1` and `object2` both refer to the exact same object instance, `result` is `True`; if they do not, `result` is `False`.  
  
 `Is` can also be used with the `TypeOf` keyword to make a `TypeOf`...`Is` expression, which tests whether an object variable is compatible with a data type.  
  
> [!NOTE]
>  The `Is` keyword is also used in the [Select...Case Statement](../VS_visualbasic/select...case-statement--visual-basic-.md).  
  
## Example  
 The following example uses the `Is` operator to compare pairs of object references. The results are assigned to a `Boolean` value representing whether the two objects are identical.  
  
 [!code[VbVbalrOperators#27](../VS_visualbasic/codesnippet/VisualBasic/is-operator--visual-basic-_1.vb)]  
  
 As the preceding example demonstrates, you can use the `Is` operator to test both early bound and late bound objects.  
  
## See Also  
 [TypeOf Operator](../VS_visualbasic/typeof-operator--visual-basic-.md)   
 [IsNot Operator](../VS_visualbasic/isnot-operator--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../VS_visualbasic/comparison-operators-in-visual-basic.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Operators and Expressions](../VS_visualbasic/operators-and-expressions-in-visual-basic.md)