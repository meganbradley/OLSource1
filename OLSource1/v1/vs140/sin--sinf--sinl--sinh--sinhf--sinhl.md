---
title: "sin, sinf, sinl, sinh, sinhf, sinhl"
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
  - "sinl"
  - "sinf"
  - "sinhf"
  - "sinh"
  - "sin"
  - "sinhl"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sinl"
  - "sinf"
  - "sinhl"
  - "sinl"
  - "sin"
  - "sinhf"
  - "_sinhl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sinh function"
  - "_sinl function"
  - "_sinhl function"
  - "sinhf function"
  - "sinl function"
  - "calculating sines"
  - "sin function"
  - "trigonometric functions"
  - "sinf function"
  - "sinhl function"
  - "hyperbolic functions"
ms.assetid: 737de73e-3590-45f9-8257-dc1c0c489dfc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sin, sinf, sinl, sinh, sinhf, sinhl
Calculates sines and hyperbolic sines.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Angle in radians.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return the sine of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is greater than or equal to 263, or less than or equal to –263, a loss of significance in the result occurs.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions return the hyperbolic sine of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. By default, if the result is too large, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns ±<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|None|_DOMAIN|  
|± ∞ (sin, sinf, sinl)|INVALID|_DOMAIN|  
|&#124;x&#124; ≥ 7.104760e+002 (sinh, sinhf, sinhl)|OVERFLOW+INEXACT|OVERFLOW|  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> always take and return <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sin( 1.570796 ) = 1.000000**  
**sinh( 1.570796 ) = 2.301299**  
**cos( 1.570796 ) = 0.000000**  
**cosh( 1.570796 ) = 2.509178**   
## .NET Framework Equivalent  
  
-   [System::Math::Sin](https://msdn.microsoft.com/en-us/library/system.math.sin.aspx)  
  
-   [System::Math::Sinh](https://msdn.microsoft.com/en-us/library/system.math.sinh.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [tan, tanf, tanl, tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)   
 [_CIsin](../vs140/_cisin.md)