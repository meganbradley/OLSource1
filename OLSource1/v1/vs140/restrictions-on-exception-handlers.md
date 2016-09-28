---
title: "Restrictions on Exception Handlers"
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
  - "restrictions, exception handlers"
  - "exception handling, exception handlers"
ms.assetid: 31d63524-0e8c-419f-b87c-061f4c0ea470
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Restrictions on Exception Handlers
The principal limitation to using exception handlers in code is that you cannot use a `goto` statement to jump into a `__try` statement block. Instead, you must enter the statement block through normal flow of control. You can jump out of a `__try` statement block and nest exception handlers as you choose.  
  
## See Also  
 [Writing an Exception Handler](../vs140/writing-an-exception-handler.md)   
 [Structured Exception Handling (C/C++)](../vs140/structured-exception-handling--c-c---.md)