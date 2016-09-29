---
title: "Overview of C++ Statements"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "statements, C++"
ms.assetid: e56996b2-b846-4b99-ac94-ac72fffc5ec7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overview of C++ Statements
C++ statements are executed sequentially, except when an expression statement, a selection statement, an iteration statement, or a jump statement specifically modifies that sequence.  
  
 Statements may be of the following types:  
  
```  
  
labeled-statement  
expression-statement  
compound-statement  
selection-statement  
iteration-statement  
jump-statement  
declaration-statement  
try-throw-catch  
  
```  
  
 In most cases, the C++ statement syntax is identical to that of ANSI C. The primary difference between the two is that in C, declarations are allowed only at the start of a block; C++ adds the *declaration-statement*, which effectively removes this restriction. This enables you to introduce variables at a point in the program where a precomputed initialization value can be calculated.  
  
 Declaring variables inside blocks also allows you to exercise precise control over the scope and lifetime of those variables.  
  
 The topics on statements describe the following C++ keywords:  
  
|||||  
|-|-|-|-|  
|[break](../VS_csharp/break-statement--c---.md)|[else](../VS_csharp/if-else-statement--c---.md)|[__if_exists](../VS_csharp/__if_exists-statement.md)|[__try](../VS_csharp/structured-exception-handling--c-c---.md)|  
|[case](../VS_csharp/switch-statement--c---.md)|[__except](../VS_csharp/structured-exception-handling--c-c---.md)|[__if_not_exists](../VS_csharp/__if_not_exists-statement.md)|[try](../VS_csharp/try--throw--and-catch-statements--c---.md)|  
|[catch](../VS_csharp/try--throw--and-catch-statements--c---.md)|[for](../VS_csharp/for-statement--c---.md)|[__leave](../VS_csharp/try-finally-statement--c-.md)|[while](../VS_csharp/while-statement--c---.md)|  
|[continue](../VS_csharp/continue-statement--c---.md)|[goto](../VS_csharp/goto-statement--c---.md)|[return](../VS_csharp/return-statement--c---.md)||  
|[default](../VS_csharp/switch-statement--c---.md)|[__finally](../VS_csharp/structured-exception-handling--c-c---.md)|[switch](../VS_csharp/switch-statement--c---.md)||  
|[do](../VS_csharp/do-while-statement--c---.md)|[if](../VS_csharp/if-else-statement--c---.md)|[throw](../VS_csharp/try--throw--and-catch-statements--c---.md)||  
  
## See Also  
 [Statements](../VS_csharp/statements--c---.md)