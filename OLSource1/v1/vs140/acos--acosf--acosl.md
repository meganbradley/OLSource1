---
title: "acos, acosf, acosl"
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
  - "acosf"
  - "acos"
  - "acosl"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "acos"
  - "acosl"
  - "acosf"
  - "math/acosf"
  - "math/acosl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "acos function"
  - "acosl function"
  - "acosf function"
  - "trigonometric functions"
  - "arccosine function"
ms.assetid: 00b89c48-8faf-4824-aa95-fa4349a4975d
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# acos, acosf, acosl
Calculates the arccosine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Value between –1 and 1, for which to calculate the arccosine (the inverse cosine).  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function returns the arccosine of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the range 0 to π radians.  
  
 By default, if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is less than –1 or greater than 1, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns an indefinite.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± ∞|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|± QNAN,IND|none|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|&#124;x&#124;>1|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> types. In a C program, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<math.h>|\<errno.h>|  
  
## Example  
 This program prompts for a value in the range -1 to 1. Input values outside this range produce <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> error messages. If a valid value is entered, the program prints the arcsine and the arccosine of that value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Arcsine of 0.000000 = 0.000000**  
**Arccosine of 0.000000 = 1.570796**   
## .NET Framework Equivalent  
 [System::Math::Acos](https://msdn.microsoft.com/en-us/library/system.math.acos.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [_matherr](../vs140/_matherr.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tan, tanf, tanl, tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)