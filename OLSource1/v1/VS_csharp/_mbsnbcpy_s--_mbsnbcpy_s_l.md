---
title: "_mbsnbcpy_s, _mbsnbcpy_s_l"
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
  - "_mbsnbcpy_s_l"
  - "_mbsnbcpy_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbcpy_s_l"
  - "_mbsnbcpy_s"
  - "mbsnbcpy_s"
  - "_mbsnbcpy_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbsnbcpy_s function"
  - "tcsncpy_s function"
  - "mbsnbcpy_s_l function"
  - "_tcsncpy_s_l function"
  - "mbsnbcpy_s function"
  - "tcsncpy_s_l function"
  - "_mbsnbcpy_s_l function"
  - "_tcsncpy_s function"
ms.assetid: dfff64ab-fe6f-49c4-99ba-75014e2b0cd6
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcpy_s, _mbsnbcpy_s_l
Copies `n` bytes of a string to a destination string. These versions of [_mbsnbcpy, _mbsnbcpy_l](../VS_csharp/_mbsnbcpy--_mbsnbcpy_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../VS_csharp/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
errno_t _mbsnbcpy_s(  
   unsigned char * strDest,  
   size_t sizeInBytes,  
   const unsigned char * strSource,  
   size_t count   
);  
errno_t _mbsnbcpy_s_l(  
   unsigned char * strDest,  
   size_t sizeInBytes,  
   const unsigned char * strSource,  
   size_t count,  
   _locale_t locale  
);  
template <size_t size>  
errno_t _mbsnbcpy_s(  
   unsigned char (&strDest)[size],  
   const unsigned char * strSource,  
   size_t count   
); // C++ only  
template <size_t size>  
errno_t _mbsnbcpy_s_l(  
   unsigned char (&strDest)[size],  
   const unsigned char * strSource,  
   size_t count,  
   _locale_t locale  
); // C++ only  
```  
  
#### Parameters  
 `strDest`  
 Destination for character string to be copied.  
  
 `sizeInBytes`  
 Destination buffer size.  
  
 `strSource`  
 Character string to be copied.  
  
 `count`  
 Number of bytes to be copied.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 Zero if successful; `EINVAL` if a bad parameter was passed in.  
  
## Remarks  
 The `_mbsnbcpy_s` function copies `count` bytes from `strSource` to `strDest`. If `count` exceeds the size of `strDest`, either of the input strings is a null pointer, or `sizeInBytes` or `count` is 0, the function invokes the invalid parameter handler as described in [Parameter Validation](../VS_csharp/parameter-validation.md) . If execution is allowed to continue, the function returns `EINVAL`. If the source and destination strings overlap, the behavior of `_mbsnbcpy_s` is undefined.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale](../VS_csharp/setlocale--_wsetlocale.md) for more information. The versions of these functions without the `_l` suffix use the current locale for this locale-dependent behavior; the versions with the `_l` suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../VS_csharp/locale.md).  
  
> [!NOTE]
>  Unlike the non-secure version of this function, `_mbsnbcpy_s` does not do any null padding and always null terminates the string.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../VS_csharp/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../VS_csharp/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_tcsncpy_s`|`_strncpy_s`|`_mbsnbcpy_s`|`_wcsncpy_s`|  
|`_tcsncpy_s_l`|`_strncpy_s_l`|`_mbsnbcpy_s_l`|`_wcsncpy_s_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbsnbcpy_s`|<mbstring.h>|  
|`_mbsnbcpy_s_l`|<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../VS_csharp/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../VS_csharp/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../VS_csharp/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_strncnt, _wcsncnt, _mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l](../VS_csharp/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)   
 [_mbsnbicmp, _mbsnbicmp_l](../VS_csharp/_mbsnbicmp--_mbsnbicmp_l.md)   
 [_mbsnbset, _mbsnbset_l](../VS_csharp/_mbsnbset--_mbsnbset_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../VS_csharp/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)