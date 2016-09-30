---
title: "asinh, asinhf, asinhl"
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
  - "asinh"
  - "asinhf"
  - "asinhl"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "asinhf"
  - "asinhl"
  - "asinh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "asinh function"
  - "asinhl function"
  - "asinhf function"
ms.assetid: 4488babe-1a7e-44ca-8b7b-c2db0a70084f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# asinh, asinhf, asinhl
Calculates the inverse hyperbolic sine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return the inverse hyberbolic sine (arc hyperbolic sine) of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This function is valid over the floating-point domain. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a quiet NaN, indefinite, or infinity, the same value is returned.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|--------------------------|  
|± QNAN, IND, INF|none|none|  
  
## Remarks  
 When you use C++, you can call overloads of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> always takes and returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sinh( 0.785398 ) = 0.868671**  
**asinh( 0.868671 ) = 0.785398**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [cosh](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [acosh](../vs140/acosh--acoshf--acoshl.md)   
 [sinh](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [atanh](../vs140/atanh--atanhf--atanhl.md)   
 [_CItan](../vs140/_citan.md)