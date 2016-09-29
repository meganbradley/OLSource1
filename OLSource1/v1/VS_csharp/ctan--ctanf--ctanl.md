---
title: "ctan, ctanf, ctanl"
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
  - "ctan"
  - "ctanf"
  - "ctanl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ctan"
  - "ctanf"
  - "ctanl"
  - "complex/ctan"
  - "complex/ctanf"
  - "complex/ctanl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "ctan function"
  - "ctanf function"
  - "ctanl function"
ms.assetid: d3cbd25c-1e93-4a6d-8154-da42921f7223
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ctan, ctanf, ctanl
Retrieves the tangent of a complex number.  
  
## Syntax  
  
```  
_Dcomplex ctan(   
   _Dcomplex z   
);  
_Fcomplex ctan(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex ctan(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex ctanf(   
   _Fcomplex z   
);  
_Lcomplex ctanl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents the angle, in radians.  
  
## Return Value  
 The tangent of `z`.  
  
|Input|SEH Exception|`_matherr` Exception|  
|-----------|-------------------|--------------------------|  
|± ∞, QNAN, IND|none|_DOMAIN|  
|± ∞ (`tan`, `tanf`)|INVALID|_DOMAIN|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `ctan` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `ctan` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`ctan`,               `ctanf`, `ctanl`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [catanh, catanhf, catanhl](../VS_csharp/catanh--catanhf--catanhl.md)   
 [ctanh, ctanhf, ctanhl](../VS_csharp/ctanh--ctanhf--ctanhl.md)   
 [catan, catanf, catanl](../VS_csharp/catan--catanf--catanl.md)   
 [csinh, csinhf, csinhl](../VS_csharp/csinh--csinhf--csinhl.md)   
 [casinh, casinhf, casinhl](../VS_csharp/casinh--casinhf--casinhl.md)   
 [ccosh, ccoshf, ccoshl](../VS_csharp/ccosh--ccoshf--ccoshl.md)   
 [cacosh, cacoshf, cacoshl](../VS_csharp/cacosh--cacoshf--cacoshl.md)   
 [cacos, cacosf, cacosl](../VS_csharp/cacos--cacosf--cacosl.md)   
 [csin, csinf, csinl](../VS_csharp/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../VS_csharp/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../VS_csharp/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../VS_csharp/csqrt--csqrtf--csqrtl.md)