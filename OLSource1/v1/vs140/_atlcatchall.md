---
title: "_ATLCATCHALL"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL._ATLCATCHALL"
  - "ATL::_ATLCATCHALL"
  - "_ATLCATCHALL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLCATCHALL macro"
  - "_ATLCATCHALL macro"
ms.assetid: 4d739656-a00c-46b8-be0c-b56545a09335
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATLCATCHALL
Statement(s) to handle errors occurring in the associated `_ATLTRY`.  
  
## Syntax  
  
```  
  
_ATLCATCHALL  
  
```  
  
## Remarks  
 Used in conjunction with `_ATLTRY`. Resolves to C++ [catch(...)](../vs140/try--throw--and-catch-statements--c---.md) for handling all types of C++ exceptions.  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Exception Handling Macros](../vs140/exception-handling-macros.md)   
 [_ATLTRY](../vs140/_atltry.md)   
 [_ATLCATCH](../vs140/_atlcatch.md)