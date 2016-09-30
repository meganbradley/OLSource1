---
title: "Compiler Error CS0156"
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
  - "CS0156"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0156"
ms.assetid: 32026b1b-bcd7-4464-b63f-3b38c00452a6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0156
A throw statement with no arguments is not allowed in a finally clause that is nested inside the nearest enclosing catch clause  
  
 A [throw](../vs140/throw--csharp-reference-.md) statement with no parameters can only appear in a **catch** clause that takes no parameters.  
  
 For more information, see [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md) and [Exceptions and Exception Handling (C# Programmer's Reference)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md).  
  
 The following sample generates CS0156:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>