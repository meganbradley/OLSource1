---
title: "_mbbtombc, _mbbtombc_l"
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
  - "_mbbtombc_l"
  - "_mbbtombc"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbbtombc_l"
  - "_mbbtombc"
  - "mbbtombc_l"
  - "mbbtombc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbbtombc_l function"
  - "mbbtombc function"
  - "_mbbtombc_l function"
  - "_mbbtombc function"
ms.assetid: 78593389-b0fc-43b6-8c1f-2a6bf702d64e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbbtombc, _mbbtombc_l
Converts a single-byte multibyte character to a corresponding double-byte multibyte character.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
unsigned int _mbbtombc(  
   unsigned int c   
);  
unsigned int _mbbtombc_l(  
   unsigned int c,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `c`  
 Single-byte character to convert.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 If `_mbbtombc` successfully converts `c`, it returns a multibyte character; otherwise, it returns `c`.  
  
## Remarks  
 The `_mbbtombc` function converts a given single-byte multibyte character to a corresponding double-byte multibyte character. Characters must be within the range 0x20 – 0x7E or 0xA1 – 0xDF to be converted.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale, _wsetlocale](../VS_csharp/setlocale--_wsetlocale.md) for more information. The versions of this function are identical, except that `_mbbtombc` uses the current locale for this locale-dependent behavior and `_mbbtombc_l` instead uses the locale parameter that's passed in. For more information, see [Locale](../VS_csharp/locale.md).  
  
 In earlier versions, `_mbbtombc` was named `hantozen`. For new code, use `_mbbtombc`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbbtombc`|<mbstring.h>|  
|`_mbbtombc_l`|<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../VS_csharp/data-conversion.md)   
 [_mbctombb, _mbctombb_l](../VS_csharp/_mbctombb--_mbctombb_l.md)