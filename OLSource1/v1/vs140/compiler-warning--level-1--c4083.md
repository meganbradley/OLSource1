---
title: "Compiler Warning (level 1) C4083"
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
  - "C4083"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4083"
ms.assetid: e7d3344e-5645-4d56-8460-d1acc9145ada
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4083
expected 'token'; found identifier 'identifier'  
  
 An identifier occurs in the wrong place in a **#pragma** statement.  
  
## Example  
  
```  
// C4083.cpp  
// compile with: /W1 /LD  
#pragma warning disable:4083    // C4083  
#pragma warning(disable:4083)   //correct  
```  
  
 Check the syntax of the [#pragma](../vs140/pragma-directives-and-the-__pragma-keyword.md) directives.