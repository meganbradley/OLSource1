---
title: "cproj, cprojf, cprojl"
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
  - "cproj"
  - "cprojf"
  - "cprojl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
  - "ucrtbase.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cproj"
  - "cprojf"
  - "cprojl"
  - "complex/cproj"
  - "complex/cprojf"
  - "complex/cprojl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "cproj function"
  - "cprojf function"
  - "cprojl function"
ms.assetid: 32b49623-13bf-4cae-802e-7912d75030fe
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cproj, cprojf, cprojl
Retrieves the projection of a complex number on the Reimann sphere.  
  
## Syntax  
  
```  
_Dcomplex cproj(   
   _Dcomplex z   
);  
_Fcomplex cproj(   
   _Fcomplex z   
);  // C++ only  
_Lcomplex cproj(   
   _Lcomplex z   
);  // C++ only  
_Fcomplex cprojf(   
   _Fcomplex z   
);  
_Lcomplex cprojl(   
   _Lcomplex z   
);  
```  
  
#### Parameters  
 `z`  
 A complex number.  
  
## Return Value  
 The projection of `z` on the Reimann sphere.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `cproj` that take and return `_Fcomplex` and `_Lcomplex` values. In a C program, `cproj` always takes and returns a `_Dcomplex` value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|`cproj`,               `cprojf`, `cprojl`|<complex.h>|<ccomplex\>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [norm, normf, norml](../vs140/norm--normf--norml.md)   
 [creal, crealf, creall](../vs140/creal--crealf--creall.md)   
 [conj, conjf, conjl](../vs140/conj--conjf--conjl.md)   
 [cimag, cimagf, cimagl](../vs140/cimag--cimagf--cimagl.md)   
 [carg, cargf, cargl](../vs140/carg--cargf--cargl.md)   
 [cabs, cabsf, cabsl](../vs140/cabs--cabsf--cabsl.md)