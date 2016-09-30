---
title: "acosh, acoshf, acoshl"
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
  - "acoshf"
  - "acosh"
  - "acoshl"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "acosh"
  - "acoshf"
  - "acoshl"
  - "math/acosh"
  - "math/acoshf"
  - "math/acoshl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acoshf function"
  - "acosh function"
  - "acoshl function"
ms.assetid: 6985c4d7-9e2a-44ce-9a9b-5a43015f15f7
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# acosh, acoshf, acoshl
Calculates the inverse hyperbolic cosine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return the inverse hyberbolic cosine (arc hyperbolic cosine) of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. These functions are valid over the domain <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ≥ 1. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is less than 1, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the result is a quiet NaN. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a quiet NaN, indefinite, or infinity, the same value is returned.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|--------------------------|  
|± QNAN, IND, INF|none|none|  
|x < 1|none|none|  
  
## Remarks  
 When you use C++, you can call overloads of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> always takes and returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **cosh( 0.785398 ) = 1.324609**  
**acosh( 1.324609 ) = 0.785398**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [cosh](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [sinh](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [asinh](../vs140/asinh--asinhf--asinhl.md)   
 [tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [atanh](../vs140/atanh--atanhf--atanhl.md)   
 [_CItan](../vs140/_citan.md)