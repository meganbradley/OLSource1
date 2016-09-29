---
title: "isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l"
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
  - "_iswxdigit_l"
  - "iswxdigit"
  - "isxdigit"
  - "_isxdigit_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "iswxdigit"
  - "isxdigit"
  - "_istxdigit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "isxdigit function"
  - "istxdigit function"
  - "_iswxdigit_l function"
  - "_istxdigit function"
  - "_isxdigit_l function"
  - "iswxdigit_l function"
  - "isxdigit_l function"
  - "hexadecimal characters"
  - "iswxdigit function"
ms.assetid: c8bc5146-0b58-4e3f-bee3-f2318dd0f829
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l
Determines whether an integer represents a character that is a hexadecimal digit.  
  
## Syntax  
  
```  
int isxdigit(  
   int c   
);  
int iswxdigit(  
   wint_t c   
);  
int _isxdigit_l(  
   int c,  
   _locale_t locale  
);  
int _iswxdigit_l(  
   wint_t c,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `c`  
 Integer to test.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if `c` is a particular representation of a hexadecimal digit. `isxdigit` returns a nonzero value if `c` is a hexadecimal digit (A – F, a – f, or 0 – 9). `iswxdigit` returns a nonzero value if `c` is a wide character that corresponds to a hexadecimal digit character. Each of these routines returns 0 if `c` does not satisfy the test condition.  
  
 For the "C" locale, the `iswxdigit` function does not support Unicode full-width hexadecimal characters.  
  
 The versions of these functions that have the `_l` suffix use the locale that's passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../VS_csharp/locale.md).  
  
 The behavior of `isxdigit` and `_isxdigit_l` is undefined if `c` is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and `c` is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_istxdigit`|`isxdigit`|`isxdigit`|`iswxdigit`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`isxdigit`|<ctype.h>|  
|`iswxdigit`|<ctype.h> or <wchar.h>|  
|`_isxdigit_l`|<ctype.h>|  
|`_iswxdigit_l`|<ctype.h> or <wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsNumber](https://msdn.microsoft.com/en-us/library/system.char.isnumber.aspx)  
  
## See Also  
 [Character Classification](../VS_csharp/character-classification.md)   
 [Locale](../VS_csharp/locale.md)   
 [is, isw Routines](../VS_csharp/is--isw-routines.md)