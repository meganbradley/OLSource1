---
title: "_heapchk"
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
  - "_heapchk"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_heapchk"
  - "heapchk"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debugging [CRT], heap-related problems"
  - "consistency checking of heaps"
  - "heapchk function"
  - "heaps, checking consistency"
  - "_heapchk function"
ms.assetid: 859619a5-1e35-4f02-9e09-11d9fa266ec0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _heapchk
Runs consistency checks on the heap.  
  
## Syntax  
  
```  
int _heapchk( void );  
```  
  
## Return Value  
 `_heapchk` returns one of the following integer manifest constants defined in Malloc.h.  
  
 `_HEAPBADBEGIN`  
 Initial header information is bad or cannot be found.  
  
 `_HEAPBADNODE`  
 Bad node has been found or heap is damaged.  
  
 `_HEAPBADPTR`  
 Pointer into heap is not valid.  
  
 `_HEAPEMPTY`  
 Heap has not been initialized.  
  
 `_HEAPOK`  
 Heap appears to be consistent.  
  
 In addition, if an error occurs, `_heapchk` sets `errno` to `ENOSYS`.  
  
## Remarks  
 The `_heapchk` function helps debug heap-related problems by checking for minimal consistency of the heap. If the operating system does not support `_heapchk`(for example, Windows 98), the function returns `_HEAPOK` and sets `errno` to `ENOSYS`.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|`_heapchk`|<malloc.h>|<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt_heapchk.c  
// This program checks the heap for  
// consistency and prints an appropriate message.  
  
#include <malloc.h>  
#include <stdio.h>  
  
int main( void )  
{  
   int  heapstatus;  
   char *buffer;  
  
   // Allocate and deallocate some memory  
   if( (buffer = (char *)malloc( 100 )) != NULL )  
      free( buffer );  
  
   // Check heap status  
   heapstatus = _heapchk();  
   switch( heapstatus )  
   {  
   case _HEAPOK:  
      printf(" OK - heap is fine\n" );  
      break;  
   case _HEAPEMPTY:  
      printf(" OK - heap is empty\n" );  
      break;  
   case _HEAPBADBEGIN:  
      printf( "ERROR - bad start of heap\n" );  
      break;  
   case _HEAPBADNODE:  
      printf( "ERROR - bad node in heap\n" );  
      break;  
   }  
}  
```  
  
  **OK - heap is fine**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_heapadd](../vs140/_heapadd.md)   
 [_heapmin](../vs140/_heapmin.md)   
 [_heapset](../vs140/_heapset.md)   
 [_heapwalk](../vs140/_heapwalk.md)