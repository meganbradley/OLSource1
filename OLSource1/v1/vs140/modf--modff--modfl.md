---
title: "modf, modff, modfl"
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
  - "modff"
  - "modf"
  - "modfl"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "modff"
  - "_modfl"
  - "modf"
  - "modfl"
  - "math/modf"
  - "math/modff"
  - "math/modfl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "modf function"
  - "modff function"
  - "modfl function"
ms.assetid: b1c7abf5-d476-43ca-a03c-02072a86e32d
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# modf, modff, modfl
Splits a floating-point value into fractional and integer parts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Floating-point value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to stored integer portion.  
  
## Return Value  
 This function returns the signed fractional portion of *x*. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions break down the floating-point value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> into fractional and integer parts, each of which has the same sign as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The signed fractional portion of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is returned. The integer portion is stored as a floating-point value at <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). See [_set_SSE2_enable](../vs140/_set_sse2_enable.md) for information and restrictions on using the SSE2 implementation.  
  
 C++ allows overloading, so you can call overloads of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters. In a C program, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> always takes two double values and returns a double value.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|C: \<math.h>\<br />\<br /> C++: , \<cmath> or \<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [frexp](../vs140/frexp.md)   
 [ldexp](../vs140/ldexp.md)