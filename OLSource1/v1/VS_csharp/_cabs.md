---
title: "_cabs"
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
  - "_cabs"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cabsl"
  - "_cabs"
  - "_cabsl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cabs function"
  - "cabsl function"
  - "absolute values"
  - "_cabsl function"
  - "_cabs function"
  - "calculating absolute values"
ms.assetid: fea292ee-1a39-4a0a-b416-4a189346ff26
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cabs
Calculates the absolute value of a complex number.  
  
## Syntax  
  
```  
double _cabs(   
   struct _complex z   
);  
```  
  
#### Parameters  
 `z`  
 Complex number.  
  
## Return Value  
 `_cabs` returns the absolute value of its argument if successful. On overflow, `_cabs` returns `HUGE_VAL` and sets `errno` to `ERANGE`. You can change error handling with [_matherr](../VS_csharp/_matherr.md).  
  
## Remarks  
 The `_cabs` function calculates the absolute value of a complex number, which must be a structure of type [_complex](../VS_csharp/standard-types.md). The structure `z` is composed of a real component `x` and an imaginary component `y`. A call to `_cabs` produces a value equivalent to that of the expression `sqrt`( `z.x``*``z.x``+``z.y`*`z.y` ).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_cabs`|<math.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt_cabs.c  
/* Using _cabs, this program calculates  
 * the absolute value of a complex number.  
 */  
#include <math.h>  
#include <stdio.h>  
  
int main( void )  
{  
   struct _complex number = { 3.0, 4.0 };  
   double d;  
  
   d = _cabs( number );  
   printf( "The absolute value of %f + %fi is %f\n",  
           number.x, number.y, d );  
}  
```  
  
 **The absolute value of 3.000000 + 4.000000i is 5.000000**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../VS_csharp/floating-point-support.md)   
 [abs, labs, llabs, _abs64](../VS_csharp/abs--labs--llabs--_abs64.md)   
 [fabs, fabsf, fabsl](../VS_csharp/fabs--fabsf--fabsl.md)   
 [labs, llabs](../Topic/labs,%20llabs.md)