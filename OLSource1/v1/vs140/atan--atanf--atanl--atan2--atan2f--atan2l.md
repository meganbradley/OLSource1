---
title: "atan, atanf, atanl, atan2, atan2f, atan2l"
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
  - "atan2f"
  - "atan2l"
  - "atan2"
  - "atanf"
  - "atan"
  - "atanl"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "atan"
  - "atan2l"
  - "atan2"
  - "atanl"
  - "atanf"
  - "atan2f"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "atan function"
  - "atanf function"
  - "atanl function"
  - "atan2 function"
  - "atan2l function"
  - "arctangent function"
  - "trigonometric functions"
  - "atan2f function"
ms.assetid: 7a87a18e-c94d-4727-9cb1-1bb5c2725ae4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atan, atanf, atanl, atan2, atan2f, atan2l
Calculates the arctangent of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) or the arctangent of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Any numbers.  
  
## Return Value  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns the arctangent of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the range –π/2 to π/2 radians. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns the arctangent of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in the range –π to π radians. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returns 0. If both parameters of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are 0, the function returns 0. All results are in radians.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> uses the signs of both parameters to determine the quadrant of the return value.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|none|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function calculates the arctangent (the inverse tangent function) of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> calculates the arctangent of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> equals 0, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> returns π/2 if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is positive, -π/2 if <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is negative, or 0 if <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is 0.)  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). For information and restrictions about using the SSE2 implementation, see [_set_SSE2_enable](../vs140/_set_sse2_enable.md).  
  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. In a C program, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> always take and return doubles.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<math.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Arctangent of 5.000000: 1.373401**  
**Arctangent of 0.500000 / 5.000000: 0.099669**   
## .NET Framework Equivalent  
  
-   [System::Math::Atan](https://msdn.microsoft.com/en-us/library/system.math.atan.aspx)  
  
-   [System::Math::Atan2](https://msdn.microsoft.com/en-us/library/system.math.atan2.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [_matherr](../vs140/_matherr.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tan, tanf, tanl, tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [_CIatan](../vs140/_ciatan.md)   
 [CIatan2](../vs140/_ciatan2.md)