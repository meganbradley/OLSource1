---
title: "_onexit, _onexit_m"
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
  - "_onexit"
  - "_onexit_m"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_onexit"
  - "onexit_m"
  - "onexit"
  - "_onexit_m"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "onexit function"
  - "registry, registering exit routines"
  - "_onexit_m function"
  - "onexit_m function"
  - "_onexit function"
  - "registering exit routines"
  - "registering to be called on exit"
ms.assetid: 45743298-0e2f-46cf-966d-1ca44babb443
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _onexit, _onexit_m
Registers a routine to be called at exit time.  
  
## Syntax  
  
```  
_onexit_t _onexit(  
   _onexit_t function  
);  
_onexit_t_m _onexit_m(  
   _onexit_t_m function  
);  
```  
  
#### Parameters  
 `function`  
 Pointer to a function to be called at exit.  
  
## Return Value  
 `_onexit` returns a pointer to the function if successful or `NULL` if there is no space to store the function pointer.  
  
## Remarks  
 The `_onexit` function is passed the address of a function (`function`) to be called when the program terminates normally. Successive calls to `_onexit` create a register of functions that are executed in LIFO (last-in-first-out) order. The functions passed to `_onexit` cannot take parameters.  
  
 In the case when `_onexit` is called from within a DLL, routines registered with `_onexit` run on a DLL's unloading after `DllMain` is called with DLL_PROCESS_DETACH.  
  
 `_onexit` is a Microsoft extension. For ANSI portability, use [atexit](../vs140/atexit.md). The `_onexit_m` version of the function is for mixed mode use.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_onexit`|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt_onexit.c  
  
#include <stdlib.h>  
#include <stdio.h>  
  
/* Prototypes */  
int fn1(void), fn2(void), fn3(void), fn4 (void);  
  
int main( void )  
{  
   _onexit( fn1 );  
   _onexit( fn2 );  
   _onexit( fn3 );  
   _onexit( fn4 );  
   printf( "This is executed first.\n" );  
}  
  
int fn1()  
{  
   printf( "next.\n" );  
   return 0;  
}  
  
int fn2()  
{  
   printf( "executed " );  
   return 0;  
}  
  
int fn3()  
{  
   printf( "is " );  
   return 0;  
}  
  
int fn4()  
{  
   printf( "This " );  
   return 0;  
}  
```  
  
## Output  
  
```  
This is executed first.  
This is executed next.  
```  
  
## .NET Framework Equivalent  
 [System::Diagnostics::Process::Exited](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.exited.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [atexit](../vs140/atexit.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [__dllonexit](../vs140/__dllonexit.md)