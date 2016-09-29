---
title: "_crtDbgFlag"
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
  - "_crtDbgFlag"
  - "crtDbgFlag"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory allocation, tracking flag"
  - "crtDbgFlag constant"
  - "_crtDbgFlag constant"
  - "debug heap, tracking memory on"
  - "debug heap, control flags"
  - "enable memory allocation tracking flag"
  - "memory, tracking on the debug heap"
ms.assetid: 9e7adb47-8ab9-4e19-81d5-e2f237979973
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _crtDbgFlag
The **_crtDbgFlag** flag consists of five bit fields that control how memory allocations on the debug version of the heap are tracked, verified, reported, and dumped. The bit fields of the flag are set using the [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md) function. This flag and its bit fields are declared in Crtdbg.h. This flag is only available when the [_DEBUG](../vs140/_debug.md) flag has been defined in the application.  
  
 For more information about using this flag in conjunction with other debug functions, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions).  
  
## See Also  
 [Control Flags](../vs140/control-flags.md)