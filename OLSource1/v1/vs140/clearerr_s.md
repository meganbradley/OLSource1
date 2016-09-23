---
title: "clearerr_s"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - clearerr_s
apilocation: 
  - msvcr120.dll
  - msvcrt.dll
  - msvcr110.dll
  - msvcr110_clr0400.dll
  - msvcr100.dll
  - msvcr90.dll
  - msvcr80.dll
apitype: DLLExport
f1_keywords: 
  - clearerr_s
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - error indicator for streams
  - resetting stream error indicator
  - clearerr_s function
ms.assetid: b74d014d-b7a8-494a-a330-e5ffd5614772
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# clearerr_s
Resets the error indicator for a stream. This is a version of [clearerr](../vs140/clearerr.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
```  
errno_t clearerr_s(  
   FILE *stream   
);  
```  
  
#### Parameters  
 `stream`  
 Pointer to `FILE` structure  
  
## Return Value  
 Zero if successful; `EINVAL` if `stream` is NULL.  
  
## Remarks  
 The `clearerr_s` function resets the error indicator and end-of-file indicator for `stream`. Error indicators are not automatically cleared; once the error indicator for a specified stream is set, operations on that stream continue to return an error value until `clearerr_s`, `clearerr`, `fseek`, `fsetpos`, or `rewind` is called.  
  
 If `stream` is NULL, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets `errno` to `EINVAL` and returns `EINVAL`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`clearerr_s`|<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt_clearerr_s.c  
// This program creates an error  
// on the standard input stream, then clears  
// it so that future reads won't fail.  
  
#include <stdio.h>  
  
int main( void )  
{  
   int c;  
   errno_t err;  
  
   // Create an error by writing to standard input.  
   putc( 'c', stdin );  
   if( ferror( stdin ) )  
   {  
      perror( "Write error" );  
      err = clearerr_s( stdin );  
      if (err != 0)  
      {  
         abort();  
      }  
   }  
  
   // See if read causes an error.  
   printf( "Will input cause an error? " );  
   c = getc( stdin );  
   if( ferror( stdin ) )  
   {  
      perror( "Read error" );  
      err = clearerr_s( stdin );  
      if (err != 0)  
      {  
         abort();  
      }  
   }  
}  
```  
  
  **`n` `n`Write error: Bad file descriptor**  
**Will input cause an error? n**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Error Handling](../vs140/error-handling--crt-.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [clearerr](../vs140/clearerr.md)   
 [_eof](../vs140/_eof.md)   
 [feof](../vs140/feof.md)   
 [ferror](../vs140/ferror.md)   
 [perror, _wperror](../vs140/perror--_wperror.md)