---
title: "cos, cosf, cosl, cosh, coshf, coshl"
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
  - "coshl"
  - "cosh"
  - "cos"
  - "cosl"
  - "cosf"
  - "coshf"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "coshl"
  - "cos"
  - "cosf"
  - "cosh"
  - "cosl"
  - "coshf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cosines"
  - "cosl function"
  - "calculating cosine"
  - "cosf function"
  - "cos function"
  - "cosh function"
  - "coshf function"
  - "trigonometric functions"
  - "cosines, calculating"
  - "coshl function"
  - "hyperbolic functions"
ms.assetid: ae90435e-6b68-4a47-a81f-be87d5c08f16
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cos, cosf, cosl, cosh, coshf, coshl
Calculates the cosine (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>), or hyperbolic cosine (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Angle in radians.  
  
## Return Value  
 The cosine or hyperbolic cosine of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is greater than or equal to 263, or less than or equal to –263, a loss of significance in the result of a call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> occurs.  
  
 By default, if the result is too large in a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> call, the function returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|none|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|± ∞  (<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|x ≥ 7.104760e+002  (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>+<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> always take and return a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example in [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md).  
  
## .NET Framework Equivalent  
  
-   [System::Math::Cos](https://msdn.microsoft.com/en-us/library/system.math.cos.aspx)  
  
-   [System::Math::Cosh](https://msdn.microsoft.com/en-us/library/system.math.cosh.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [_matherr](../vs140/_matherr.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tan, tanf, tanl, tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [_CIcos](../vs140/_cicos.md)