---
title: "lround, lroundf, lroundl, llround, llroundf, llroundl"
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
  - "llround"
  - "llroundf"
  - "llroundl"
  - "lroundf"
  - "lround"
  - "lroundl"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "lround"
  - "lroundl"
  - "llroundl"
  - "llround"
  - "lroundf"
  - "llroundf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lround function"
  - "llroundl function"
  - "llround function"
  - "lroundf function"
  - "llroundf function"
  - "lroundl function"
ms.assetid: cfb88a35-54c6-469f-85af-f7d695dcfdd8
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lround, lroundf, lroundl, llround, llroundf, llroundl
Rounds a floating-point value to the nearest integer.  
  
## Syntax  
  
```  
long lround(   
   double x   
);  
long lround(  
   float x  
);  // C++ only  
long lround(  
   long double x  
);  // C++ only  
long lroundf(  
   float x  
);  
long lroundl(  
   long double x  
);  
long long llround(   
   double x   
);  
long long llround(  
   float x  
);  // C++ only  
long long llround(  
   long double x  
);  // C++ only  
long long llroundf(  
   float x  
);  
long long llroundl(  
   long double x  
);  
```  
  
#### Parameters  
 `x`  
 The floating-point value to round.  
  
## Return Value  
 The `lround` and `llround` functions return the nearest `long` or `long long` integer to `x`. Halfway values are rounded away from zero, regardless of the setting of the floating-point rounding mode. There is no error return.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± `QNAN`, `IND`|none|`_DOMAIN`|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `lround` or `llround` that take and return `float` and `long double` values. In a C program, `lround` and `llround` always take and return a `double`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`lround`, `lroundf`, `lroundl`, `llround`, `llroundf`, `llroundl`|<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_lround.c  
// Build with: cl /W3 /Tc crt_lround.c  
// This example displays the rounded results of  
// the floating-point values 2.499999, -2.499999,   
// 2.8, -2.8, 3.5 and -3.5.  
  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   double x = 2.499999;  
   float y = 2.8f;  
   long double z = 3.5;  
  
   printf("lround(%f) is %d\n", x, lround(x));  
   printf("lround(%f) is %d\n", -x, lround(-x));  
   printf("lroundf(%f) is %d\n", y, lroundf(y));  
   printf("lroundf(%f) is %d\n", -y, lroundf(-y));  
   printf("lroundl(%Lf) is %d\n", z, lroundl(z));  
   printf("lroundl(%Lf) is %d\n", -z, lroundl(-z));  
}  
```  
  
 **lround(2.499999) is 2**  
**lround(-2.499999) is -2**  
**lroundf(2.800000) is 3**  
**lroundf(-2.800000) is -3**  
**lroundl(2.500000) is 4**  
**lroundl(-2.500000) is -4**   
## .NET Framework Equivalent  
 [System::Math::Round](https://msdn.microsoft.com/en-us/library/system.math.round.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ceil](../vs140/ceil--ceilf--ceill.md)   
 [floor, floorf, floorl](../vs140/floor--floorf--floorl.md)   
 [fmod, fmodf](../vs140/fmod--fmodf.md)   
 [lrint, lrintf, lrintl, llrint, llrintf, llrintl](assetId:///312fd869-a9c0-4107-bb23-ab8299d04385)   
 [round](../vs140/round--roundf--roundl.md)   
 [nearbyint, nearbyintf, nearbyintl](assetId:///15111e73-331d-41d1-81b7-3e10df894848)   
 [rint](../vs140/rint--rintf--rintl.md)