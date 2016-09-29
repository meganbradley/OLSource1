---
title: "creal, crealf, creall"
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
  - "creal"
  - "crealf"
  - "creall"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "creal"
  - "crealf"
  - "creall"
  - "complex/creal"
  - "complex/crealf"
  - "complex/creall"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "creal function"
  - "crealf function"
  - "creall function"
ms.assetid: fa3ac62f-7aa3-4238-a71f-d6b00cd0c7c8
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# creal, crealf, creall
Retrieves the real part of a complex number.  
  
## Syntax  
  
```  
double creal(   
   _Dcomplex z   
);  
float creal(   
   _Fcomplex z   
);  // C++ only  
long double creal(   
   _Lcomplex z   
);  // C++ only  
float crealf(   
   _Fcomplex z   
);  
long double creall(   
  _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number.  
  
## Return Value  
 The real part of `z`.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `creal` that take `_Fcomplex` or `_Lcomplex` values, and return `float` or `long double` values. In a C program, `creal` always takes a `_Dcomplex` value and returns a `double` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`creal`,               `crealf`, `creall`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [norm, normf, norml](../VS_csharp/norm--normf--norml.md)   
 [cproj, cprojf, cprojl](../VS_csharp/cproj--cprojf--cprojl.md)   
 [conj, conjf, conjl](../VS_csharp/conj--conjf--conjl.md)   
 [cimag, cimagf, cimagl](../VS_csharp/cimag--cimagf--cimagl.md)   
 [carg, cargf, cargl](../VS_csharp/carg--cargf--cargl.md)   
 [cabs, cabsf, cabsl](../VS_csharp/cabs--cabsf--cabsl.md)