---
title: "sin, sinf, sinl, sinh, sinhf, sinhl"
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
  - "sinl"
  - "sinf"
  - "sinhf"
  - "sinh"
  - "sin"
  - "sinhl"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sinl"
  - "sinf"
  - "sinhl"
  - "sinl"
  - "sin"
  - "sinhf"
  - "_sinhl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sinh function"
  - "_sinl function"
  - "_sinhl function"
  - "sinhf function"
  - "sinl function"
  - "calculating sines"
  - "sin function"
  - "trigonometric functions"
  - "sinf function"
  - "sinhl function"
  - "hyperbolic functions"
ms.assetid: 737de73e-3590-45f9-8257-dc1c0c489dfc
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sin, sinf, sinl, sinh, sinhf, sinhl
Calculates sines and hyperbolic sines.  
  
## Syntax  
  
```  
double sin(  
   double x   
);  
float sin(  
   float x  
);  // C++ only  
long double sin(  
   long double x  
);  // C++ only  
float sinf(  
   float x   
);  
long double sinl(   long double x  
);  
double sinh(  
   double x   
);  
float sinh(  
   float x   
);  // C++ only  
long double sinh(  
   long double x  
);  // C++ only  
float sinhf(  
   float x  
);  
long double sinhl(  
   long double x  
);  
```  
  
#### Parameters  
 `x`  
 Angle in radians.  
  
## Return Value  
 The `sin` functions return the sine of `x`. If `x` is greater than or equal to 263, or less than or equal to –263, a loss of significance in the result occurs.  
  
 The `sinh` functions return the hyperbolic sine of `x`. By default, if the result is too large, `sinh` sets `errno` to `ERANGE` and returns ±`HUGE_VAL`.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|None|_DOMAIN|  
|± ∞ (sin, sinf, sinl)|INVALID|_DOMAIN|  
|&#124;x&#124; ≥ 7.104760e+002 (sinh, sinhf, sinhl)|OVERFLOW+INEXACT|OVERFLOW|  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `sin` and `sinh` that take and return `float` or `long double` values. In a C program, `sin` and `sinh` always take and return `double`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`sin`, `sinf`, `sinl`, `sinh`, `sinhf`, `sinhl`|<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_sincos.c  
// This program displays the sine, hyperbolic  
// sine, cosine, and hyperbolic cosine of pi / 2.  
//  
  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   double pi = 3.1415926535;  
   double x, y;  
  
   x = pi / 2;  
   y = sin( x );  
   printf( "sin( %f ) = %f\n", x, y );  
   y = sinh( x );  
   printf( "sinh( %f ) = %f\n",x, y );  
   y = cos( x );  
   printf( "cos( %f ) = %f\n", x, y );  
   y = cosh( x );  
   printf( "cosh( %f ) = %f\n",x, y );  
}  
```  
  
 **sin( 1.570796 ) = 1.000000**  
**sinh( 1.570796 ) = 2.301299**  
**cos( 1.570796 ) = 0.000000**  
**cosh( 1.570796 ) = 2.509178**   
## .NET Framework Equivalent  
  
-   [System::Math::Sin](https://msdn.microsoft.com/en-us/library/system.math.sin.aspx)  
  
-   [System::Math::Sinh](https://msdn.microsoft.com/en-us/library/system.math.sinh.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [tan, tanf, tanl, tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [_CIsin](../vs140/_cisin.md)