---
title: "atoll, _atoll_l, _wtoll, _wtoll_l"
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
  - "_wtoll"
  - "_atoll_l"
  - "_wtoll_l"
  - "atoll"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tstoll_l"
  - "_wtoll"
  - "_atoll_l"
  - "_ttoll"
  - "_tstoll"
  - "_wtoll_l"
  - "atoll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atoll function"
  - "_wtoll_l function"
  - "_wtoll function"
  - "_atoll_l function"
ms.assetid: 5e85fcac-b351-4882-bff2-6e7c469b7fa8
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atoll, _atoll_l, _wtoll, _wtoll_l
Converts a string to a `long long` integer.  
  
## Syntax  
  
```  
long long atoll(  
   const char *str   
);  
long long _wtoll(  
   const wchar_t *str   
);  
long long _atoll_l(  
   const char *str,  
   _locale_t locale  
);  
long long _wtoll_l(  
   const wchar_t *str,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `str`  
 String to be converted.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 Each function returns the `long long` value that's produced by interpreting the input characters as a number. The return value for `atoll` is 0 if the input cannot be converted to a value of that type.  
  
 For overflow with large positive integral values, `atoll` returns `LLONG_MAX`, and for overflow with large negative integral values, it returns `LLONG_MIN`.  
  
 In all out-of-range cases, `errno` is set to `ERANGE`. If the parameter that's passed in is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, these functions set `errno` to `EINVAL` and return 0.  
  
## Remarks  
 These functions convert a character string to a `long long` integer value.  
  
 The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. The function stops reading the input string at the first character that it cannot recognize as part of a number. This character might be the null character ('\0' or L'\0') that terminates the string.  
  
 The `str` argument to `atoll` has the following form:  
  
```  
[whitespace] [sign] [digits]  
```  
  
 A `whitespace` consists of space or tab characters, which are ignored; `sign` is either plus (+) or minus (–); and `digits` are one or more digits.  
  
 `_wtoll` is identical to `atoll` except that it takes a wide character string as a parameter.  
  
 The versions of these functions that have the `_l` suffix are identical to the versions that don't have it, except that they use the locale parameter that's passed in instead of the current locale. For more information, see [Locale](../VS_csharp/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_tstoll`|`atoll`|`atoll`|`_wtoll`|  
|`_tstoll_l`|`_atoll_l`|`_atoll_l`|`_wtoll_l`|  
|`_ttoll`|`_atoll`|`_atoll`|`_wtoll`|  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|`atoll`, `_atoll_l`|<stdlib.h>|  
|`_wtoll`, `_wtoll_l`|<stdlib.h> or <wchar.h>|  
  
## Example  
 This program shows how to use the `atoll` functions to convert numbers stored as strings to numeric values.  
  
```  
// crt_atoll.c  
// Build with: cl /W4 /Tc crt_atoll.c  
// This program shows how to use the atoll   
// functions to convert numbers stored as   
// strings to numeric values.  
#include <stdlib.h>  
#include <stdio.h>  
#include <errno.h>  
  
int main(void)  
{  
    char *str = NULL;  
    long long value = 0;  
  
    // An example of the atoll function  
    // with leading and trailing white spaces.  
    str = "  -27182818284 ";  
    value = atoll(str);  
    printf("Function: atoll(\"%s\") = %lld\n", str, value);  
  
    // Another example of the atoll function   
    // with an arbitrary decimal point.  
    str = "314127.64";  
    value = atoll(str);  
    printf("Function: atoll(\"%s\") = %lld\n", str, value);  
  
    // Another example of the atoll function  
    // with an overflow condition occurring.  
    str = "3336402735171707160320";  
    value = atoll(str);  
    printf("Function: atoll(\"%s\") = %lld\n", str, value);  
    if (errno == ERANGE)  
    {  
       printf("Overflow condition occurred.\n");  
    }  
}  
```  
  
 **Function: atoll("  -27182818284 ") = -27182818284**  
**Function: atoll("314127.64") = 314127**  
**Function: atoll("3336402735171707160320") = 9223372036854775807**  
**Overflow condition occurred.**   
## .NET Framework Equivalent  
  
-   [System::Convert::ToInt64](https://msdn.microsoft.com/en-us/library/system.convert.toint64.aspx)  
  
-   [System::Convert::ToUInt64](https://msdn.microsoft.com/en-us/library/system.convert.touint64.aspx)  
  
## See Also  
 [Data Conversion](../VS_csharp/data-conversion.md)   
 [Floating-Point Support](../VS_csharp/floating-point-support.md)   
 [Locale](../VS_csharp/locale.md)   
 [_ecvt](../VS_csharp/_ecvt.md)   
 [_fcvt](../VS_csharp/_fcvt.md)   
 [_gcvt](../VS_csharp/_gcvt.md)   
 [setlocale, _wsetlocale](../VS_csharp/setlocale--_wsetlocale.md)   
 [_atodbl, _atoldbl, _atoflt](../VS_csharp/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)