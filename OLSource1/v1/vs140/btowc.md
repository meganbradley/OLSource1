---
title: "btowc"
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
  - "btowc"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "btowc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "btowc function"
ms.assetid: 99a46e02-6f86-4569-af79-5feca012add8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# btowc
Determine whether an integer represents a valid single-byte character in the initial shift state.  
  
## Syntax  
  
```  
wint_t btowc(  
   int c  
);  
```  
  
#### Parameters  
 `c`  
 Integer to test.  
  
## Return Value  
 Returns the wide-character representation of the character if the integer represents a valid single-byte character in the initial shift state. Returns WEOF if the integer is EOF or is not a valid single-byte character in the initial shift state. The output of this function is affected by the current `LC_TYPE` locale.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`btowc`|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)