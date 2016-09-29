---
title: "Defining a Rule"
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
helpviewer_keywords: 
  - "NMAKE program, inference rules"
  - "defining inference rules"
ms.assetid: 071cd092-3f2e-4065-b0fb-36a9d393cfa8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Defining a Rule
The *fromext* represents the extension of a dependent file, and *toext* represents the extension of a target file.  
  
```  
.fromext.toext:  
   commands  
```  
  
## Remarks  
 Extensions are not case sensitive. Macros can be invoked to represent *fromext* and *toext*; the macros are expanded during preprocessing. The period (.) preceding *fromext* must appear at the beginning of the line. The colon (:) is preceded by zero or more spaces or tabs. It can be followed only by spaces or tabs, a semicolon (;) to specify a command, a number sign (#) to specify a comment, or a newline character. No other spaces are allowed. Commands are specified as in description blocks.  
  
## What do you want to know more about?  
 [Search paths in rules](../vs140/search-paths-in-rules.md)  
  
## See Also  
 [Inference Rules](../vs140/inference-rules.md)