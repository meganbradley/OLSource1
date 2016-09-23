---
title: "_strinc, _wcsinc, _mbsinc, _mbsinc_l"
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
  - _mbsinc
  - _wcsinc
  - _mbsinc_l
  - _strinc
apilocation: 
  - msvcrt.dll
  - msvcr100.dll
  - msvcr90.dll
  - msvcr110_clr0400.dll
  - msvcr80.dll
  - msvcr110.dll
  - msvcr120.dll
apitype: DLLExport
f1_keywords: 
  - mbsinc_l
  - _strinc
  - strinc
  - _mbsinc
  - _wcsinc
  - wcsinc
  - mbsinc
  - _mbsinc_l
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - _mbsinc function
  - wcsinc function
  - mbsinc_l function
  - _strinc function
  - strinc function
  - _mbsinc_l function
  - mbsinc function
  - _wcsinc function
  - _tcsinc function
  - tcsinc function
ms.assetid: 54685943-8e2c-45e9-a559-2d94930dc6b4
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _strinc, _wcsinc, _mbsinc, _mbsinc_l
Advances a string pointer by one character.  
  
> [!IMPORTANT]
>  `_mbsinc` and `_mbsinc_l` cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
char *_strinc(  
   const char *current,  
   _locale_t locale  
);  
wchar_t *_wcsinc(  
   const wchar_t *current,  
   _locale_t locale  
);  
unsigned char *_mbsinc(  
   const unsigned char *current   
);  
unsigned char *_mbsinc_l(  
   const unsigned char *current,  
   _locale_t locale  
);  
  
```  
  
#### Parameters  
 `current`  
 Character pointer.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 Each of these routines returns a pointer to the character that immediately follows `current`.  
  
## Remarks  
 The `_mbsinc` function returns a pointer to the first byte of the multibyte character that immediately follows `current`. `_mbsinc` recognizes multibyte-character sequences according to the [multibyte code page](../vs140/code-pages.md) that's currently in use; `_mbsinc_l` is identical except that it instead uses the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 The generic-text function `_tcsinc`, defined in Tchar.h, maps to `_mbsinc` if `_MBCS` has been defined, or to `_wcsinc` if `_UNICODE` has been defined. Otherwise, `_tcsinc` maps to `_strinc`. `_strinc` and `_wcsinc` are single-byte-character and wide-character versions of `_mbsinc`. `_strinc` and `_wcsinc` are provided only for this mapping and should not be used otherwise. For more information, see [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md) and [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
 If `current` is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns `EINVAL` and sets `errno` to `EINVAL`.  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used for system attacks because they can cause an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbsinc`|<mbstring.h>|  
|`_mbsinc_l`|<mbstring.h>|  
|`_strinc`|<tchar.h>|  
|`_wcsinc`|<tchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_strdec, _wcsdec, _mbsdec, _mbsdec_l](../vs140/_strdec--_wcsdec--_mbsdec--_mbsdec_l.md)   
 [_strnextc, _wcsnextc, _mbsnextc, _mbsnextc_l](../vs140/_strnextc--_wcsnextc--_mbsnextc--_mbsnextc_l.md)   
 [_strninc, _wcsninc, _mbsninc, _mbsninc_l](../vs140/_strninc--_wcsninc--_mbsninc--_mbsninc_l.md)