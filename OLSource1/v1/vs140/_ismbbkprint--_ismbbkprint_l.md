---
title: "_ismbbkprint, _ismbbkprint_l"
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
  - "_ismbbkprint"
  - "_ismbbkprint_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbkprint_l"
  - "ismbbkprint"
  - "_ismbbkprint"
  - "ismbbkprint_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbbkprint function"
  - "ismbbkprint_l function"
  - "ismbbkprint function"
  - "_ismbbkprint_l function"
ms.assetid: 8d1d3258-1e34-4365-81ed-97c95de25475
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbkprint, _ismbbkprint_l
Determines whether a particular multibyte character is a punctuation symbol.  
  
## Syntax  
  
```  
int _ismbbkprint(  
   unsigned int c   
);  
int _ismbbkprint_l(  
   unsigned int c,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `c`  
 Integer to be tested.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 `_ismbbkprint` returns a nonzero value if the integer `c` is a non-ASCII text or non-ASCII punctuation symbol or 0 if it is not. For example, in code page 932 only, `_ismbbkprint` tests for katakana alphanumeric or katakana punctuation (range: 0xA1 – 0xDF). `_ismbbkprint` uses the current locale for locale-dependent character settings. `_ismbbkprint_l` is identical except that it uses the locale passed in. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_ismbbkprint`|<mbctype.h>|  
|`_ismbbkprint_l`|<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)