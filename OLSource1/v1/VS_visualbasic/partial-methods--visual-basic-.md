---
title: "Partial Methods (Visual Basic)"
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
  - "vb.PartialMethod"
  - "PartialMethod"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "custom logic into code [Visual Basic]"
  - "partial methods [Visual Basic]"
  - "partial, methods [Visual Basic]"
  - "methods [Visual Basic], partial methods"
  - "inserting custom logic into code"
ms.assetid: 74b3368b-b348-44a0-a326-7d7dc646f4e9
caps.latest.revision: 16
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
# Partial Methods (Visual Basic)
Partial methods enable developers to insert custom logic into code. Typically, the code is part of a designer-generated class. Partial methods are defined in a partial class that is created by a code generator, and they are commonly used to provide notification that something has been changed. They enable the developer to specify custom behavior in response to the change.  
  
 The designer of the code generator defines only the method signature and one or more calls to the method. Developers can then provide implementations for the method if they want to customize the behavior of the generated code. When no implementation is provided, calls to the method are removed by the compiler, resulting in no additional performance overhead.  
  
## Declaration  
 The generated code marks the definition of a partial method by placing the keyword `Partial` at the start of the signature line.  
  
```vb#  
Partial Private Sub QuantityChanged()  
End Sub  
```  
  
 The definition must meet the following conditions:  
  
-   The method must be a `Sub`, not a `Function`.  
  
-   The body of the method must be left empty.  
  
-   The access modifier must be `Private`.  
  
## Implementation  
 The implementation consists primarily of filling in the body of the partial method. The implementation is typically in a separate partial class from the definition, and is written by a developer who wants to extend the generated code.  
  
```vb#  
Private Sub QuantityChanged()  
'    Code for executing the desired action.  
End Sub  
```  
  
 The previous example duplicates the signature in the declaration exactly, but variations are possible. In particular, other modifiers can be added, such as `Overloads` or `Overrides`. Only one `Overrides` modifier is permitted. For more information about method modifiers, see [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md).  
  
## Use  
 You call a partial method as you would call any other `Sub` procedure. If the method has been implemented, the arguments are evaluated and the body of the method is executed. However, remember that implementing a partial method is optional. If the method is not implemented, a call to it has no effect, and expressions passed as arguments to the method are not evaluated.  
  
## Example  
 In a file named Product.Designer.vb, define a `Product` class that has a `Quantity` property.  
  
 [!code[VbVbalrPartialMeths#4](../VS_visualbasic/codesnippet/VisualBasic/partial-methods--visual-basic-_1.vb)]  
  
 In a file named Product.vb, provide an implementation for `QuantityChanged`.  
  
 [!code[VbVbalrPartialMeths#5](../VS_visualbasic/codesnippet/VisualBasic/partial-methods--visual-basic-_2.vb)]  
  
 Finally, in the Main method of a project, declare a `Product` instance and provide an initial value for its `Quantity` property.  
  
 [!code[VbVbalrPartialMeths#6](../VS_visualbasic/codesnippet/VisualBasic/partial-methods--visual-basic-_3.vb)]  
  
 A message box should appear that displays this message:  
  
 `Quantity was changed to 100`  
  
## See Also  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)   
 [Sub Procedures](../VS_visualbasic/sub-procedures--visual-basic-.md)   
 [Optional Parameters](../VS_visualbasic/optional-parameters--visual-basic-.md)   
 [Partial](../VS_visualbasic/partial--visual-basic-.md)   
 [Code Generation in LINQ to SQL](../Topic/Code%20Generation%20in%20LINQ%20to%20SQL.md)   
 [Adding Business Logic By Using Partial Methods](../Topic/Adding%20Business%20Logic%20By%20Using%20Partial%20Methods.md)