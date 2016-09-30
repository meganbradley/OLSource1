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
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# lgamma, lgammaf, lgammal
Determines the natural logarithm of the absolute value of the gamma function of the specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value to compute.  
  
## Return Value  
 If successful, return the natural logarithm of the absolute value of the gamma function of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
|Issue|Return|  
|-----------|------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> = NaN|NaN|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = ±0|+INFINITY|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>= negative integer|+INFINITY|  
|±INFINITY|+INFINITY|  
|pole error|+HUGE_VAL, +HUGE_VALF, or +HUGE_VALL|  
|overflow range error|±HUGE_VAL, ±HUGE_VALF, or ±HUGE_VALL|  
  
 Errors are reported as specified in [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> always takes and returns a double.  
  
 If x is a rational number, this function returns the logarithm of the factorial of (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-1).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [tgamma, tgammaf, tgammal](../vs140/tgamma--tgammaf--tgammal.md)