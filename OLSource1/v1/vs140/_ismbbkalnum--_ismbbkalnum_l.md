---
title: "_ismbbkalnum, _ismbbkalnum_l"
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
  - "_ismbbkalnum"
  - "_ismbbkalnum_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbkalnum"
  - "ismbbkalnum"
  - "ismbbkalnum_l"
  - "_ismbbkalnum_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbbkalnum_l function"
  - "ismbbkalnum_l function"
  - "_ismbbkalnum function"
  - "ismbbkalnum function"
ms.assetid: e1d70e7b-29d0-469c-9d93-442b99de22ac
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbkalnum, _ismbbkalnum_l
Determines whether a particular multibyte character is a non-ASCII text symbol.  
  
## Syntax  
  
```  
int _ismbbkalnum(  
   unsigned int c   
);  
int _ismbbkalnum_l(  
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
 `_ismbbkalnum` returns a nonzero value if the integer `c` is a non-ASCII text symbol other than punctuation, or 0 if it is not. `_ismbbkalnum` uses the current locale for locale-dependent character information. `_ismbbkalnum_l` is identical to `_ismbbkalnum` except that it takes the locale as a parameter. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_ismbbkalnum`|<mbctype.h>|  
|`_ismbbkalnum_l`|<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)