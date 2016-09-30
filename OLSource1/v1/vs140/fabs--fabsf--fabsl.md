---
title: "fabs, fabsf, fabsl"
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
  - "fabsf"
  - "fabs"
  - "fabsl"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fabs"
  - "fabsf"
  - "fabsl"
  - "math\fabs"
  - "math\fabsf"
  - "math\fabsl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "absolute values"
  - "fabsf function"
  - "calculating absolute values"
  - "fabs function"
  - "fabsl function"
ms.assetid: 23bca210-f408-4f5e-b46b-0ccaaec31e36
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fabs, fabsf, fabsl
Calculates the absolute value of the floating-point argument.  
  
## Syntax  
  
```  
double fabs(   
   double x   
);  
float fabs(  
   float x   
); // C++ only  
long double fabs(  
   long double x  
); // C++ only  
float fabsf(   
   float x   
);  
long double fabsl(  
   long double x  
);  
```  
  
#### Parameters  
 `x`  
 Floating-point value.  
  
## Return Value  
 The `fabs` functions return the absolute value of the argument `x`. There is no error return.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|none|_DOMAIN|  
  
## Remarks  
 C++ allows overloading, so you can call overloads of `fabs` if you include the \<cmath> header. In a C program, `fabs` always takes and returns a double.  
  
## Requirements  
  
|Function|Required C header|Required C++ header|  
|--------------|-----------------------|---------------------------|  
|`fabs`, `fabsf`, `fabsl`|\<math.h>|\<cmath> or \<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [abs](../vs140/abs--labs--llabs--_abs64.md).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [abs, labs, llabs, _abs64](../vs140/abs--labs--llabs--_abs64.md)   
 [_cabs](../vs140/_cabs.md)   
 [labs, llabs](../vs140/labs--llabs.md)