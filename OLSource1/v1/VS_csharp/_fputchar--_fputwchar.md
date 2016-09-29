---
title: "_fputchar, _fputwchar"
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
  - "_fputchar"
  - "_fputwchar"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fputtchar"
  - "_fputwchar"
  - "fputwchar"
  - "_fputtchar"
  - "fputchar"
  - "_fputchar"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fputchar function"
  - "standard output, writing to"
  - "_fputtchar function"
  - "fputwchar function"
  - "_fputwchar function"
  - "fputtchar function"
  - "_fputchar function"
ms.assetid: b92ff600-a924-4f2b-b0e7-3097ee31bdff
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fputchar, _fputwchar
Writes a character to `stdout`.  
  
## Syntax  
  
```  
int _fputchar(  
   int c   
);  
wint_t _fputwchar(  
   wchar_t c   
);  
```  
  
#### Parameters  
 `c`  
 Character to be written.  
  
## Return Value  
 Each of these functions returns the character written. For `_fputchar`, a return value of `EOF` indicates an error. For `_fputwchar`, a return value of `WEOF` indicates an error. If c is `NULL`, these functions generate an invalid parameter exception, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, they return `EOF`(or`WEOF`) and set `errno` to `EINVAL`.  
  
 For more information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Both of these functions writes the single character `c` to `stdout` and advances the indicator as appropriate. `_fputchar` is equivalent to `fputc(``stdout )`. It is also equivalent to `putchar`, but implemented only as a function, rather than as a function and a macro. Unlike `fputc` and `putchar`, these functions are not compatible with the ANSI standard.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_fputtchar`|`_fputchar`|`_fputchar`|`_fputwchar`|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_fputchar`|<stdio.h>|  
|`_fputwchar`|<stdio.h> or <wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—`stdin`, `stdout`, and `stderr`—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] apps. For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
  
```  
// crt_fputchar.c  
// This program uses _fputchar  
// to send a character array to stdout.  
  
#include <stdio.h>  
  
int main( void )  
{  
    char strptr[] = "This is a test of _fputchar!!\n";  
    char *p = NULL;  
  
    // Print line to stream using _fputchar.   
    p = strptr;  
    while( (*p != '\0') && _fputchar( *(p++) ) != EOF )  
      ;  
}  
```  
  
 **This is a test of _fputchar!!**   
## .NET Framework Equivalent  
  
-   [System::IO::StreamWriter::Write](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.write.aspx)  
  
-   [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../VS_csharp/stream-i-o.md)   
 [fgetc, fgetwc](../VS_csharp/fgetc--fgetwc.md)   
 [putc, putwc](../VS_csharp/putc--putwc.md)