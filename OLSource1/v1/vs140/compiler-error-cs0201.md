---
title: "Compiler Error CS0201"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0201"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0201"
ms.assetid: cf5d6701-50cc-4e4f-878b-e1a4ad8a2061
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0201
Only assignment, call, increment, decrement, and new object expressions can be used as a statement  
  
 The compiler generates an error when it encounters an invalid statement. An invalid statement is any line or series of lines ending in a semicolon that does not represent an assignment ([=](../vs140/=-operator--csharp-reference-.md)), method call [()](../vs140/---operator--csharp-reference-.md), [new](../vs140/new--csharp-reference-.md), [--](../vs140/---operator--csharp-reference-.md) or [++](../vs140/---operator--csharp-reference-.md) operation. For more information, see [Statements, Expressions, and Operators (C# Programming Guide)](../vs140/statements--expressions--and-operators--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0201 because 2 * 3 is an expression, not a statement. To make the code compile, try assigning the value of the expression to a  variable.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS0201 because checked by itself is not a statement, even though it is parameterized by an increment operation.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C# Compiler Errors](../vs140/csharp-compiler-errors.md)