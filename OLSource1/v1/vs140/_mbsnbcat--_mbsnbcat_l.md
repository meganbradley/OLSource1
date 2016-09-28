---
title: "_mbsnbcat, _mbsnbcat_l"
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
  - "_mbsnbcat_l"
  - "_mbsnbcat"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbcat"
  - "mbsnbcat_l"
  - "_mbsnbcat"
  - "_mbsnbcat_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcsncat_l function"
  - "_tcsncat function"
  - "mbsnbcat_l function"
  - "mbsnbcat function"
  - "_mbsnbcat_l function"
  - "_tcsncat_l function"
  - "_mbsnbcat function"
  - "tcsncat function"
ms.assetid: aa0f1d30-0ddd-48d1-88eb-c6884b20fd91
caps.latest.revision: 33
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcat, _mbsnbcat_l
Appends, at most, the first `n` bytes of one multibyte-character string to another. More secure versions of these functions are available; see [_mbsnbcat_s, _mbsnbcat_s_l](../vs140/_mbsnbcat_s--_mbsnbcat_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
unsigned char *_mbsnbcat(  
   unsigned char *dest,  
   const unsigned char *src,  
   size_t count   
);  
unsigned char *_mbsnbcat_l(  
   unsigned char *dest,  
   const unsigned char *src,  
   size_t count,  
   _locale_t locale  
);  
template <size_t size>  
unsigned char *_mbsnbcat(  
   unsigned char (&dest)[size],  
   const unsigned char *src,  
   size_t count   
); // C++ only  
template <size_t size>  
unsigned char *_mbsnbcat_l(  
   unsigned char (&dest)[size],  
   const unsigned char *src,  
   size_t count,  
   _locale_t locale  
); // C++ only  
```  
  
#### Parameters  
 `dest`  
 Null-terminated multibyte-character destination string.  
  
 `src`  
 Null-terminated multibyte-character source string.  
  
 `count`  
 Number of bytes from `src` to append to `dest`.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 `_mbsnbcat` returns a pointer to the destination string. No return value is reserved to indicate an error.  
  
## Remarks  
 The `_mbsnbcat` function appends, at most, the first `count` bytes of `src` to `dest`. If the byte immediately preceding the null character in `dest` is a lead byte, the initial byte of `src` overwrites this lead byte. Otherwise, the initial byte of `src` overwrites the terminating null character of `dest`. If a null byte appears in `src` before `count` bytes are appended, _`mbsnbcat` appends all bytes from `src`, up to the null character. If `count` is greater than the length of `src`, the length of `src` is used in place of `count`. The resulting string is terminated with a null character. If copying takes place between strings that overlap, the behavior is undefined.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The `_mbsnbcat` version of the function uses the current locale for this locale-dependent behavior; the `_mbsnbcat_l` version is identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 **Security Note** Use a null-terminated string. The null-terminated string must not exceed the size of the destination buffer. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 If `dest` or `src` is `NULL`, the function will generate an invalid parameter error, as described in [Parameter Validation](../vs140/parameter-validation.md). If the error is handled, the function returns `EINVAL` and sets `errno` to `EINVAL`.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_tcsncat`|[strncat](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)|`_mbsnbcat`|[wcsncat](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)|  
|`_tcsncat_l`|`_strncat_l`|`_mbsnbcat_l`|`_wcsncat_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbsnbcat`|<mbstring.h>|  
|`_mbsnbcat_l`|<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_strncnt, _wcsncnt, _mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l](../vs140/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)   
 [_mbsnbcpy, _mbsnbcpy_l](../vs140/_mbsnbcpy--_mbsnbcpy_l.md)   
 [_mbsnbicmp, _mbsnbicmp_l](../vs140/_mbsnbicmp--_mbsnbicmp_l.md)   
 [_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [_mbsnbcat_s, _mbsnbcat_s_l](../vs140/_mbsnbcat_s--_mbsnbcat_s_l.md)