---
title: "lgamma, lgammaf, lgammal"
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
  - "lgamma"
  - "lgammaf"
  - "lgammal"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "lgamma"
  - "lgammaf"
  - "lgammal"
  - "math/lgamma"
  - "math/lgammaf"
  - "math/lgammal"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "lgamma function"
  - "lgammal function"
  - "lgammaf function"
ms.assetid: 6e326c58-7077-481a-a329-c82ae56ae9e6
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# lgamma, lgammaf, lgammal
Determines the natural logarithm of the absolute value of the gamma function of the specified value.  
  
## Syntax  
  
```  
double lgamma(  
   double x  
);  
  
float lgamma(  
   float x  
); //C++ only  
  
long double lgamma(  
   long double x  
); //C++ only  
  
float lgammaf(  
   float x  
);  
  
long double lgammal(  
   long double x  
);  
  
```  
  
#### Parameters  
 [in] `x`  
 The value to compute.  
  
## Return Value  
 If successful, return the natural logarithm of the absolute value of the gamma function of `x.`  
  
|Issue|Return|  
|-----------|------------|  
|`x` = NaN|NaN|  
|`x` = ±0|+INFINITY|  
|`x`= negative integer|+INFINITY|  
|±INFINITY|+INFINITY|  
|pole error|+HUGE_VAL, +HUGE_VALF, or +HUGE_VALL|  
|overflow range error|±HUGE_VAL, ±HUGE_VALF, or ±HUGE_VALL|  
  
 Errors are reported as specified in [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of `lgamma` that take and return float and long double types. In a C program, `lgamma` always takes and returns a double.  
  
 If x is a rational number, this function returns the logarithm of the factorial of (`x`-1).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|`lgamma`,                `lgammaf`,  `lgammal`|<math.h>|<cmath\>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [tgamma, tgammaf, tgammal](../vs140/tgamma--tgammaf--tgammal.md)