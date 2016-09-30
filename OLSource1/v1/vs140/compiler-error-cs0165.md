---
title: "Compiler Error CS0165"
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
  - "CS0165"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0165"
ms.assetid: e7eb7c90-af16-4734-b747-214030696975
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0165
Use of unassigned local variable 'name'  
  
 The C# compiler does not allow the use of uninitialized variables. If the compiler detects the use of a variable that might not have been initialized, it generates compiler error CS0165. For more information, see [Properties and Fields (C# Programmer's Reference)](../vs140/fields--csharp-programming-guide-.md). Note that this error is generated when the compiler encounters a construct that might result in the use of an unassigned variable, even if your particular code does not. This avoids the necessity of overly-complex rules for definite assignment.  
  
 For more information, see [http://blogs.msdn.com/ericlippert/archive/2006/08/18/706398.aspx](http://blogs.msdn.com/ericlippert/archive/2006/08/18/706398.aspx).  
  
## Example  
 The following sample generates CS0165:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Compiler error CS0165 can occur in recursive delegate definitions. You can avoid the error by defining the delegate in two statements so that the variable is not used before it is initialized. The following example demonstrates the error and the resolution.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>