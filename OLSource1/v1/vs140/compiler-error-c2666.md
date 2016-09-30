---
title: "Compiler Error C2666"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2666"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2666"
ms.assetid: 78364d15-c6eb-439a-9088-e04a0176692b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2666
'identifier' : number overloads have similar conversions  
  
 An overloaded function or operator is ambiguous.   Formal parameter lists may be too similar for the compiler to resolve the ambiguity.  To resolve this error, explicitly cast one or more of the actual parameters.  
  
 The following sample generates C2666:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003:  
  
-   binary operators and user-defined conversions to pointer types  
  
-   qualification conversion is not the same as identity conversion  
  
 For the binary operators \<, >, \<=, and >=, a passed parameter is now implicitly converted to the type of the operand if the parameter's type defines a user-defined conversion operator to convert to the type of the operand. There is now potential for ambiguity.  
  
 For code that is valid in both the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++, call the class operator explicitly using function syntax.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C2666  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>