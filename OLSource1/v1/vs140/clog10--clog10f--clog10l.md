---
title: "clog10, clog10f, clog10l"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - cpp
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - clog10
  - clog10f
  - clog10l
apilocation: 
  - msvcr120.dll
  - api-ms-win-crt-math-l1-1-0.dll
apitype: DLLExport
f1_keywords: 
  - clog10
  - clog10f
  - clog10l
  - complex/clog10
  - complex/clog10f
  - complex/clog10l
dev_langs: 
  - C
  - C++
helpviewer_keywords: 
  - clog10 function
  - clog10f function
  - clog10l function
ms.assetid: 2ddae00d-ef93-4441-add3-f4d58358401b
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# clog10, clog10f, clog10l
Retrieves the base 10 logarithm of a complex number.  
  
## Syntax  
  
```  
_Dcomplex clog10(   
   _Dcomplex z   
);  
_Fcomplex clog10(   
  _Fcomplex z   
);  // C++ only  
_Lcomplex clog10(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex clog10f(   
   _Fcomplex z   
);  
_Lcomplex clog10l(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 The base of the logarithm.  
  
## Return Value  
 The possible return values are:  
  
|z parameter|Return value|  
|-----------------|------------------|  
|Positive|The base 10 logarithm of z|  
|Zero|- ∞|  
|Negative|NaN|  
|NaN|NaN|  
|+ ∞|+ ∞|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `clog10` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `clog10` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`clog10`,               `clog10f`, `clogl`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [cexp, cexpf, cexpl](../vs140/cexp--cexpf--cexpl.md)   
 [cpow, cpowf, cpowl](../vs140/cpow--cpowf--cpowl.md)   
 [clog, clogf, clogl](../vs140/clog--clogf--clogl.md)