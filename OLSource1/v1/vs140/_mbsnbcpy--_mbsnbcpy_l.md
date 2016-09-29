---
title: "_mbsnbcpy, _mbsnbcpy_l"
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
  - "_mbsnbcpy"
  - "_mbsnbcpy_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbcpy"
  - "_ftcsncpy"
  - "_mbsnbcpy"
  - "mbsnbcpy_l"
  - "_mbsnbcpy_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsnbcpy function"
  - "_mbsnbcpy_l function"
  - "_mbsnbcpy function"
  - "_tcsncpy function"
  - "tcsncpy_l function"
  - "_tcsncpy_l function"
  - "mbsnbcpy_l function"
  - "tcsncpy function"
ms.assetid: 83d17b50-3cbf-4df9-bce8-3b6d52f85d04
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcpy, _mbsnbcpy_l
Copies `n` bytes of a string to a destination string. More secure versions of these functions are available—see [_mbsnbcpy_s, _mbsnbcpy_s_l](../vs140/_mbsnbcpy_s--_mbsnbcpy_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/en-us/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
unsigned char * _mbsnbcpy(  
   unsigned char * strDest,  
   const unsigned char * strSource,  
   size_t count  
);  
unsigned char * _mbsnbcpy_l(  
   unsigned char * strDest,  
   const unsigned char * strSource,  
   size_t count,  
   _locale_t locale  
);  
template <size_t size>  
unsigned char * _mbsnbcpy(  
   unsigned char (&strDest)[size],  
   const unsigned char * strSource,  
   size_t count  
); // C++ only  
template <size_t size>  
unsigned char * _mbsnbcpy_l(  
   unsigned char (&strDest)[size],  
   const unsigned char * strSource,  
   size_t count,  
   _locale_t locale  
); // C++ only  
```  
  
#### Parameters  
 `strDest`  
 Destination for the character string to be copied.  
  
 `strSource`  
 Character string to be copied.  
  
 `count`  
 Number of bytes to be copied.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 `_mbsnbcpy` returns a pointer to the destination character string. No return value is reserved to indicate an error.  
  
## Remarks  
 The `_mbsnbcpy` function copies `count` bytes from `strSource` to `strDest`. If `count` exceeds the size of `strDest` or the source and destination strings overlap, the behavior of `_mbsnbcpy` is undefined.  
  
 If `strSource` or `strDest` is a null pointer, this function invokes the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns `NULL` and sets `errno` to `EINVAL`.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that those that don't have the `_l` suffix use the current locale and the versions that do have the `_l` suffix instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used to execute arbitrary attacker code, which can cause an unwarranted elevation of privilege and compromise the system. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 In C++, these functions have template overloads that invoke the newer, more secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_tcsncpy`|[strncpy](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)|`_mbsnbcpy`|[wcsncpy](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)|  
|`_tcsncpy_l`|`_strncpy_l`|`_mbsnbcp_l`|`_wcsncpy_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbsnbcpy`|<mbstring.h>|  
|`_mbsnbcpy_l`|<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_strncnt, _wcsncnt, _mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l](../vs140/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)   
 [_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)