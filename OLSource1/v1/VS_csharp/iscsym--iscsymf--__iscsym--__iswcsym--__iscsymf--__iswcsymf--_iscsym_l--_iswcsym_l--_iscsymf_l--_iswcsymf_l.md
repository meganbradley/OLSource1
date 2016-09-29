---
title: "iscsym, iscsymf, __iscsym, __iswcsym, __iscsymf, __iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l"
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
  - "_iswcsym_l"
  - "__iswcsym"
  - "__iscsym"
  - "_iswcsymf_l"
  - "_iscsym_l"
  - "__iswcsymf"
  - "__iscsymf"
  - "_iscsymf_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_iswcsym_l"
  - "_iswcsymf_l"
  - "iscsymf"
  - "iswcsymf"
  - "__iswcsym"
  - "__iswcsymf"
  - "iscsym"
  - "iswcsym"
  - "__iscsym"
  - "_iscsym_l"
  - "_iscsymf_l"
  - "__iscsymf"
  - "ctype/iscsym"
  - "ctype/iscsymf"
  - "ctype/__iscsym"
  - "ctype/__iscsymf"
  - "ctype/__iscsym_l"
  - "ctype/__iscsymf_l"
  - "ctype/__iswcsym"
  - "ctype/__iswcsymf"
  - "ctype/__iswcsym_l"
  - "ctype/__iswcsymf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "iscsymf_l function"
  - "iswsym_l function"
  - "_iswcsym_l function"
  - "iscsym_l function"
  - "_iscsymf_l function"
  - "_iswcsymf_l function"
  - "_iscsym_l function"
  - "__iscsym function"
  - "__iswcsymf function"
  - "iswsymf_l function"
  - "__iscsymf function"
  - "__iswcsym function"
  - "iscsym function"
  - "iscsymf function"
ms.assetid: 944dfb99-f2b8-498c-9f55-dbcf370d0a2c
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# iscsym, iscsymf, __iscsym, __iswcsym, __iscsymf, __iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l
Determine if an integer represents a character that may be used in an identifier.  
  
## Syntax  
  
```  
int __iscsym(   
   int c   
);  
int __iswcsym(   
   wint_t c   
);  
int __iscsymf(   
   int c   
);  
int __iswcsymf(   
   wint_t c   
);  
int _iscsym_l(   
   int c,  
   _locale_t locale  
);  
int _iswcsym_l(   
   wint_t c,  
   _locale_t locale  
);  
int _iscsymf_l(   
   int c,  
   _locale_t locale  
);  
int _iswcsymf_l(   
   wint_t c,  
   _locale_t locale  
);  
#define iscsym __iscsym  
#define iscsymf __iscsymf  
```  
  
#### Parameters  
 `c`  
 Integer to test. `c` should be in the range of 0-255 for the narrow character version of the function.  
  
 `locale`  
 The locale to use.  
  
## Return Value  
 Both `__iscsym` and `__iswcsym` return a nonzero value if `c` is a letter, underscore, or digit. Both `__iscsymf` and `__iswcsymf` return a nonzero value if `c` is a letter or an underscore. Each of these routines returns 0 if `c` does not satisfy the test condition. The versions of these functions with the `_l` suffix are identical except that they use the locale passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../VS_csharp/locale.md).  
  
## Remarks  
 These routines are defined as macros unless the preprocessor macro _CTYPE_DISABLE_MACROS is defined. When you use the macro versions of these routines, the arguments can be evaluated more than once. Be careful when you use expressions that have side effects within the argument list.  
  
 For backward compatibility, `iscsym` and `iscsymf` are defined as macros only when [__STDC\_\_](../VS_csharp/predefined-macros.md) is not defined or is defined as 0; otherwise they are undefined.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`iscsym`, `iscsymf`, `__iscsym`, `__iswcsym`, `__iscsymf`, `__iswcsymf`, `_iscsym_l`, `_iswcsym_l`, `_iscsymf_l`, `_iswcsymf_l`|C: <ctype.h><br /><br /> C++: <cctype\> or <ctype.h>|  
  
 The `iscsym`, `iscsymf`, `__iscsym`, `__iswcsym`, `__iscsymf`, `__iswcsymf`, `_iscsym_l`, `_iswcsym_l`, `_iscsymf_l`, and `_iswcsymf_l` routines are Microsoft specific. For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## See Also  
 [Character Classification](../VS_csharp/character-classification.md)   
 [Locale](../VS_csharp/locale.md)   
 [is, isw Routines](../VS_csharp/is--isw-routines.md)