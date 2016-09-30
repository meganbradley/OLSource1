---
title: "log, logf, log10, log10f"
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
  - "log10f"
  - "logf"
  - "log10"
  - "log"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "logf"
  - "_log10l"
  - "log"
  - "_logl"
  - "log10f"
  - "log10"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "calculating logarithms"
  - "log10f function"
  - "log10 function"
  - "log function"
  - "logf function"
  - "logarithms"
ms.assetid: 7adc77c2-04f7-4245-a980-21215563cfae
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# log, logf, log10, log10f
Calculates logarithms.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Value whose logarithm is to be found.  
  
## Return Value  
 The **log** functions return the natural logarithm (base e) of *x* if successful. The log10 functions return the base-10 logarithm. If *x* is negative, these functions return an indefinite, by default. If *x* is 0, they return INF (infinite).  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|none|_DOMAIN|  
|± 0|ZERODIVIDE|_SING|  
|x < 0|INVALID|_DOMAIN|  
  
 **log** and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). See [_set_SSE2_enable](../vs140/_set_sse2_enable.md) for information and restrictions on using the SSE2 implementation.  
  
## Remarks  
 C++ allows overloading, so you can call overloads of **log** and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. In a C program, **log** and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> always take and return a double.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**log**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To generate logarithms for other bases, use the mathematical relation: log base b of a == natural log (a) / natural log (b).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::Math::Log](https://msdn.microsoft.com/en-us/library/system.math.log.aspx)  
  
-   [System::Math::Log10](https://msdn.microsoft.com/en-us/library/system.math.log10.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [exp, expf](../vs140/exp--expf.md)   
 [_matherr](../vs140/_matherr.md)   
 [pow, powf, powl](../vs140/pow--powf--powl.md)   
 [_CIlog](../vs140/_cilog.md)   
 [_CIlog10](../vs140/_cilog10.md)