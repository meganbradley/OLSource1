---
title: "log2, log2f, log2l"
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
  - "log2"
  - "log2l"
  - "log2f"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
  - "msvcr120_clr400.dll"
  - "msvcr120_clr0400.dll"
  - "ucrtbase.dll"
apitype: "DLLExport"
dev_langs: 
  - "C"
  - "C++"
ms.assetid: 94d11b38-70b7-4d3a-94ac-523153c92b2e
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# log2, log2f, log2l
Determines the binary (base-2) logarithm of the specified value.  
  
## Syntax  
  
```  
double log2(  
   double x  
);  
  
float log2(  
   float x  
); //C++ only  
  
long double log2(  
   long double x  
); //C++ only  
  
float log2f(  
   float x  
);  
  
long double log2l(  
   long double x  
);  
  
```  
  
#### Parameters  
 [in] `x`  
 The value to determine the base-2 logarithm of.  
  
## Return Value  
 On success, returns return log2 `x`.  
  
 Otherwise, may return one of the following values:  
  
|Issue|Return|  
|-----------|------------|  
|`x` < 0|NaN|  
|`x` = ±0|-INFINITY|  
|`x` = 1|+0|  
|+INFINITY|+INFINITY|  
|NaN|NaN|  
|domain error|NaN|  
|pole error|-HUGE_VAL, -HUGE_VALF, or -HUGE_VALL|  
  
 Errors are reported as specified in [_matherr](../VS_csharp/_matherr.md).  
  
## Remarks  
 If x is an integer, this function essentially returns the zero-based index of the most significant 1 bit of `x`.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|`log2`,                `log2f`,  `log2l`|<math.h>|<cmath\>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../VS_csharp/crt-alphabetical-function-reference.md)   
 [exp2, exp2f, exp2l](../VS_csharp/exp2--exp2f--exp2l.md)   
 [log, logf, log10, log10f](../VS_csharp/log--logf--log10--log10f.md)