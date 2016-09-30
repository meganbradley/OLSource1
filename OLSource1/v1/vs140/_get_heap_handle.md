---
title: "_get_heap_handle"
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
  - "_get_heap_handle"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120d_clr0400.dll"
  - "msvcr100_clr0400.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_get_heap_handle"
  - "get_heap_handle"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "heap functions"
  - "memory allocation, heap memory"
  - "_get_heap_handle function"
  - "get_heap_handle function"
ms.assetid: a4d05049-8528-494a-8281-a470d1e1115c
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _get_heap_handle
Returns the handle of the heap that's used by the C run-time system.  
  
## Syntax  
  
```  
intptr_t _get_heap_handle( void );  
```  
  
## Return Value  
 Returns the handle to the Win32 heap used by the C run-time system.  
  
## Remarks  
 Use this function if you want to call [HeapSetInformation](http://msdn.microsoft.com/library/windows/desktop/aa366705) and enable the Low Fragmentation Heap on the CRT heap.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_get_heap_handle`|\<malloc.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Sample  
  
```  
// crt_get_heap_handle.cpp  
// compile with: /MT  
#include <windows.h>  
#include <malloc.h>  
#include <stdio.h>  
  
int main(void)  
{  
    intptr_t hCrtHeap = _get_heap_handle();  
    ULONG ulEnableLFH = 2;  
    if (HeapSetInformation((PVOID)hCrtHeap,  
                           HeapCompatibilityInformation,  
                           &ulEnableLFH, sizeof(ulEnableLFH)))  
        puts("Enabling Low Fragmentation Heap succeeded");  
    else  
        puts("Enabling Low Fragmentation Heap failed");  
    return 0;  
}  
```  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)