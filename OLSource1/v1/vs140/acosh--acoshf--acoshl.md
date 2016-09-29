---
title: "acosh, acoshf, acoshl"
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
  - "acoshf"
  - "acosh"
  - "acoshl"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "acosh"
  - "acoshf"
  - "acoshl"
  - "math/acosh"
  - "math/acoshf"
  - "math/acoshl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acoshf function"
  - "acosh function"
  - "acoshl function"
ms.assetid: 6985c4d7-9e2a-44ce-9a9b-5a43015f15f7
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# acosh, acoshf, acoshl
Calculates the inverse hyperbolic cosine.  
  
## Syntax  
  
```  
double acosh(  
   double x   
);  
float acosh(  
   float x   
);  // C++ only  
long double acosh(  
   long double x  
);  // C++ only  
float acoshf(  
   float x   
);  
long double acoshl(  
   long double x  
);  
```  
  
#### Parameters  
 `x`  
 Floating-point value.  
  
## Return Value  
 The `acosh` functions return the inverse hyberbolic cosine (arc hyperbolic cosine) of `x`. These functions are valid over the domain `x` ≥ 1. If `x` is less than 1, `errno` is set to `EDOM` and the result is a quiet NaN. If `x` is a quiet NaN, indefinite, or infinity, the same value is returned.  
  
|Input|SEH Exception|`_matherr` Exception|  
|-----------|-------------------|--------------------------|  
|± QNAN, IND, INF|none|none|  
|x < 1|none|none|  
  
## Remarks  
 When you use C++, you can call overloads of `acosh` that take and return `float` or `long double` values. In a C program, `acosh` always takes and returns `double`.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|`acosh`, `acoshf`, `acoshl`|<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```c  
// crt_acosh.c  
// Compile by using: cl /W4 crt_acosh.c  
// This program displays the hyperbolic cosine of pi / 4  
// and the arc hyperbolic cosine of the result.  
  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   double pi = 3.1415926535;  
   double x, y;  
  
   x = cosh( pi / 4 );  
   y = acosh( x );  
   printf( "cosh( %f ) = %f\n", pi/4, x );  
   printf( "acosh( %f ) = %f\n", x, y );  
}  
```  
  
 **cosh( 0.785398 ) = 1.324609**  
**acosh( 1.324609 ) = 0.785398**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [cosh](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [sinh](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [asinh](../vs140/asinh--asinhf--asinhl.md)   
 [tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [atanh](../vs140/atanh--atanhf--atanhl.md)   
 [_CItan](../vs140/_citan.md)