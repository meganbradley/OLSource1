---
title: "Concatenation Operators in Visual Basic"
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
  - "& operator [Visual Basic], concatenation"
  - "concatenation operators"
  - "operators [Visual Basic], concatenation"
  - "Visual Basic code, operators"
  - "+ operator [Visual Basic], concatenation"
  - "concatenation operators, Visual Basic strings"
ms.assetid: e59908c3-89e0-41ae-933d-3e8826c16a04
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Concatenation Operators in Visual Basic
Concatenation operators join multiple strings into a single string. There are two concatenation operators, `+` and `&`. Both carry out the basic concatenation operation, as the following example shows.  
  
 [!CODE [Dim x As String = "Mic" & "ro" & "soft" Dim y As String = "Mic" + "ro" + "soft" ' The preceding statements set both x and y to "Microsoft".](Dim x As String = "Mic" & "ro" & "soft" Dim y As String = "Mic" + "ro" + "soft" ' The preceding statements set both x and y to "Microsoft".)]  
  
 These operators can also concatenate `String` variables, as the following example shows.  
  
 [!code[VbVbalrOperators#76](../VS_csharp/codesnippet/VisualBasic/concatenation-operators-in-visual-basic_1.vb)]  
  
## Differences Between the Two Concatenation Operators  
 The [+ Operator (Visual Basic)](../VS_csharp/--operator--visual-basic-.md) has the primary purpose of adding two numbers. However, it can also concatenate numeric operands with string operands. The `+` operator has a complex set of rules that determine whether to add, concatenate, signal a compiler error, or throw a run-time <xref:System.InvalidCastException*> exception.  
  
 The [& Operator](../VS_csharp/--operator--visual-basic-.md) is defined only for `String` operands, and it always widens its operands to `String`, regardless of the setting of `Option Strict`. The `&` operator is recommended for string concatenation because it is defined exclusively for strings and reduces your chances of generating an unintended conversion.  
  
## Performance: String and StringBuilder  
 If you do a significant number of manipulations on a string, such as concatenations, deletions, and replacements, your performance might profit from the <xref:System.Text.StringBuilder*> class in the <xref:System.Text*> namespace. It takes an extra instruction to create and initialize a <xref:System.Text.StringBuilder*> object, and another instruction to convert its final value to a `String`, but you might recover this time because <xref:System.Text.StringBuilder*> can perform faster.  
  
## See Also  
 [Option Strict Statement](../VS_csharp/option-strict-statement.md)   
 [Types of String Manipulation Methods in Visual Basic](../VS_csharp/types-of-string-manipulation-methods-in-visual-basic.md)   
 [Arithmetic Operators in Visual Basic](../VS_csharp/arithmetic-operators-in-visual-basic.md)   
 [Comparison Operators in Visual Basic](../VS_csharp/comparison-operators-in-visual-basic.md)   
 [Logical and Bitwise Operators in Visual Basic](../VS_csharp/logical-and-bitwise-operators-in-visual-basic.md)