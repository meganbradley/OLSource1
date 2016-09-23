---
title: "_ATLTRY"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::_ATLTRY
  - _ATLTRY
  - ATL._ATLTRY
dev_langs: 
  - C++
helpviewer_keywords: 
  - ATLTRY macro
  - _ATLTRY macro
ms.assetid: ad67f0f1-5780-4c26-b642-8c1061b9280f
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _ATLTRY
Marks a guarded code section where an error could possibly occur.  
  
## Syntax  
  
```  
  
_ATLTRY  
  
```  
  
## Remarks  
 Used in conjunction with [_ATLCATCH](../vs140/_atlcatch.md) or [_ATLCATCHALL](../vs140/_atlcatchall.md). Resolves to the C++ symbol [try](../vs140/try--throw--and-catch-statements--c---.md).  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Exception Handling Macros](../vs140/exception-handling-macros.md)   
 [_ATLCATCH](../vs140/_atlcatch.md)   
 [_ATLCATCHALL](../vs140/_atlcatchall.md)