---
title: "_ismbbtrail, _ismbbtrail_l"
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
  - "_ismbbtrail"
  - "_ismbbtrail_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbtrail"
  - "ismbbtrail"
  - "_ismbbtrail_l"
  - "ismbbtrail_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ismbbtrail_l function"
  - "_ismbbtrail function"
  - "_ismbbtrail_l function"
  - "ismbbtrail function"
ms.assetid: dfdd0292-960b-4c1d-bf11-146e0fc80247
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbtrail, _ismbbtrail_l
Determines whether a byte is a trailing byte of a multibyte character.  
  
## Syntax  
  
```  
int _ismbbtrail(  
   unsigned int c   
);  
int _ismbbtrail_l(  
   unsigned int c,  
   _locale_t locale   
);  
```  
  
#### Parameters  
 `c`  
 The integer to be tested.  
  
 `locale`  
 The locale to use.  
  
## Return Value  
 `_ismbbtrail` returns a nonzero value if the integer `c` is the second byte of a multibyte character. For example, in code page 932 only, valid ranges are 0x40 to 0x7E and 0x80 to 0xFC.  
  
## Remarks  
 `_ismbbtrail` uses the current locale for locale-dependent behavior. `_ismbbtrail_l` is identical except that it uses the locale that's passed in instead. For more information, see [Locale](../VS_csharp/locale.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|`_ismbbtrail`|<mbctype.h> or <mbstring.h>|<ctype.h>,* <limits.h>, <stdlib.h>|  
|`_ismbbtrail_l`|<mbctype.h> or <mbstring.h>|<ctype.h>,* <limits.h>, <stdlib.h>|  
  
 \* For manifest constants for the test conditions.  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../VS_csharp/byte-classification.md)   
 [_ismbb Routines](../VS_csharp/_ismbb-routines.md)