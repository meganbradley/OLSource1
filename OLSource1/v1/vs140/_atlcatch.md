---
title: "_ATLCATCH"
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
  - "ATL._ATLCATCH"
  - "ATL::_ATLCATCH"
  - "_ATLCATCH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ATLCATCH macro"
  - "ATLCATCH macro"
ms.assetid: f23a9048-4025-43f4-a245-e97b3562b267
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATLCATCH
Statement(s) to handle errors occurring in the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *e*  
 The exception to catch.  
  
## Remarks  
 Used in conjunction with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Resolves to C++ [catch(CAtlException e)](../vs140/try--throw--and-catch-statements--c---.md) for handling a given type of C++ exceptions.  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Exception Handling Macros](../vs140/exception-handling-macros.md)   
 [_ATLTRY](../vs140/_atltry.md)   
 [_ATLCATCHALL](../vs140/_atlcatchall.md)