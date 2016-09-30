---
title: "toascii, __toascii"
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
  - "__toascii"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
  - "ntdll.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__toascii"
  - "toascii"
  - "ctype/toascii"
  - "ctype/__toascii"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "toascii function"
  - "string conversion, to ASCII characters"
  - "__toascii function"
  - "ASCII characters, converting to"
ms.assetid: a07c0608-b0e2-4da2-a20c-7b64d6a9b77c
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# toascii, __toascii
Converts characters to 7-bit ASCII by truncation.  
  
## Syntax  
  
```  
int __toascii(  
   int c   
);  
#define toascii __toascii  
```  
  
#### Parameters  
 `c`  
 Character to convert.  
  
## Return Value  
 `__toascii` converts the value of `c` to the 7-bit ASCII range and returns the result. There is no return value reserved to indicate an error.  
  
## Remarks  
 The `__toascii` routine converts the given character to an ASCII character by truncating it to the low-order 7 bits. No other transformation is applied.  
  
 The `__toascii` routine is defined as a macro unless the preprocessor macro _CTYPE_DISABLE_MACROS is defined. For backward compatibility, `toascii` is defined as a macro only when [__STDC\_\_](../vs140/predefined-macros.md) is not defined or is defined as 0; otherwise it is undefined.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`toascii`, `__toascii`|C: \<ctype.h>\<br />\<br /> C++: \<cctype> or \<ctype.h>|  
  
 The `toascii` macro is a POSIX extension, and `__toascii` is a Microsoft-specific implementation of the POSIX extension. For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [to Functions](../vs140/to-functions.md)