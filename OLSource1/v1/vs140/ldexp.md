---
title: "ldexp"
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
  - "ldexp"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ldexp"
  - "_ldexpl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "calculating real numbers"
  - "computing real numbers"
  - "mantissas, floating-point variables"
  - "ldexp function"
  - "exponent, floating-point numbers"
  - "floating-point functions, mantissa and exponent"
ms.assetid: aa7f5310-3879-4f63-ae74-86a39fbdedfa
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ldexp
Multiplies a floating-point number by an integral power of two.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Floating-point value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Integer exponent.  
  
## Return Value  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function returns the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> * 2<sup>exp\</sup> if successful. On overflow, and depending on the sign of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns +/– <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For more information about <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and possible error return values, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that take <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> types. In a C program, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> always takes a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Math::Pow](https://msdn.microsoft.com/en-us/library/system.math.pow.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [frexp](../vs140/frexp.md)   
 [modf, modff, modfl](../vs140/modf--modff--modfl.md)