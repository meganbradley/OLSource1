---
title: "exp, expf"
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
  - "expf"
  - "exp"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_expl"
  - "expf"
  - "exp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "exponential calculations"
  - "expf function"
  - "calculating exponentials"
  - "exp function"
ms.assetid: 7070016d-1143-407e-9e9a-6b059bb88867
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exp, expf
Calculates the exponential.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function returns the exponential value of the floating-point parameter, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, if successful. That is, the result is e to the power <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, where e is the base of the natural logarithm. On overflow, the function returns INF (infinite) and on underflow, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns 0.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|None|_DOMAIN|  
|± ∞|INVALID|_DOMAIN|  
|x ≥ 7.097827e+002|INEXACT+OVERFLOW|OVERFLOW|  
|X ≤ -7.083964e+002|INEXACT+UNDERFLOW|UNDERFLOW|  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). See [_set_SSE2_enable](../vs140/_set_sse2_enable.md) for information and restrictions on using the SSE2 implementation.  
  
## Remarks  
 C++ allows overloading, so you can call overloads of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. In a C program, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always takes and returns a double.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **exp( 2.302585 ) = 10.000000**   
## .NET Framework Equivalent  
 [System::Math::Exp](https://msdn.microsoft.com/en-us/library/system.math.exp.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [log, logf, log10, log10f](../vs140/log--logf--log10--log10f.md)   
 [_CIexp](../vs140/_ciexp.md)