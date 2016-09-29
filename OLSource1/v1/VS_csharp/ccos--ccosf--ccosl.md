---
title: "ccos, ccosf, ccosl"
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
  - "ccos"
  - "ccosf"
  - "ccosl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ccos"
  - "ccosf"
  - "ccosl"
  - "complex/ccos"
  - "complex/ccosf"
  - "complex/ccosl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "ccos function"
  - "ccosf function"
  - "ccosl function"
ms.assetid: 4ab936ac-ff85-49ac-9418-2b69cf5d4696
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ccos, ccosf, ccosl
Retrieves the cosine of a complex number.  
  
## Syntax  
  
```  
_Dcomplex ccos(   
   _Dcomplex z   
);  
_Fcomplex ccos(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex ccos(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex ccosf(   
   _Fcomplex z   
);  
_Lcomplex ccosl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents the angle, in radians.  
  
## Return Value  
 The cosine of `z`, in radians.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `ccos` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `ccos` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`ccos`,               `ccosf`, `ccosl`|<complex.h>|<ccomplex\>|  
  
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
 [csqrt, csqrtf, csqrtl](../VS_csharp/csqrt--csqrtf--csqrtl.md)