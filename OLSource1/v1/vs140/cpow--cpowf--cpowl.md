---
title: "cpow, cpowf, cpowl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "cpow"
  - "cpowf"
  - "cpowl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cpow"
  - "cpowf"
  - "cpowl"
  - "complex/cpow"
  - "complex/cpowf"
  - "complex/copwl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "cpow function"
  - "cpowf function"
  - "complex/cpowl function"
ms.assetid: 83fe2187-22b7-4295-ab16-4d77abdbb80b
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cpow, cpowf, cpowl
Retrieves the value of a number raised to the specified power, where the base and exponent are complex numbers. This function has a branch cut for the exponent along the negative real axis.  
  
## Syntax  
  
```  
_Dcomplex cpow(   
   _Dcomplex x, _Dcomplex y   
);  
_Fcomplex cpow(   
   _Fcomplex x, _Fcomplex y   
);  // C++ only  
_Lcomplex cpow(   
   _Lcomplex x, _Lcomplex y   
);  // C++ only  
_Fcomplex cpowf(   
   _Fcomplex x, _Fcomplex y   
);  
_Lcomplex cpowl(   
   _Lcomplex x, _Lcomplex y   
);  
```  
  
#### Parameters  
 `x`  
 The base.  
  
 `y`  
 The exponent.  
  
## Return Value  
 The value of `x` raised to the power of `y` with a branch cut for `x` along the negative real axis.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `cpow` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `cpow` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`cpow`,               `cpowf`, `cpowl`|<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [cexp, cexpf, cexpl](../vs140/cexp--cexpf--cexpl.md)   
 [clog10, clog10f, clog10l](../vs140/clog10--clog10f--clog10l.md)   
 [clog, clogf, clogl](../vs140/clog--clogf--clogl.md)