---
title: "Control Flags"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.flags"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "flags, control"
  - "heap allocation, control flags"
  - "debug heap, control flags"
ms.assetid: 8dbd24a5-0633-42d1-9771-776db338465f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control Flags
The debug version of the Microsoft C run-time library uses the following flags to control the heap allocation and reporting process. For more information, see [CRT Debugging Techniques](../VS_csharp/crt-debugging-techniques.md).  
  
|Flag|Description|  
|----------|-----------------|  
|[_CRTDBG_MAP_ALLOC](../VS_csharp/_crtdbg_map_alloc.md)|Maps the base heap functions to their debug version counterparts|  
|[_DEBUG](../VS_csharp/_debug.md)|Enables the use of the debugging versions of the run-time functions|  
|[_crtDbgFlag](../VS_csharp/_crtdbgflag.md)|Controls how the debug heap manager tracks allocations|  
  
 These flags can be defined with a /D command-line option or with a `#define` directive. When the flag is defined with `#define`, the directive must appear before the header file include statement for the routine declarations.  
  
## See Also  
 [Global Variables and Standard Types](../VS_csharp/global-variables-and-standard-types.md)