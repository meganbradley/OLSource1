---
title: "exp2, exp2f, exp2l"
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
  - "exp2"
  - "exp2f"
  - "exp2l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
  - "msvcr110_clr400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "exp2"
  - "math/exp2"
  - "exp2f"
  - "math/exp2f"
  - "exp2l"
  - "math/exp2l"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "exp2 function"
  - "exp2f function"
  - "exp2l function"
ms.assetid: 526e3e10-201a-4610-a886-533f44ece344
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# exp2, exp2f, exp2l
Computes 2 raised to the specified value (ie, 2ˣ ).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value of the exponent.  
  
## Return Value  
 If successful, returns the base-2 exponent of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (2ˣ) . Otherwise, may return one of the following values:  
  
|Issue|Return|  
|-----------|------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> = ±0|1|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = -INFINITY|+0|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> = +INFINITY|+INFINITY|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> = NaN|NaN|  
|Overflow range error|+HUGE_VAL, +HUGE_VALF, or +HUGE_VALL|  
|Underflow range error|correct result, after rounding|  
  
 Errors are reported as specified in [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> always takes and returns a double.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [exp](../vs140/exp--expf.md)   
 [log2](../vs140/log2--log2f--log2l.md)