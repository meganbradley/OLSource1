---
title: "_ismbbprint, _ismbbprint_l"
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
  - "_ismbbprint_l"
  - "_ismbbprint"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbprint_l"
  - "_ismbbprint"
  - "ismbbprint"
  - "ismbbprint_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ismbbprint_l function"
  - "ismbbprint function"
  - "_ismbbprint function"
  - "_ismbbprint_l function"
ms.assetid: d08a061c-18a8-48f2-a75d-bff4870aec9d
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbprint, _ismbbprint_l
Determines whether a specified multibyte character is a print character.  
  
## Syntax  
  
```  
int _ismbbprint(  
   unsigned int c   
);  
int _ismbbprint_l(  
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
 `_ismbbprint` returns a nonzero value if the expression:  
  
```  
isprint || _ismbbkprint  
```  
  
 is nonzero for `c`, or 0 if it is not. `_ismbbprint` uses the current locale for any locale-dependent behavior. `_ismbbprint_l` is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_ismbbprint`|<mbctype.h>|  
|`_ismbbprint_l`|<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)