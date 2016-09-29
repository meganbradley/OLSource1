---
title: "cexp, cexpf, cexpl"
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
  - "cexp"
  - "cexpf"
  - "cexpl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cexp"
  - "cexpf"
  - "cexpl"
  - "complex/cepx"
  - "complex/cexpf"
  - "complex/cexpl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "cexp function"
  - "cexpl function"
  - "cexpf function"
ms.assetid: f27fd5a9-70c7-4957-a7ee-5256d19bd1da
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cexp, cexpf, cexpl
Compute the base-e exponential of a complex number.  
  
## Syntax  
  
```  
_Dcomplex cexp(   
   _Dcomplex z   
);  
_Fcomplex cexp(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex cexp(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex cexpf(   
  _Fcomplex z   
);  
_Lcomplex cexpl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents the exponent.  
  
## Return Value  
 The value of `e` raised to the power of `z`.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `cexp` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `cexp` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`cexp`,               `cexpf`, `cexpl`|<complex.h>|<complex.h>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [cpow, cpowf, cpowl](../vs140/cpow--cpowf--cpowl.md)   
 [clog10, clog10f, clog10l](../vs140/clog10--clog10f--clog10l.md)   
 [clog, clogf, clogl](../vs140/clog--clogf--clogl.md)