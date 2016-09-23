---
title: "_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr_l, _wcsupr"
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
  - _mbsupr_l
  - _mbsupr
  - _strupr_l
  - _wcsupr
  - _wcsupr_l
  - _strupr
apilocation: 
  - msvcrt.dll
  - msvcr80.dll
  - msvcr110_clr0400.dll
  - msvcr110.dll
  - msvcr120.dll
  - msvcr100.dll
  - msvcr90.dll
apitype: DLLExport
f1_keywords: 
  - _mbsupr
  - _ftcsupr
  - mbsupr
  - _tcsupr
  - strupr_l
  - _fstrupr
  - _strupr
  - mbsupr_l
  - _wcsupr
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - tcsupr_l function
  - mbsupr function
  - strupr function
  - uppercase, converting strings to
  - wcsupr function
  - _wcsupr function
  - string conversion [C++], case
  - ftcsupr function
  - _ftcsupr function
  - _wcsupr_l function
  - wcsupr_l function
  - strings [C++], case
  - tcsupr function
  - _tcsupr_l function
  - _fstrupr function
  - _strupr_l function
  - _mbsupr_l function
  - converting case, CRT functions
  - fstrupr function
  - mbsupr_l function
  - strupr_l function
  - _strupr function
  - _mbsupr function
  - _tcsupr function
  - strings [C++], converting case
ms.assetid: caac8f16-c233-41b6-91ce-575ec7061b77
caps.latest.revision: 30
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr_l, _wcsupr
Converts a string to uppercase. More secure versions of these functions are available; see [_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../vs140/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md).  
  
> [!IMPORTANT]
>  `_mbsupr` and `_mbsupr_l` cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
char *_strupr(  
   char *str   
);  
wchar_t *_wcsupr(  
   wchar_t *str   
);  
unsigned char *_mbsupr(  
   unsigned char *str   
);  
char *_strupr_l(  
   char *str,  
   _locale_t locale  
);  
wchar_t *_wcsupr_l(  
   wchar_t *str,  
   _locale_t locale  
);  
unsigned char *_mbsupr_l(  
   unsigned char *str,  
   _locale_t locale  
);  
template <size_t size>  
char *_strupr(  
   char (&str)[size]  
); // C++ only  
template <size_t size>  
wchar_t *_wcsupr(  
   wchar_t (&str)[size]  
); // C++ only  
template <size_t size>  
unsigned char *_mbsupr(  
   unsigned char (&str)[size]  
); // C++ only  
template <size_t size>  
char *_strupr_l(  
   char (&str)[size],  
   _locale_t locale  
); // C++ only  
template <size_t size>  
wchar_t *_wcsupr_l(  
   wchar_t (&str)[size],  
   _locale_t locale  
); // C++ only  
template <size_t size>  
unsigned char *_mbsupr_l(  
   unsigned char (&str)[size],  
   _locale_t locale  
); // C++ only  
```  
  
#### Parameters  
 `str`  
 String to capitalize.  
  
 `locale`  
 The locale to use.  
  
## Return Value  
 Returns a pointer to the altered string. Because the modification is done in place, the pointer returned is the same as the pointer passed as the input argument. No return value is reserved to indicate an error.  
  
## Remarks  
 The `_strupr` function converts, in place, each lowercase letter in `str` to uppercase. The conversion is determined by the `LC_CTYPE` category setting of the locale. Other characters are not affected. For more information on `LC_CTYPE`, see [setlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions without the `_l` suffix use the current locale; the versions with the `_l` suffix are identical except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 `_wcsupr` and `_mbsupr` are wide-character and multibyte-character versions of `_strupr`. The argument and return value of `_wcsupr` are wide-character strings; those of `_mbsupr` are multibyte-character strings. These three functions behave identically otherwise.  
  
 If `str` is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions return the original string and set `errno` to `EINVAL`.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_tcsupr`|`_strupr`|`_mbsupr`|`_wcsupr`|  
|`_tcsupr_l`|`_strupr_l`|`_mbsupr_l`|`_wcsupr_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_strupr`, `_strupr_l`|<string.h>|  
|`_wcsupr`, `_wcsupr_l`|<string.h> or <wchar.h>|  
|`_mbsupr`, `_mbsupr_l`|<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [_strlwr](../vs140/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md).  
  
## .NET Framework Equivalent  
 [System::String::ToUpper](https://msdn.microsoft.com/en-us/library/system.string.toupper.aspx)  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_strlwr, _wcslwr, _mbslwr, _strlwr_l, _wcslwr_l, _mbslwr_l](../vs140/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md)