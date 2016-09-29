---
title: "cimag, cimagf, cimagl"
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
  - "cimag"
  - "cimagf"
  - "cimagl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cimagf"
  - "cimagl"
  - "complex/cimag"
  - "complex/cimagf"
  - "complex/cimagl"
  - "cimag"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "cimag function"
  - "cimagf function"
  - "cimagl function"
ms.assetid: 0d8836f5-d61d-44cd-8731-6f75cb776def
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cimag, cimagf, cimagl
Retrieves the imaginary part of a complex number.  
  
## Syntax  
  
```  
double cimag(   
   _Dcomplex z   
);  
float cimag(   
   _Fcomplex z   
);  // C++  
long double cimag(   
  _Lcomplex z   
);  // C++  
float cimagf(   
   _Fcomplex z   
);  
long double cimagl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number.  
  
## Return Value  
 The imaginary part of `z`.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `cimag` that take `_Fcomplex` or `_Lcomplex` values, and return `float` or `long double` values. In a C program, `cimag` always takes a `_Dcomplex` value and returns a `double` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`cimag`,               `cimagf`, `cimagl`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [norm, normf, norml](../VS_csharp/norm--normf--norml.md)   
 [creal, crealf, creall](../VS_csharp/creal--crealf--creall.md)   
 [cproj, cprojf, cprojl](../VS_csharp/cproj--cprojf--cprojl.md)   
 [conj, conjf, conjl](../VS_csharp/conj--conjf--conjl.md)   
 [carg, cargf, cargl](../VS_csharp/carg--cargf--cargl.md)   
 [cabs, cabsf, cabsl](../VS_csharp/cabs--cabsf--cabsl.md)