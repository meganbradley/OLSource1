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
author: ""
ms.author: ""
manager: ""
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
 [casin, casinf, casinl](../vs140/casin--casinf--casinl.md)   
 [csqrt, csqrtf, csqrtl](../vs140/csqrt--csqrtf--csqrtl.md)