---
title: "atanh, atanhf, atanhl"
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
  - "atanhl"
  - "atanhf"
  - "atanh"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "atanhl"
  - "atanhf"
  - "atanh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atanhf function"
  - "atanhl function"
  - "atanh funciton"
ms.assetid: 83a43b5b-2580-4461-854f-dc84236d9f32
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atanh, atanhf, atanhl
Calculates the inverse hyperbolic tangent.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return the inverse hyberbolic tangent (arc hyperbolic tangent) of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is greater than 1, or less than –1, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the result is a quiet NaN. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is equal to 1 or -1, a positive or negative infinity is returned, respectively, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|-------------------------|  
|± QNAN,IND|none|none|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> ≥ 1; <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> ≤ -1|none|none|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> always takes and returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **tanh( 0.785398 ) = 0.655794**  
**atanh( 0.655794 ) = 0.785398**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [_CItan](../vs140/_citan.md)