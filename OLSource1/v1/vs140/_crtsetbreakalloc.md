---
title: "_CrtSetBreakAlloc"
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
  - "_CrtSetBreakAlloc"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtSetBreakAlloc"
  - "_CrtSetBreakAlloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtSetBreakAlloc function"
  - "_CrtSetBreakAlloc function"
ms.assetid: 33bfc6af-a9ea-405b-a29f-1c2d4d9880a1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtSetBreakAlloc
Sets a breakpoint on a specified object allocation order number (debug version only).  
  
## Syntax  
  
```  
  
      long _CrtSetBreakAlloc(   
   long lBreakAlloc   
);  
```  
  
#### Parameters  
 *lBreakAlloc*  
 Allocation order number, for which to set the breakpoint.  
  
## Return Value  
 Returns the previous object allocation order number that had a breakpoint set.  
  
## Remarks  
 `_CrtSetBreakAlloc` allows an application to perform memory leak detection by breaking at a specific point of memory allocation and tracing back to the origin of the request. The function uses the sequential object allocation order number assigned to the memory block when it was allocated in the heap. When [_DEBUG](../vs140/_debug.md) is not defined, calls to `_CrtSetBreakAlloc` are removed during preprocessing.  
  
 The object allocation order number is stored in the *lRequest* field of the **_CrtMemBlockHeader** structure, defined in Crtdbg.h. When information about a memory block is reported by one of the debug dump functions, this number is enclosed in braces, such as {36}.  
  
 For more information about how `_CrtSetBreakAlloc` can be used with other memory management functions, see [Tracking Heap Allocation Requests](../vs140/crt-debug-heap-details.md#BKMK_Track_Heap_Allocation_Requests). For more information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_CrtSetBreakAlloc`|<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
  
```  
// crt_setbrkal.c  
// compile with: -D_DEBUG /MTd -Od -Zi -W3 /c /link -verbose:lib -debug  
  
/*  
 * In this program, a call is made to the _CrtSetBreakAlloc routine  
 * to verify that the debugger halts program execution when it reaches  
 * a specified allocation number.  
 */  
  
#include <malloc.h>  
#include <crtdbg.h>  
  
int main( )  
{  
        long allocReqNum;  
        char *my_pointer;  
  
        /*   
         * Allocate "my_pointer" for the first  
         * time and ensure that it gets allocated correctly  
         */  
        my_pointer = malloc(10);  
        _CrtIsMemoryBlock(my_pointer, 10, &allocReqNum, NULL, NULL);  
  
        /*   
         * Set a breakpoint on the allocation request  
         * number for "my_pointer"  
         */  
        _CrtSetBreakAlloc(allocReqNum+2);  
  
        /*   
         * Alternate freeing and reallocating "my_pointer"  
         * to verify that the debugger halts program execution  
         * when it reaches the allocation request  
         */  
        free(my_pointer);  
        my_pointer = malloc(10);  
        free(my_pointer);  
        my_pointer = malloc(10);  
        free(my_pointer);  
}  
```  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)