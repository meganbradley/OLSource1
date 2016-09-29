---
title: "ctanh, ctanhf, ctanhl"
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
  - "ctanh"
  - "ctahf"
  - "ctahl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ctanh"
  - "ctanhf"
  - "ctanhl"
  - "complex/ctanh"
  - "complex/ctanhf"
  - "complex/ctanhl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "ctanh function"
  - "ctanhl function"
  - "ctanhf function"
ms.assetid: 807f2cd1-8740-4988-afff-5911c346385b
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ctanh, ctanhf, ctanhl
Computes the complex hyperbolic tangent of a complex number.  
  
## Syntax  
  
```  
_Dcomplex ctanh(   
   _Dcomplex z   
);  
_Fcomplex ctanh(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex ctanh(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex ctanhf(   
   _Fcomplex z   
);  
_Lcomplex ctanhl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents an angle, in radians.  
  
## Return Value  
 The complex hyperbolic tangent of `z`.  
  
|Input|SEH Exception|`_matherr` Exception|  
|-----------|-------------------|--------------------------|  
|± ∞, QNAN, IND|none|_DOMAIN|  
|± ∞ (tan, tanf)|INVALID|_DOMAIN|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `ctanh` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `ctanh` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`ctanh`,               `ctanhf`, `ctanhl`|<complex.h>|<ccomplex\>|  
  
 For compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## See Also  
 [CRT Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [catanh, catanhf, catanhl](../VS_csharp/catanh--catanhf--catanhl.md)   
 [catan, catanf, catanl](../VS_csharp/catan--catanf--catanl.md)   
 [csinh, csinhf, csinhl](../VS_csharp/csinh--csinhf--csinhl.md)   
 [casinh, casinhf, casinhl](../VS_csharp/casinh--casinhf--casinhl.md)   
 [ccosh, ccoshf, ccoshl](../VS_csharp/ccosh--ccoshf--ccoshl.md)   
 [cacosh, cacoshf, cacoshl](../VS_csharp/cacosh--cacoshf--cacoshl.md)   
 [cacos, cacosf, cacosl](../VS_csharp/cacos--cacosf--cacosl.md)   
 [ctan, ctanf, ctanl](../VS_csharp/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../VS_csharp/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../VS_csharp/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../VS_csharp/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../VS_csharp/csqrt--csqrtf--csqrtl.md)