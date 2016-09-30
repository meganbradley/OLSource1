---
title: "asin, asinf, asinl"
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
  - "asinf"
  - "asinl"
  - "asin"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "asin"
  - "asinl"
  - "asinf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "asin function"
  - "asinl function"
  - "asinf function"
  - "trigonometric functions"
  - "arcsine function"
ms.assetid: ca05f9ea-b711-49f6-9f32-2f4019abfd69
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# asin, asinf, asinl
Calculates the arcsine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Value whose arcsine is to be calculated.  
  
## Return Value  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function returns the arcsine (the inverse sine function) of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the range –π/2 to π/2 radians.  
  
 By default, if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is less than –1 or greater than 1, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns an indefinite.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± ∞|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|± <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|none|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|&#124;x&#124;>1|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> always takes and returns a double.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<math.h>|  
  
## Example  
 For more information, see [acos, acosf, acosl](../vs140/acos--acosf--acosl.md).  
  
## .NET Framework Equivalent  
 [System::Math::Asin](https://msdn.microsoft.com/en-us/library/system.math.asin.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [_matherr](../vs140/_matherr.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [tan, tanf, tanl, tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)