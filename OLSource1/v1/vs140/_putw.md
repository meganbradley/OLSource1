---
title: "_putw"
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
  - "_putw"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_putw"
  - "putw"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "integers, writing to streams"
  - "putw function"
  - "streams, writing integers to"
  - "_putw function"
ms.assetid: 83d63644-249d-4a39-87e5-3b7aa313968d
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _putw
Writes an integer to a stream.  
  
## Syntax  
  
```  
  
      int _putw(  
   int binint,  
   FILE *stream   
);  
```  
  
#### Parameters  
 *binint*  
 Binary integer to be output.  
  
 `stream`  
 Pointer to the **FILE** structure.  
  
## Return Value  
 Returns the value written. A return value of `EOF` might indicate an error. Because `EOF` is also a legitimate integer value, use `ferror` to verify an error. If `stream` is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets `errno` to `EINVAL` and returns `EOF`.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The `_putw` function writes a binary value of type `int` to the current position of *stream.* `_putw` does not affect the alignment of items in the stream nor does it assume any special alignment. `_putw` is primarily for compatibility with previous libraries. Portability problems might occur with `_putw` because the size of an `int` and the ordering of bytes within an `int` differ across systems.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_putw`|<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
```  
// crt_putw.c  
/* This program uses _putw to write a  
 * word to a stream, then performs an error check.  
 */  
  
#include <stdio.h>  
#include <stdlib.h>  
  
int main( void )  
{  
   FILE *stream;  
   unsigned u;  
   if( fopen_s( &stream, "data.out", "wb" ) )  
      exit( 1 );  
   for( u = 0; u < 10; u++ )  
   {  
      _putw( u + 0x2132, stream );   /* Write word to stream. */  
      if( ferror( stream ) )         /* Make error check. */  
      {  
         printf( "_putw failed" );  
         clearerr_s( stream );  
         exit( 1 );  
      }  
   }  
   printf( "Wrote ten words\n" );  
   fclose( stream );  
}  
```  
  
## Output  
  
```  
Wrote ten words  
```  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_getw](../vs140/_getw.md)