---
title: "tan, tanf, tanl, tanh, tanhf, tanhl"
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
  - "tanhf"
  - "tanh"
  - "tan"
  - "tanhl"
  - "tanf"
  - "tanl"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tanh"
  - "tan"
  - "_tanl"
  - "tanl"
  - "_tanhl"
  - "tanf"
  - "tanhf"
  - "tanhl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tanl function"
  - "tanhl function"
  - "_tanl function"
  - "_tanhl function"
  - "tan function"
  - "calculating tangents"
  - "tangent"
  - "tanh function"
  - "tanhf function"
  - "tanf function"
  - "trigonometric functions"
  - "hyperbolic functions"
ms.assetid: 36cc0ce8-9c80-4653-b354-ddb3b378b6bd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tan, tanf, tanl, tanh, tanhf, tanhl
Calculates the tangent (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), or hyperbolic tangent (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Angle in radians.  
  
## Return Value  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions return the tangent of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is greater than or equal to 263, or less than or equal to –263, a loss of significance in the result occurs.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions return the hyperbolic tangent of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. There is no error return.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|-------------------------|  
|± QNAN,IND|none|_DOMAIN|  
|± ∞  (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|_DOMAIN|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> always take and return <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **tan( 0.785398 ) = 1.000000**  
**tanh( 1.000000 ) = 0.761594**   
## .NET Framework Equivalent  
  
-   [System::Math::Tan](https://msdn.microsoft.com/en-us/library/system.math.tan.aspx)  
  
-   [System::Math::Tanh](https://msdn.microsoft.com/en-us/library/system.math.tanh.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Long Double](../vs140/long-double.md)   
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)   
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)   
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)   
 [cos, cosf, cosl, cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)   
 [sin, sinf, sinl, sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)   
 [_CItan](../vs140/_citan.md)