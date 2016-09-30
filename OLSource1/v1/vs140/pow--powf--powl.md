---
title: "pow, powf, powl"
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
  - "powl"
  - "pow"
  - "powf"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "powl"
  - "pow"
  - "_powl"
  - "powf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "exponential calculations"
  - "powl function"
  - "_powl function"
  - "exponentiation"
  - "powers, calculating"
  - "calculating exponentials"
  - "powf function"
  - "pow function"
ms.assetid: e75c33ed-2e59-48b1-be40-81da917324f1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pow, powf, powl
Calculates `x` raised to the power of `y`.  
  
## Syntax  
  
```  
double pow(  
   double x,  
   double y   
);  
double pow(  
   double x,  
   int y  
);  // C++ only  
float pow(  
   float x,  
   float y   
);  // C++ only  
float pow(  
   float x,  
   int y  
);  // C++ only  
long double pow(  
   long double x,  
   long double y  
);  // C++ only  
long double pow(  
   long double x,  
   int y  
);  // C++ only  
float powf(  
   float x,  
   float y   
);  
long double powl(  
   long double x,  
   long double y  
);  
```  
  
#### Parameters  
 `x`  
 Base.  
  
 `y`  
 Exponent.  
  
## Return Value  
 Returns the value of `x`<sup>y</sup>. No error message is printed on overflow or underflow.  
  
|Values of x and y|Return value of pow|  
|-----------------------|-------------------------|  
|`x` \< > 0 and `y` = 0.0|1|  
|`x` = 0.0 and `y` = 0.0|1|  
|`x` = 0.0 and `y` < 0|INF|  
  
## Remarks  
 `pow` does not recognize integral floating-point values greater than 2<sup>64</sup> (for example, `1.0E100`).  
  
 `pow` has an implementation that uses Streaming SIMD Extensions 2 (SSE2). For information and restrictions about using the SSE2 implementation, see [_set_SSE2_enable](../vs140/_set_sse2_enable.md).  
  
 Because C++ allows overloading, you can call any of the various overloads of `pow`. In a C program, `pow` always takes two double values and returns a double value.  
  
 The `pow(int, int)` overload is no longer available. If you use this overload, the compiler may emit C2668. To avoid this problem, cast the first parameter to `double`, `float`, or `long double`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`pow`, `powf`, `powl`|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
```  
// crt_pow.c  
  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   double x = 2.0, y = 3.0, z;  
  
   z = pow( x, y );  
   printf( "%.1f to the power of %.1f is %.1f\n", x, y, z );  
}  
```  
  
## Output  
  
```  
2.0 to the power of 3.0 is 8.0  
```  
  
## .NET Framework Equivalent  
 [System::Math::Pow](https://msdn.microsoft.com/en-us/library/system.math.pow.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [exp, expf](../vs140/exp--expf.md)   
 [log, logf, log10, log10f](../vs140/log--logf--log10--log10f.md)   
 [sqrt, sqrtf, sqrtl](../vs140/sqrt--sqrtf--sqrtl.md)   
 [_CIpow](../vs140/_cipow.md)