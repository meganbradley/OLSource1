---
title: "tan, tanf, tanl, tanh, tanhf, tanhl"
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
  - tanhf
  - tanh
  - tan
  - tanhl
  - tanf
  - tanl
apilocation: 
  - msvcr100.dll
  - msvcrt.dll
  - msvcr80.dll
  - msvcr90.dll
  - msvcr110_clr0400.dll
  - msvcr120.dll
  - msvcr110.dll
apitype: DLLExport
f1_keywords: 
  - tanh
  - tan
  - _tanl
  - tanl
  - _tanhl
  - tanf
  - tanhf
  - tanhl
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - tanl function
  - tanhl function
  - _tanl function
  - _tanhl function
  - tan function
  - calculating tangents
  - tangent
  - tanh function
  - tanhf function
  - tanf function
  - trigonometric functions
  - hyperbolic functions
ms.assetid: 36cc0ce8-9c80-4653-b354-ddb3b378b6bd
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# tan, tanf, tanl, tanh, tanhf, tanhl
Calculates the tangent (`tan`, `tanf`, or `tanl`), or hyperbolic tangent (`tanh`, `tanhf`, or `tanhl`).  
  
## Syntax  
  
```  
double tan(  
   double x   
);  
float tan(  
   float x   
);  // C++ only  
long double tan(  
   long double x  
);  // C++ only  
float tanf(  
   float x   
);  
long double tanl(  
   long double x  
);  
double tanh(  
   double x   
);  
float tanh(  
   float x   
);  // C++ only  
long double tanh(  
   long double x  
);  // C++ only  
float tanhf(  
   float x   
);  
long double tanhl(  
   long double x  
);  
```  
  
#### Parameters  
 `x`  
 Angle in radians.  
  
## Return Value  
 The `tan` functions return the tangent of `x`. If `x` is greater than or equal to 263, or less than or equal to –263, a loss of significance in the result occurs.  
  
 The `tanh` functions return the hyperbolic tangent of `x`. There is no error return.  
  
|Input|SEH Exception|`Matherr` Exception|  
|-----------|-------------------|-------------------------|  
|± QNAN,IND|none|_DOMAIN|  
|± ∞  (`tan`, `tanf`)|`INVALID`|_DOMAIN|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `tan` and `tanh` that take and return `float` or `long double` values. In a C program, `tan` and `tanh` always take and return `double`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`tan`, `tanf`, `tanl`, `tanh`, `tanhf`, `tanhl`|<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_tan.c  
// This program displays the tangent of pi / 4  
// and the hyperbolic tangent of the result.  
//  
  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   double pi = 3.1415926535;  
   double x, y;  
  
   x = tan( pi / 4 );  
   y = tanh( x );  
   printf( "tan( %f ) = %f\n", pi/4, x );  
   printf( "tanh( %f ) = %f\n", x, y );  
}  
```  
  
 **tan( 0.785398 ) = 1.000000**  
**tanh( 1.000000 ) = 0.761594**   
## .NET Framework Equivalent  
  
-   [System::Math::Tan](https://msdn.microsoft.com/en-us/library/system.math.tan.aspx)  
  
-   [System::Math::Tanh](https://msdn.microsoft.com/en-us/library/system.math.tanh.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [_CItan](../vs140/_citan.md)