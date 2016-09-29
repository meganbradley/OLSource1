---
title: "csin, csinf, csinl"
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
  - "csin"
  - "csinf"
  - "csinl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "csin"
  - "csinf"
  - "csinl"
  - "complex/csin"
  - "complex/csinf"
  - "complex/csinl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "csin function"
  - "csinf function"
  - "csinl function"
ms.assetid: 3ed475e8-9aae-42ba-a25c-7ae656a0fd4d
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# csin, csinf, csinl
Retrieves the sine of a complex number.  
  
## Syntax  
  
```  
_Dcomplex csin(   
   _Dcomplex z   
);  
_Fcomplex csin(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex csin(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex csinf(   
   _Fcomplex z   
);  
_Lcomplex csinl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number that represents an angle, in radians.  
  
## Return Value  
 The sine of `z`, in radians.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `csin` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `csin` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`csin`,               `csinf`, `csinl`|<complex.h>|<ccomplex\>|  
  
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
 [casin, casinf, casinl](../VS_csharp/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../VS_csharp/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../VS_csharp/csqrt--csqrtf--csqrtl.md)