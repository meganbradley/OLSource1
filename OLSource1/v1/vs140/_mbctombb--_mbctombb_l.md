---
title: "_mbctombb, _mbctombb_l"
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
  - "_mbctombb_l"
  - "_mbctombb"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbctombb_l"
  - "_mbctombb"
  - "mbctombb_l"
  - "mbctombb"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbctombb function"
  - "mbctombb_l function"
  - "mbctombb function"
  - "_mbctombb_l function"
ms.assetid: d90970b8-71ff-4586-b6a2-f9ceb811f776
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbctombb, _mbctombb_l
Converts a double-byte multibyte character to a corresponding single-byte multibyte character.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
unsigned int _mbctombb(  
   unsigned int c   
);  
unsigned int _mbctombb_l(  
   unsigned int c,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `c`  
 Multibyte character to convert.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 If successful, `_mbctombb` and `_mbctombb_l`returns the single-byte character that corresponds to `c`; otherwise it returns `c`.  
  
## Remarks  
 The `_mbctombb` and `_mbctombb_l`functions convert a given multibyte character to a corresponding single-byte multibyte character. Characters must correspond to single-byte characters within the range 0x20 – 0x7E or 0xA1 – 0xDF to be converted.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The version of this function without the `_l` suffix uses the current locale for this locale-dependent behavior; the version with the `_l` suffix is identical except that it use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In previous versions, `_mbctombb` was called `zentohan`. Use _`mbctombb` instead.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbctombb`|<mbstring.h>|  
|`_mbctombb_l`|<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_mbbtombc, _mbbtombc_l](../vs140/_mbbtombc--_mbbtombc_l.md)   
 [_mbcjistojms, _mbcjistojms_l, _mbcjmstojis, _mbcjmstojis_l](../vs140/_mbcjistojms--_mbcjistojms_l--_mbcjmstojis--_mbcjmstojis_l.md)   
 [_mbctohira, _mbctohira_l, _mbctokata, _mbctokata_l](../vs140/_mbctohira--_mbctohira_l--_mbctokata--_mbctokata_l.md)   
 [_mbctolower, _mbctolower_l, _mbctoupper, _mbctoupper_l](../vs140/_mbctolower--_mbctolower_l--_mbctoupper--_mbctoupper_l.md)