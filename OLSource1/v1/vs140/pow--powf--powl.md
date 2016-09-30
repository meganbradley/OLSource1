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
Calculates <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> raised to the power of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Base.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Exponent.  
  
## Return Value  
 Returns the value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder><sup>y\</sup>. No error message is printed on overflow or underflow.  
  
|Values of x and y|Return value of pow|  
|-----------------------|-------------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> \< > 0 and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = 0.0|1|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> = 0.0 and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> = 0.0|1|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> = 0.0 and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> < 0|INF|  
  
## Remarks  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not recognize integral floating-point values greater than 2<sup>64\</sup> (for example, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). For information and restrictions about using the SSE2 implementation, see [_set_SSE2_enable](../vs140/_set_sse2_enable.md).  
  
 Because C++ allows overloading, you can call any of the various overloads of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. In a C program, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> always takes two double values and returns a double value.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> overload is no longer available. If you use this overload, the compiler may emit C2668. To avoid this problem, cast the first parameter to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Math::Pow](https://msdn.microsoft.com/en-us/library/system.math.pow.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [exp, expf](../vs140/exp--expf.md)   
 [log, logf, log10, log10f](../vs140/log--logf--log10--log10f.md)   
 [sqrt, sqrtf, sqrtl](../vs140/sqrt--sqrtf--sqrtl.md)   
 [_CIpow](../vs140/_cipow.md)