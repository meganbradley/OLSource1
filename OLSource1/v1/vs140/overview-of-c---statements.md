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
author: ""
ms.author: ""
manager: ""
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
|[break](../vs140/break-statement--c---.md)|[else](../vs140/if-else-statement--c---.md)|[__if_exists](../vs140/__if_exists-statement.md)|[__try](../vs140/structured-exception-handling--c-c---.md)|  
|[case](../vs140/switch-statement--c---.md)|[__except](../vs140/structured-exception-handling--c-c---.md)|[__if_not_exists](../vs140/__if_not_exists-statement.md)|[try](../vs140/try--throw--and-catch-statements--c---.md)|  
|[catch](../vs140/try--throw--and-catch-statements--c---.md)|[for](../vs140/for-statement--c---.md)|[__leave](../vs140/try-finally-statement--c-.md)|[while](../vs140/while-statement--c---.md)|  
|[continue](../vs140/continue-statement--c---.md)|[goto](../vs140/goto-statement--c---.md)|[return](../vs140/return-statement--c---.md)||  
|[default](../vs140/switch-statement--c---.md)|[__finally](../vs140/structured-exception-handling--c-c---.md)|[switch](../vs140/switch-statement--c---.md)||  
|[do](../vs140/do-while-statement--c---.md)|[if](../vs140/if-else-statement--c---.md)|[throw](../vs140/try--throw--and-catch-statements--c---.md)||  
  
## See Also  
 [Statements](../vs140/statements--c---.md)