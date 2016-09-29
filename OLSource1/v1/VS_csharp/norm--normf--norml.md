---
title: "norm, normf, norml"
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
  - "norm"
  - "normf"
  - "norml"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "norm"
  - "normf"
  - "norml"
  - "complex/norm"
  - "complex/normf"
  - "complex/norml"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "norm function"
  - "normf function"
  - "norml function"
ms.assetid: 9786ecfe-0019-4553-b378-0af6c691e15c
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# norm, normf, norml
Retrieves the squared magnitude of a complex number.  
  
## Syntax  
  
```  
double norm(   
   _Dcomplex z   
);  
float norm(   
   _Fcomplex z   
);  // C++ only  
long double norm(   
  _Lcomplex z   
);  // C++ only  
float normf(   
   _Fcomplex z   
);  
long double norml(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number.  
  
## Return Value  
 The squared magnitude of `z`.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `norm` that take `_Fcomplex` or `_Lcomplex` values, and return `float` or `long double` values. In a C program, `norm` always takes a `_Dcomplex` value and returns a `double` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`norm`,               `normf`, `norml`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [creal, crealf, creall](../VS_csharp/creal--crealf--creall.md)   
 [cproj, cprojf, cprojl](../VS_csharp/cproj--cprojf--cprojl.md)   
 [conj, conjf, conjl](../VS_csharp/conj--conjf--conjl.md)   
 [cimag, cimagf, cimagl](../VS_csharp/cimag--cimagf--cimagl.md)   
 [carg, cargf, cargl](../VS_csharp/carg--cargf--cargl.md)   
 [cabs, cabsf, cabsl](../VS_csharp/cabs--cabsf--cabsl.md)