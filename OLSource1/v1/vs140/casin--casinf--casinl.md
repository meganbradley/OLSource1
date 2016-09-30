---
title: "casin, casinf, casinl"
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
  - "casin"
  - "casinf"
  - "casinl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "casin"
  - "casinf"
  - "casinl"
  - "complex/casin"
  - "complex/casinf"
  - "complex/casinl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "casin function"
  - "casinf function"
  - "casinl function"
ms.assetid: b75d1455-7b1e-43b0-bd46-c530be190be9
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# casin, casinf, casinl
Retrieves the arcsine of a complex number, with branch cuts outside the interval [−1, +1] along the real axis.  
  
## Syntax  
  
```  
_Dcomplex casin(   
   _Dcomplex z   
);  
_Fcomplex casin(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex casin(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex casinf(   
   _Fcomplex z   
);  
_Lcomplex casinl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents an angle, in radians.  
  
## Return Value  
 The arcsine of `z`, in radians. The result is unbounded along the imaginary axis, and in the interval [−π/2, +π/2] along the real axis.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `casin` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `casin` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`casin`,               `casinf`, `casinl`|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [catanh, catanhf, catanhl](../vs140/catanh--catanhf--catanhl.md)   
 [ctanh, ctanhf, ctanhl](../vs140/ctanh--ctanhf--ctanhl.md)   
 [catan, catanf, catanl](../vs140/catan--catanf--catanl.md)   
 [csinh, csinhf, csinhl](../vs140/csinh--csinhf--csinhl.md)   
 [casinh, casinhf, casinhl](../vs140/casinh--casinhf--casinhl.md)   
 [ccosh, ccoshf, ccoshl](../vs140/ccosh--ccoshf--ccoshl.md)   
 [cacosh, cacoshf, cacoshl](../vs140/cacosh--cacoshf--cacoshl.md)   
 [cacos, cacosf, cacosl](../vs140/cacos--cacosf--cacosl.md)   
 [ctan, ctanf, ctanl](../vs140/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../vs140/csin--csinf--csinl.md)   
 [ccos, ccosf, ccosl](../vs140/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../vs140/csqrt--csqrtf--csqrtl.md)