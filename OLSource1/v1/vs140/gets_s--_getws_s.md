---
title: "gets_s, _getws_s"
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
  - "_getws_s"
  - "gets_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getws_s"
  - "gets_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "getws_s function"
  - "_getws_s function"
  - "lines, getting"
  - "streams, getting lines"
  - "buffers, avoiding overruns"
  - "buffer overruns"
  - "buffers, buffer overruns"
  - "gets_s function"
  - "standard input, reading from"
ms.assetid: 5880c36f-122c-4061-a1a5-aeeced6fe58c
caps.latest.revision: 31
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gets_s, _getws_s
Gets a line from the `stdin` stream. These versions of [gets, _getws](../vs140/gets--_getws.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
```  
char *gets_s(   
   char *buffer,  
   size_t sizeInCharacters  
);  
wchar_t *_getws_s(   
   wchar_t *buffer,  
   size_t sizeInCharacters  
);  
template <size_t size>  
char *gets_s(   
   char (&buffer)[size]  
); // C++ only  
template <size_t size>  
wchar_t *_getws_s(   
   wchar_t (&buffer)[size]  
); // C++ only  
```  
  
#### Parameters  
 [out] `buffer`  
 Storage location for input string.  
  
 [in] `sizeInCharacters`  
 The size of the buffer.  
  
## Return Value  
 Returns `buffer` if successful. A `NULL` pointer indicates an error or end-of-file condition. Use [ferror](../vs140/ferror.md) or [feof](../vs140/feof.md) to determine which one has occurred.  
  
## Remarks  
 The `gets_s` function reads a line from the standard input stream `stdin` and stores it in `buffer`. The line consists of all characters up to and including the first newline character ('\n'). `gets_s` then replaces the newline character with a null character ('\0') before returning the line. In contrast, the `fgets_s` function retains the newline character.  
  
 If the first character read is the end-of-file character, a null character is stored at the beginning of `buffer` and `NULL` is returned.  
  
 `_getws` is a wide-character version of `gets_s`; its argument and return value are wide-character strings.  
  
 If `buffer` is `NULL` or `sizeInCharacters` is less than or equal to zero, or if the buffer is too small to contain the input line and null terminator, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return `NULL` and set errno to `ERANGE`.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_getts`|`gets_s`|`gets_s`|`_getws`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`gets_s`|<stdio.h>|  
|`_getws`|<stdio.h> or <wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—`stdin`, `stdout`, and `stderr`—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_gets_s.c  
// This program retrieves a string from the stdin and   
// prints the same string to the console.  
  
#include <stdio.h>  
  
int main( void )  
{  
   char line[21]; // room for 20 chars + '\0'  
   gets_s( line, 20 );  
   printf( "The line entered was: %s\n", line );  
}  
```  
  
  **`Hello there!`The line entered was: Hello there!**   
## .NET Framework Equivalent  
 [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [gets, _getws](../vs140/gets--_getws.md)   
 [fgets, fgetws](../vs140/fgets--fgetws.md)   
 [fputs, fputws](../vs140/fputs--fputws.md)   
 [puts, _putws](../vs140/puts--_putws.md)