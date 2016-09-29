---
title: "copysign, copysignf, copysignl, _copysign, _copysignf, _copysignl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "copysignf"
  - "copysignl"
  - "_copysignl"
  - "_copysign"
  - "_copysignf"
  - "copysign"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_copysignl"
  - "copysign"
  - "copysignf"
  - "_copysign"
  - "copysignl"
  - "_copysignf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "copysignl function"
  - "_copysignl function"
  - "copysign function"
  - "_copysignf function"
  - "_copysign function"
  - "copysignf function"
ms.assetid: 009216d6-72a2-402d-aa6c-91d924b2c9e4
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copysign, copysignf, copysignl, _copysign, _copysignf, _copysignl
Returns a value that has the magnitude of one argument and the sign of another.  
  
## Syntax  
  
```  
double copysign(   
   double x,  
   double y   
);  
float copysign(   
   float x,  
   float y   
); // C++ only  
long double copysign(   
   long double x,  
   long double y   
); // C++ only  
float copysignf(   
   float x,  
   float y   
); // C++ only  
long double copysignl(   
   long double x,  
   long double y   
); // C++ only  
double _copysign(   
   double x,  
   double y   
);  
long double _copysignl(   
   long double x,  
   long double y   
);  
```  
  
#### Parameters  
 `x`  
 The floating-point value that's returned as the magnitude of the result.  
  
 `y`  
 The floating-point value that's returned as the sign of the result.  
  
 [Floating-Point Support Routines](../vs140/floating-point-support.md)  
  
## Return Value  
 The `copysign` functions return a floating-point value that combines the magnitude of `x` and the sign of `y`. There is no error return.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `copysign` that take and return `float` or `long double` values. In a C program, `copysign` always takes and returns a `double`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_copysign`|<float.h>|  
|`copysign`, `copysignf`, `copysignl`, `_copysignf``_copysignl`|<math.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [fabs, fabsf, fabsl](../vs140/fabs--fabsf--fabsl.md)   
 [_chgsign, _chgsignf, _chgsignl](../vs140/_chgsign--_chgsignf--_chgsignl.md)