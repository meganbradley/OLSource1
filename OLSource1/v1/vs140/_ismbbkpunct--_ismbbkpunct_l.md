---
title: "_ismbbkpunct, _ismbbkpunct_l"
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
  - "_ismbbkpunct_l"
  - "_ismbbkpunct"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ismbbkpunct_l"
  - "_ismbbkpunct_l"
  - "ismbbkpunct"
  - "_ismbbkpunct"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbbkpunct_l function"
  - "ismbbkpunct_l function"
  - "ismbbkpunct function"
  - "_ismbbkpunct function"
ms.assetid: a04c59cd-5ca7-4296-bec0-2b0d7f04edd0
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbkpunct, _ismbbkpunct_l
Checks whether a multibyte character is a punctuation character.  
  
## Syntax  
  
```  
int _ismbbkpunct(  
   unsigned int c   
);  
int _ismbbkpunct_l(  
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
 `_ismbbkpunct` returns a nonzero value if the integer `c` is a non-ASCII punctuation symbol, or 0 if it is not. For example, in code page 932 only, `_ismbbkpunct` tests for katakana punctuation. `_ismbbkpunct` uses the current locale for any locale-dependent character settings. `_ismbbkpunct_l` is identical except that it uses the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_ismbbkpunct`|<mbctype.h>|  
|`_ismbbkpunct_l`|<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)