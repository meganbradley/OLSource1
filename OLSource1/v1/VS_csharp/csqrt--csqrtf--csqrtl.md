---
title: "csqrt, csqrtf, csqrtl"
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
  - "csqrt"
  - "csqrtf"
  - "csqrtl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "csqrt"
  - "csqrtf"
  - "csqrtl"
  - "complex/csqrt"
  - "complex/csqrtf"
  - "complex/csqrtl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "csqrt function"
  - "csqrtf function"
  - "csqrtl function"
ms.assetid: b65f086b-0f55-4622-a7a3-4e79d9c9c05c
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# csqrt, csqrtf, csqrtl
Retrieves the square root of a complex number, with a branch cut along the negative real axis.  
  
## Syntax  
  
```  
_Dcomplex csqrt(   
   _Dcomplex z   
);  
_Fcomplex csqrt(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex csqrt(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex csqrtf(   
   _Fcomplex z   
);  
_Lcomplex csqrtl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number.  
  
## Return Value  
 The square root of `z`. The result is in the right half-plane.  
  
|Input|SEH Exception|`_matherr` Exception|  
|-----------|-------------------|--------------------------|  
|± QNAN, IND|none|_DOMAIN|  
|- ∞|none|_DOMAIN|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `csqrt` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `csqrt` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`csqrt`,               `csqrtf`, `csqrtl`|<complex.h>|<ccomplex\>|  
  
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
 [ctan, ctanf, ctanl](../VS_csharp/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../VS_csharp/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../VS_csharp/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../VS_csharp/ccos--ccosf--ccosl.md)