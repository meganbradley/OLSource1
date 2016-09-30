---
title: "Compiler Error CS0131"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0131"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0131"
ms.assetid: 822852cc-a426-4b7d-b2ff-0026a0c0a0e7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0131
The left-hand side of an assignment must be a variable, property or indexer  
  
 In an assignment statement, the value of the right-hand side is assigned to the left-hand side. The left-hand side must be a variable, property, or indexer.  
  
 To fix this error, make sure that all operators are on the right-hand side and that the left-hand side is a variable, property, or indexer. For more information, see [Statements, Expressions, and Operators (C# Programmers Reference)](../vs140/statements--expressions--and-operators--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0131.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This error can also occur if you attempt to perform arithmetic operations on the left hand side of an assignment operator, as in the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>