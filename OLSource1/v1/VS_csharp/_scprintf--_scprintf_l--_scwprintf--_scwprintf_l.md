---
title: "_scprintf, _scprintf_l, _scwprintf, _scwprintf_l"
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
  - "_scprintf_l"
  - "_scwprintf"
  - "_scwprintf_l"
  - "_scprintf"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "scprintf"
  - "_scprintf_l"
  - "_scwprintf_l"
  - "_scprintf"
  - "scwprintf"
  - "_scwprintf"
  - "scprintf_l"
  - "_sctprintf_l"
  - "scwprintf_l"
  - "_sctprintf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "scprintf function"
  - "sctprintf_l function"
  - "scwprintf_l function"
  - "_scwprintf_l function"
  - "_sctprintf_l function"
  - "sctprintf function"
  - "_scwprintf function"
  - "_scprintf_l function"
  - "_sctprintf function"
  - "scprintf_l function"
  - "formatted text [C++]"
  - "_scprintf function"
  - "scwprintf function"
ms.assetid: ecbb0ba6-5f4c-4ce6-a64b-144ad8b5fe92
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _scprintf, _scprintf_l, _scwprintf, _scwprintf_l
Returns the number of characters in the formatted string.  
  
## Syntax  
  
```  
int _scprintf(  
   const char *format [,  
   argument] ...   
);  
int _scprintf_l(  
   const char *format,  
   locale_t locale [,  
   argument] ...   
);  
int _scwprintf(  
   const wchar_t *format [,  
   argument] ...   
);  
int _scwprintf_l(  
   const wchar_t *format,  
   locale_t locale [,  
   argument] ...   
);  
```  
  
#### Parameters  
 `format`  
 Format-control string.  
  
 `argument`  
 Optional arguments.  
  
 `locale`  
 The locale to use.  
  
 For more information, see [Format Specifications](../VS_csharp/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 Returns the number of characters that would be generated if the string were to be printed or sent to a file or buffer using the specified formatting codes. The value returned does not include the terminating null character. `_scwprintf` performs the same function for wide characters.  
  
 If `format` is a `NULL` pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set `errno` to `EINVAL`.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each `argument` (if any) is converted according to the corresponding format specification in `format`. The format consists of ordinary characters and has the same form and function as the `format` argument for [printf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md).  
  
 The versions of these functions with the `_l` suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Ensure that `format` is not a user-defined string.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_sctprintf`|`_scprintf`|`_scprintf`|`_scwprintf`|  
|`_sctprintf_l`|`_scprintf_l`|`_scprintf_l`|`_scwprintf_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_scprintf`, `_scprintf_l`|<stdio.h>|  
|`_scwprintf`, `_scwprintf_l`|<stdio.h> or <wchar.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt__scprintf.c  
  
#define _USE_MATH_DEFINES  
  
#include <stdio.h>  
#include <math.h>  
#include <malloc.h>  
  
int main( void )  
{  
   int count;  
   int size;  
   char *s = NULL;  
  
   count = _scprintf( "The value of Pi is calculated to be %f.\n",  
                      M_PI);  
  
   size = count + 1; // the string will need one more char for the null terminator  
   s = malloc(sizeof(char) * size);  
   sprintf_s(s, size, "The value of Pi is calculated to be %f.\n",  
                      M_PI);  
   printf("The length of the following string will be %i.\n", count);  
   printf("%s", s);  
   free( s );  
}  
```  
  
 **The length of the following string will be 46.**  
**The value of Pi is calculated to be 3.141593.**   
## See Also  
 [Stream I/O](../VS_csharp/stream-i-o.md)   
 [fprintf, fwprintf](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, wprintf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf, wscanf](../VS_csharp/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../VS_csharp/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [vprintf Functions](../VS_csharp/vprintf-functions.md)