---
title: "_query_new_mode"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_query_new_mode"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "query_new_mode"
  - "_query_new_mode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "query_new_mode function"
  - "handler modes"
  - "_query_new_mode function"
ms.assetid: e185c5f9-b73b-4257-8eff-b47648374768
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _query_new_mode
Returns an integer indicating the new handler mode set by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the current new handler mode, namely 0 or 1, for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. A return value of 1 indicates that, on failure to allocate memory, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calls the new handler routine; a return value of 0 indicates that it does not.  
  
## Remarks  
 The C++ <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function returns an integer that indicates the new handler mode that is set by the C++ [_set_new_mode](../vs140/_set_new_mode.md) function for [malloc](../vs140/malloc.md). The new handler mode indicates whether, on failure to allocate memory, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is to call the new handler routine as set by [_set_new_handler](../vs140/_set_new_handler.md). By default, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not call the new handler routine on failure. You can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to override this behavior so that on failure <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> calls the new handler routine in the same way that the **new** operator does when it fails to allocate memory. For more information, see the [operator delete](../vs140/operator-delete-function.md) and [operator new](../vs140/operator-new-function.md) functions in *C++ Language Reference*.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<new.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [free](../vs140/free.md)   
 [realloc](../vs140/realloc.md)   
 [_query_new_handler](../vs140/_query_new_handler.md)