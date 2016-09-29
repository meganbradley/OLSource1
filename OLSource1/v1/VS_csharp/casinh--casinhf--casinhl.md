---
title: "casinh, casinhf, casinhl"
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
  - "casinh"
  - "casinhl"
  - "casinhf"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "casinh"
  - "casinhf"
  - "casinhl"
  - "complex/casinh"
  - "complex/casinhf"
  - "complex/casinhl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "casinh function"
  - "casinhf function"
  - "casinhl function"
ms.assetid: bd18340b-21dd-4c86-a14e-e8e15dd97e3b
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# casinh, casinhf, casinhl
Retrieves the inverse hyperbolic sine of a complex number, with branch cuts outside the interval [−i, +i] along the imaginary axis.  
  
## Syntax  
  
```  
_Dcomplex casinh(   
   _Dcomplex z   
);  
_Fcomplex casinh(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex casinh(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex casinhf(   
   _Fcomplex z   
);  
_Lcomplex casinhl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents an angle, in radians.  
  
## Return Value  
 The inverse hyperbolic sine of `z`, in radians. The result is unbound along the real axis, and in the interval [−iπ/2, +iπ/2] along the imaginary axis.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `casinh` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `casinh` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`casinh`,               `casinhf`, `casinhl`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [catanh, catanhf, catanhl](../VS_csharp/catanh--catanhf--catanhl.md)   
 [ctanh, ctanhf, ctanhl](../VS_csharp/ctanh--ctanhf--ctanhl.md)   
 [catan, catanf, catanl](../VS_csharp/catan--catanf--catanl.md)   
 [csinh, csinhf, csinhl](../VS_csharp/csinh--csinhf--csinhl.md)   
 [ccosh, ccoshf, ccoshl](../VS_csharp/ccosh--ccoshf--ccoshl.md)   
 [cacosh, cacoshf, cacoshl](../VS_csharp/cacosh--cacoshf--cacoshl.md)   
 [cacos, cacosf, cacosl](../VS_csharp/cacos--cacosf--cacosl.md)   
 [ctan, ctanf, ctanl](../VS_csharp/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../VS_csharp/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../VS_csharp/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../VS_csharp/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../VS_csharp/csqrt--csqrtf--csqrtl.md)