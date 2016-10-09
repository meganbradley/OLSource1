---
title: "TypeOf Operator (Visual Basic)"
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
  - "TypeOf"
  - "vb.TypeOf"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "types [Visual Basic], compatible"
  - "comparison operators"
  - "TypeOf...Is expression"
  - "data types [Visual Basic], compatible"
  - "TypeOf operator [Visual Basic]"
  - "compatible data types"
ms.assetid: 33f65296-659a-4b9a-9a29-c2a91cff68b2
caps.latest.revision: 11
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
# TypeOf Operator (Visual Basic)
Compares an object reference variable to a data type.  
  
## Syntax  
  
```  
  
result = TypeOf objectexpression Is typename  
```  
  
```  
  
result = TypeOf objectexpression IsNot typename  
```  
  
## Parts  
 `result`  
 Returned. A `Boolean` value.  
  
 `objectexpression`  
 Required. Any expression that evaluates to a reference type.  
  
 `typename`  
 Required. Any data type name.  
  
## Remarks  
 The `TypeOf` operator determines whether the run-time type of `objectexpression` is compatible with `typename`. The compatibility depends on the type category of `typename`. The following table shows how compatibility is determined.  
  
|Type category of `typename`|Compatibility criterion|  
|---------------------------------|-----------------------------|  
|Class|`objectexpression` is of type `typename` or inherits from `typename`|  
|Structure|`objectexpression` is of type `typename`|  
|Interface|`objectexpression` implements `typename` or inherits from a class that implements `typename`|  
  
 If the run-time type of `objectexpression` satisfies the compatibility criterion, `result` is `True`. Otherwise, `result` is `False`.  If `objectexpression` is null, then `TypeOf`...`Is` returns `False`, and ...`IsNot` returns `True`.  
  
 `TypeOf` is always used with the `Is` keyword to construct a `TypeOf`...`Is` expression, or with the `IsNot` keyword to construct a `TypeOf`...`IsNot` expression.  
  
## Example  
 The following example uses `TypeOf`...`Is` expressions to test the type compatibility of two object reference variables with various data types.  
  
 [!code[VbVbalrOperators#39](../VS_visualbasic/codesnippet/VisualBasic/typeof-operator--visual-basic-_1.vb)]  
  
 The variable `refInteger` has a run-time type of `Integer`. It is compatible with `Integer` but not with `Double`. The variable `refForm` has a run-time type of \<xref:System.Windows.Forms.Form>. It is compatible with \<xref:System.Windows.Forms.Form> because that is its type, with \<xref:System.Windows.Forms.Control> because \<xref:System.Windows.Forms.Form> inherits from \<xref:System.Windows.Forms.Control>, and with \<xref:System.ComponentModel.IComponent> because \<xref:System.Windows.Forms.Form> inherits from \<xref:System.ComponentModel.Component>, which implements \<xref:System.ComponentModel.IComponent>. However, `refForm` is not compatible with \<xref:System.Windows.Forms.Label>.  
  
## See Also  
 [Is Operator](../VS_visualbasic/is-operator--visual-basic-.md)   
 [IsNot Operator](../VS_visualbasic/isnot-operator--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../VS_visualbasic/comparison-operators-in-visual-basic.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Operators and Expressions](../VS_visualbasic/operators-and-expressions-in-visual-basic.md)