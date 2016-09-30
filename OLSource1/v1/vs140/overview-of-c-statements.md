---
title: "Overview of C Statements"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "semicolon, in C statements"
  - "statements, C"
  - "semicolon"
  - "statements, about statements"
  - "Visual C, statements"
ms.assetid: 0d49837a-5399-4881-b60c-af5f4e9720de
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overview of C Statements
C statements consist of tokens, expressions, and other statements. A statement that forms a component of another statement is called the "body" of the enclosing statement. Each statement type given by the following syntax is discussed in this section.  
  
## Syntax  
 *statement*:  
 [labeled-statement](../vs140/goto-and-labeled-statements--c-.md)  
  
 [compound-statement](../vs140/compound-statement--c-.md)  
  
 [expression-statement](../vs140/expression-statement--c-.md)  
  
 [selection-statement](../vs140/if-statement--c-.md)  
  
 [iteration-statement](../vs140/do-while-statement--c-.md)  
  
 [jump-statement](../vs140/break-statement--c-.md)  
  
 [try-except-statement](../vs140/try-except-statement--c-.md)  
  
 /* Microsoft Specific \*/[try-finally-statement](../vs140/try-finally-statement--c-.md) /\* Microsoft Specific \*/  
  
 Frequently the statement body is a "compound statement." A compound statement consists of other statements that can include keywords. The compound statement is delimited by braces (**{ }**). All other C statements end with a semicolon (**;**). The semicolon is a statement terminator.  
  
 The expression statement contains a C expression that can contain the arithmetic or logical operators introduced in [Expressions and Assignments](../vs140/expressions-and-assignments.md). The null statement is an empty statement.  
  
 Any C statement can begin with an identifying label consisting of a name and a colon. Since only the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement recognizes statement labels, statement labels are discussed with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. See [The goto and Labeled Statements](../vs140/goto-and-labeled-statements--c-.md) for more information.  
  
## See Also  
 [Statements (C)](../vs140/statements--c-.md)