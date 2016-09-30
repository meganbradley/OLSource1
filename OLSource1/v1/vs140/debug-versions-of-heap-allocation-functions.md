---
title: "Debug Versions of Heap Allocation Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.crt"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "_CRTDBG_MAP_ALLOC macro"
  - "debugging [CRT], heap allocation functions"
  - "debugging memory leaks, CRT debug library functions"
  - "malloc function"
  - "memory leaks, CRT debug library functions"
  - "heap allocation, debug"
  - "_malloc_dbg function"
ms.assetid: 91748bdc-f4cd-4d8b-ab98-0493dab7ed0d
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debug Versions of Heap Allocation Functions
The C run-time library contains special Debug versions of the heap allocation functions. These functions have the same names as the Release versions with _dbg appended to them. This topic describes the differences between the Release version of a CRT function and the _dbg version, using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> as examples.  
  
 When [_DEBUG](../vs140/_debug.md) is defined, the CRT maps all [malloc](../vs140/malloc.md) calls to [_malloc_dbg](../vs140/_malloc_dbg.md). Therefore, you do not need to rewrite your code using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to receive the benefits while debugging.  
  
 You might want to call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> explicitly, however. Calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> explicitly has some added benefits:  
  
-   Tracking <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type allocations.  
  
-   Storing the source file and line number where the allocation request occurred.  
  
 If you do not want to convert your <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you can obtain the source file information by defining [_CRTDBG_MAP_ALLOC](../vs140/_crtdbg_map_alloc.md), which causes the preprocessor to directly map all calls to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> instead of relying on a wrapper around <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 To track the separate types of allocations in client blocks, you must call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directly and set the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 When _DEBUG is not defined, calls to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are not disturbed, calls to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are resolved to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the definition of [_CRTDBG_MAP_ALLOC](../vs140/_crtdbg_map_alloc.md) is ignored, and source file information pertaining to the allocation request is not provided. Because <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does not have a block type parameter, requests for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> types are treated as standard allocations.  
  
## See Also  
 [CRT Debugging Techniques](../vs140/crt-debugging-techniques.md)