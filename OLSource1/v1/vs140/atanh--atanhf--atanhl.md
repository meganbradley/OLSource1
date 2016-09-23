---
title: "atanh, atanhf, atanhl"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - atanhl
  - atanhf
  - atanh
apilocation: 
  - msvcr110.dll
  - msvcr100.dll
  - msvcr80.dll
  - msvcrt.dll
  - msvcr90.dll
  - msvcr120.dll
  - msvcr110_clr0400.dll
apitype: DLLExport
f1_keywords: 
  - atanhl
  - atanhf
  - atanh
dev_langs: 
  - C++
helpviewer_keywords: 
  - atanhf function
  - atanhl function
  - atanh funciton
ms.assetid: 83a43b5b-2580-4461-854f-dc84236d9f32
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# atanh, atanhf, atanhl
Calculates the inverse hyperbolic tangent.  
  
## Syntax  
  
```  
double atanh(  
   double x   
);  
float atanh(  
   float x   
);  // C++ only  
long double atanh(  
   long double x  
);  // C++ only  
float atanhf(  
   float x   
);  
long double atanhl(  
   long double x  
);  
```  
  
#### Parameters  
 `x`  
 Floating-point value.  
  
## Return Value  
 The `atanh` functions return the inverse hyberbolic tangent (arc hyperbolic tangent) of `x`. If `x` is greater than 1, or less than –1, `errno` is set to `EDOM` and the result is a quiet NaN. If `x` is equal to 1 or -1, a positive or negative infinity is returned, respectively, and `errno` is set to `ERANGE`.  
  
|Input|SEH Exception|`Matherr` Exception|  
|-----------|-------------------|-------------------------|  
|± QNAN,IND|none|none|  
|`X` ≥ 1; `x` ≤ -1|none|none|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `atanh` that take and return `float` or `long double` values. In a C program, `atanh` always takes and returns `double`.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|`atanh`, `atanhf`, `atanhl`|<math.h>|<cmath\>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_atanh.c  
// This program displays the hyperbolic tangent of pi / 4  
// and the arc hyperbolic tangent of the result.  
//  
  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   double pi = 3.1415926535;  
   double x, y;  
  
   x = tanh( pi / 4 );  
   y = atanh( x );  
   printf( "tanh( %f ) = %f\n", pi/4, x );  
   printf( "atanh( %f ) = %f\n", x, y );  
}  
```  
  
 **tanh( 0.785398 ) = 0.655794**  
**atanh( 0.655794 ) = 0.785398**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [_CItan](../vs140/_citan.md)